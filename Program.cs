

using FinalProjectCSharp2;

class Program
{
    public static void Main(string[] args)
    {
     
        UpgradedTileMap.Instance.Inititialize(8, 8);
        GameObject gameObject = new GameObject('f', ConsoleColor.DarkYellow);
        GameObject gameObject2 = new GameObject('T', ConsoleColor.DarkGreen);
        EngineManager.Instance.renderingManager.ChangeGridToChessGrid(' ', ConsoleColor.DarkRed);
        EngineManager.Instance.renderingManager.PlaceGameObjectOnGrid(gameObject, new MyVector2(0, 0), new MyVector2(7, 1)); //Create gameObjects and place them on the grid in a forLoop
        UpdateTest ut = new UpdateTest(gameObject);

        EngineManager.Instance.EngineLoop();

    }
}