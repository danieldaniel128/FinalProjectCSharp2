using EngineTesting;
using FinalProjectCSharp2;

class Program
{
    
    public static void Main(string[] args)
    {
        TileMap.Instance.Inititialize(8, 8);
        GameObjectCreator<ChessQueen>.AddToGrid(0, 'E', new MyVector2(0,0), new MyVector2(7,1),  ConsoleColor.DarkGreen);
        GameObjectCreator<KingObject>.AddToGrid(1, 'T', new MyVector2(0, 6), new MyVector2(0,6), ConsoleColor.Blue);
        WinGame.WinningGame(TileMap.Instance.Grid[0,6].gameObject);

        EngineManager.Instance.EngineLoop();

    }

    


}