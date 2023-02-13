namespace FinalProjectCSharp2
{
    public static class Menu
    {




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


        public static void TileSelect()
        {
            Tile[,] grid = TileMap.Instance.Grid;
            int x = 0; int y = 0;
            ConsoleColor previousColor = grid[x, y].TileColor;
            bool isTilePlaced = false;
            TileObject? MovingObject = null;

            int new_x = x;
            int new_y = y;


            while (true)
            {

                ConsoleKey key = Console.ReadKey().Key;


                switch (key)
                {
                    case ConsoleKey.Enter:
                        if (!isTilePlaced)
                        {
                            Console.WriteLine("Move the tile to the desired direction through the keyboard keys");
                            Console.WriteLine("1. The player can move to :" + (grid[x++, y].Position));
                            Console.WriteLine("2. The player can move to :" + (grid[x--, y].Position));
                            Console.WriteLine("3. The player can move to :" + (grid[x, y++].Position));
                            Console.WriteLine("4. The player can move to :" + (grid[x, y--].Position));
                            Console.ReadKey();
                            MovingObject = (TileObject?)grid[x, y].gameObject.Clone();
                            grid[x, y].gameObject = null;
                            grid[x, y].TileColor = previousColor;
                            isTilePlaced = true;


                        }
                        else
                        {
                            if (MovingObject != null)
                            {
                                grid[new_x, new_y].gameObject = MovingObject;
                                grid[new_x, new_y].TileColor = ConsoleColor.Magenta;
                                MovingObject = null;
                                isTilePlaced = false;
                            }

                        }

                        break;
                    case ConsoleKey.RightArrow:

                        new_x = Math.Min(grid.GetLength(1) - 1, x + 1);
                        grid[x, y].TileColor = previousColor;
                        previousColor = grid[new_x, y].TileColor;
                        grid[new_x, y].TileColor = ConsoleColor.Magenta;

                        x = new_x;
                        break;

                    case ConsoleKey.LeftArrow:

                        new_x = Math.Max(0, x - 1);
                        grid[x, y].TileColor = previousColor;
                        previousColor = grid[new_x, y].TileColor;
                        grid[new_x, y].TileColor = ConsoleColor.Magenta;
                        x = new_x;
                        break;

                    case ConsoleKey.UpArrow:

                        new_y = Math.Max(0, y - 1);
                        grid[x, y].TileColor = previousColor;
                        previousColor = grid[x, new_y].TileColor;
                        grid[x, new_y].TileColor = ConsoleColor.Magenta;
                        y = new_y;
                        break;

                    case ConsoleKey.DownArrow:
                        new_y = Math.Min(grid.GetLength(0) - 1, y + 1);
                        grid[x, y].TileColor = previousColor;
                        previousColor = grid[x, new_y].TileColor;
                        grid[x, new_y].TileColor = ConsoleColor.Magenta;
                        y = new_y;
                        break;
                }

                x = new_x;
                y = new_y;
                ReDrawGrid();
            }



        }
    }
}






