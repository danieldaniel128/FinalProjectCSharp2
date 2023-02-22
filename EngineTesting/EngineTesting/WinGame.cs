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

            if (gameObject is KingObject) //&& gameObject.MovementLogic() == null)
            {
                Console.WriteLine($"Player: {gameObject.Actor+1} is winner");
                Console.ReadKey();
            }
        }

    }
}
