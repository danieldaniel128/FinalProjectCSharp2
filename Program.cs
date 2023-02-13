

using FinalProjectCSharp2;

class Program
{
    
    public static void Main(string[] args)
    {
        TileMap.Instance.Inititialize(8, 8);
        Tile[,] grid = TileMap.Instance.Grid;
        GameObject gameObject = new GameObject('f', ConsoleColor.DarkYellow);
        GameObject gameObject2 = new GameObject('T', ConsoleColor.DarkGreen);
        EngineManager.Instance.renderingManager.ChangeGridToChessGrid(' ', ConsoleColor.DarkRed);
        EngineManager.Instance.renderingManager.PlaceGameObjectOnGrid(gameObject, new MyVector2(0, 0), new MyVector2(7, 1)); //Create gameObjects and place them on the grid in a forLoop
        UpdateTest ut = new UpdateTest(gameObject);
        grid[0, 0].gameObject = gameObject2;
        //gameObject.position(0,0) = gameObject2

        // Kremer - Menu! (inputs , left arrow, right , up , down. on the Grid[])
        // Daniel - Movement! (also, please connect Transform.Position to Grid[position].gameObject)
        // Roee - is now sleeping , do not disturb, having nightmares of gameDesign

        EngineManager.Instance.EngineLoop();

    }
}