using FinalProjectCSharp2;

namespace EngineTesting
{
    public static class WinGame
    {


        public static void WinningChessGame()
        {
                Commands.AddOnWin(WinCondition1);
        }

        private static void WinCondition1(TileObject tileObject) 
        {
            GameObject gameObject = tileObject as GameObject;

            if (gameObject is ChessKing) //&& gameObject.MovementLogic() == null)
            {
                if(gameObject.Actor==1)
                Console.WriteLine($"Player: {gameObject.Actor} is the winner!!!!");
                else
                    Console.WriteLine($"Player: {gameObject.Actor+1} is the winner!!!!");
                Console.ReadKey();
                Environment.Exit(0);

            }
        }

    }
}
