

using FinalProjectCSharp2;

class Program
{

    public static void Main(string[] args)
    {
        TileMap.Instance.Inititialize(8, 8);
        Tile[,] grid = TileMap.Instance.Grid;
        GameObjectCreator<CheckerObject>.AddToGrid(0, 'f', new MyVector2(0, 0), new MyVector2(7, 1), ConsoleColor.DarkGreen);
        GameObjectCreator<CheckerObject>.AddToGrid(1, 'T', new MyVector2(0, 6), new MyVector2(7, 7), ConsoleColor.Blue);
        GameObjectCreator<CheckerObject>.AddToGrid(1, 'p', new MyVector2(3, 7), new MyVector2(4, 7), ConsoleColor.Yellow);
        EngineManager.Instance.renderingManager.ChangeGridToChessGrid(ConsoleColor.DarkRed);
        EngineManager.Instance.EngineLoop();

        //Need Restriction : when it's the turn of actor 0, and i go the grid of actor 1, and object will appear on actor 0's part

    }



   
}