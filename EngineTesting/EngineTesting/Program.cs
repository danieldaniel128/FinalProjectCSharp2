using EngineTesting;
using FinalProjectCSharp2;

class Program
{
    
    public static void Main(string[] args)
    {
        TileMap.Instance.Inititialize(8, 8);

        ConsoleColor player1Color = ConsoleColor.DarkGreen;

        GameObjectCreator<ChessBiShop>.AddToGrid(0, 'B', new MyVector2(2, 0), new MyVector2(2, 0), player1Color);
        GameObjectCreator<ChessBiShop>.AddToGrid(0, 'B', new MyVector2(5, 0), new MyVector2(5, 0), player1Color);
                                                                                                   
        GameObjectCreator<ChessQueen>.AddToGrid(0, 'Q', new MyVector2(3, 0), new MyVector2(3, 0), player1Color);
        GameObjectCreator<ChessKing>.AddToGrid(0, 'K', new MyVector2(4, 0), new MyVector2(4, 0), player1Color);
                                                                                                   
        GameObjectCreator<ChessRook>.AddToGrid(0, 'R', new MyVector2(0, 0), new MyVector2(0, 0), player1Color);
        GameObjectCreator<ChessRook>.AddToGrid(0, 'R', new MyVector2(7, 4), new MyVector2(7, 4), player1Color);
                                                                                                   
        GameObjectCreator<ChessKnight>.AddToGrid(0, 'k', new MyVector2(1, 0), new MyVector2(1, 0), player1Color);
        GameObjectCreator<ChessKnight>.AddToGrid(0, 'k', new MyVector2(6, 0), new MyVector2(6, 0), player1Color);

        //GameObjectCreator<ChessPawn>.AddToGrid(0, 'P', new MyVector2(0, 1), new MyVector2(7, 1), player1Color);


        ConsoleColor player2Color =ConsoleColor.Yellow;
        GameObjectCreator<ChessRook>.AddToGrid(1, 'R', new MyVector2(0, 7), new MyVector2(0, 7), player2Color);
        GameObjectCreator<ChessRook>.AddToGrid(1, 'R', new MyVector2(7, 7), new MyVector2(7, 7), player2Color);

        GameObjectCreator<ChessKnight>.AddToGrid(1, 'k', new MyVector2(1, 7), new MyVector2(1, 7), player2Color);
        GameObjectCreator<ChessKnight>.AddToGrid(1, 'k', new MyVector2(6, 7), new MyVector2(6, 7), player2Color);

        GameObjectCreator<ChessBiShop>.AddToGrid(1, 'B', new MyVector2(2, 7), new MyVector2(2, 7), player2Color);
        GameObjectCreator<ChessBiShop>.AddToGrid(1, 'B', new MyVector2(5, 7), new MyVector2(5, 7), player2Color);

        GameObjectCreator<ChessQueen>.AddToGrid(1, 'Q', new MyVector2(3, 7), new MyVector2(3, 7), player2Color);
        GameObjectCreator<ChessKing>.AddToGrid(1, 'K', new MyVector2(4, 7), new MyVector2(4, 7), player2Color);

        GameObjectCreator<ChessPawn>.AddToGrid(1, 'P', new MyVector2(0, 6), new MyVector2(7, 6), player2Color);

        WinGame.WinningChessGame();

        EngineManager.Instance.EngineLoop();

    }

    


}