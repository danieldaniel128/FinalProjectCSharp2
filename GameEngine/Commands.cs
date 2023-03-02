using System.Runtime.CompilerServices;

namespace FinalProjectCSharp2
{
    public static class Commands
    {

        /// <summary>
        /// This event let's the user insert a winning logic through a method to the game
        /// </summary>
        public static event Action<TileObject> OnWin;

        /// <summary>
        /// Returns the current Turn on the game's loop, starting from 0
        /// </summary>
        public static int Turn { get; private set; }
        public static bool IsWon { get; private set; }
        /// <summary>
        /// Redraws the grid
        /// </summary>
        public static void ReDrawGrid()
        {
            Console.Clear();

            Tile[,] grid = TileMap.Instance.Grid;


            for (int y = 0; y < grid.GetLength(1); y++)
            {
                for (int x = 0; x < grid.GetLength(0); x++)
                {
                    Console.ForegroundColor = grid[x, y].TileColor;
                    Console.Write(grid[x, y].TileContainer);
                }
                Console.WriteLine();
            }

            Console.ResetColor();
        }

        /// <summary>
        /// checks if any method is subscirbed to the "OnWin" event at the end of every turn
        /// </summary>
        /// <param name="gameObject"></param>
        public static void FinishGame(TileObject gameObject)
        {
            if (OnWin != null)
                IsWon = true;
                OnWin?.Invoke(gameObject);
        }

        /// <summary>
        /// Subscirbes to the "OnWin" Event
        /// </summary>
        /// <param name="action"></param>
        public static void AddOnWin(Action<TileObject> action)
        {
            OnWin += action;
        }

        /// <summary>
        /// Removes Subscirbed nethods from the "OnWin" Event
        /// </summary>
        /// <param name="action"></param>
        public static void RemoveOnWin(Action<TileObject> action)
        {
            OnWin -= action;
        }

        /// <summary>
        /// This method gives the player the option to move on the grid
        /// </summary>
        public static void TileSelect()
        {
            Tile[,] grid = TileMap.Instance.Grid;
            int x = 0; int y = 0;
            ConsoleColor previousColor = grid[x, y].TileColor;
            bool isTilePlaced = false;
            TileObject? MovingObject = null;
            MyVector2 startPosition = new MyVector2();
            List<MyVector2> canMoveToPositions = new List<MyVector2>();

            int new_x = x;
            int new_y = y;
            EngineManager.Instance.Rendering.AddToPrint($"Turn Player: {Turn % 2 + 1}");
            EngineManager.Instance.Rendering.PrintToUser();

            while (true)
            {
                ConsoleKey key = Console.ReadKey().Key;


                switch (key)
                {
                    case ConsoleKey.Enter:
                        if (!isTilePlaced)
                        {
                            MovingObject = (TileObject?)grid[x, y].gameObject?.Clone();
                            if (Turn % 2 == MovingObject?.Actor)
                                if (MovingObject != null)
                                {
                                    MovingObject.transform.Position = new MyVector2(x, y);
                                    startPosition = MovingObject.transform.Position;
                                    canMoveToPositions = MovementRule.Instance.PositionsToMoveObject((GameObject)MovingObject);
                                    grid[x, y].gameObject = null;

                                }
                            grid[x, y].TileColor = previousColor;
                            isTilePlaced = true;
                        }
                        else
                        {
                            if (MovingObject != null)
                            {
                                bool placedRight = false;
                                foreach (MyVector2 canMoveToPose in canMoveToPositions)
                                    if (canMoveToPose == new MyVector2(new_x, new_y))
                                    {
                                        TileObject KilledObject = null;
                                        if (grid[new_x, new_y].gameObject != null)
                                            KilledObject = (TileObject)grid[new_x, new_y].gameObject.Clone();
                                        grid[new_x, new_y].gameObject = MovingObject;
                                        grid[new_x, new_y].TileColor = ConsoleColor.Magenta;



                                        if (MovingObject.Actor == 0 && canMoveToPositions.Count == 0)
                                            MovingObject = null;
                                        isTilePlaced = false;
                                        placedRight = true;
                                        grid[new_x, new_y].gameObject?.MakeStep();
                                        Turn++;
                                        EngineManager.Instance.Rendering.ClearPrint();
                                        EngineManager.Instance.Rendering.AddToPrint($"Turn Player: {Turn % 2 + 1}");
                                        MovingObject?.RemoveSteps();
                                        if (KilledObject != null)
                                            FinishGame(KilledObject);
                                        break;

                                    }
                                if (!placedRight)
                                {
                                    grid[startPosition.X, startPosition.Y].gameObject = (TileObject)MovingObject.Clone();
                                    MovingObject = null;
                                }
                            }
                            grid[x, y].TileColor = previousColor;
                            isTilePlaced = false;
                            EngineManager.Instance.Rendering.ChangeGridToChessGrid(ConsoleColor.Red);

                        }

                        break;
                    case ConsoleKey.RightArrow:
                        if (MovingObject != null)
                            MovementRule.Instance.MoveRight(MovingObject);


                        new_x = Math.Min(grid.GetLength(1) - 1, x + 1);
                        grid[x, y].TileColor = previousColor;
                        previousColor = grid[new_x, y].TileColor;
                        grid[new_x, y].TileColor = ConsoleColor.Magenta;

                        x = new_x;
                        break;

                    case ConsoleKey.LeftArrow:
                        if (MovingObject != null)
                            MovementRule.Instance.MoveLeft(MovingObject);

                        new_x = Math.Max(0, x - 1);
                        grid[x, y].TileColor = previousColor;
                        previousColor = grid[new_x, y].TileColor;
                        grid[new_x, y].TileColor = ConsoleColor.Magenta;
                        x = new_x;
                        break;

                    case ConsoleKey.UpArrow:
                        if (MovingObject != null)
                            MovementRule.Instance.MoveUp(MovingObject);

                        new_y = Math.Max(0, y - 1);
                        grid[x, y].TileColor = previousColor;
                        previousColor = grid[x, new_y].TileColor;
                        grid[x, new_y].TileColor = ConsoleColor.Magenta;
                        y = new_y;
                        break;

                    case ConsoleKey.DownArrow:
                        if (MovingObject != null)
                            MovementRule.Instance.MoveDown(MovingObject);

                        new_y = Math.Min(grid.GetLength(0) - 1, y + 1);
                        grid[x, y].TileColor = previousColor;
                        previousColor = grid[x, new_y].TileColor;
                        grid[x, new_y].TileColor = ConsoleColor.Magenta;
                        y = new_y;
                        break;
                    case ConsoleKey.R:
                        if (MovingObject != null && MovingObject.Actor == Turn % 2)
                        {
                            grid[startPosition.X, startPosition.Y].gameObject = (TileObject)MovingObject.Clone();
                            MovingObject = null;
                            grid[x, y].TileColor = previousColor;
                            isTilePlaced = false;
                            EngineManager.Instance.Rendering.ChangeGridToChessGrid(ConsoleColor.Red);
                        }
                        break;
                }



                x = new_x;
                y = new_y;

                EngineManager.Instance.Rendering.DrawGrid();



            }
        }

        public static void Print(string message)
        {
            EngineManager.Instance.Rendering.AddToPrint(message);
            EngineManager.Instance.Rendering.PrintToUser();
        }

    }
}






