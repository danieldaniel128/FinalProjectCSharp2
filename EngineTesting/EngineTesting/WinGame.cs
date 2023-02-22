using FinalProjectCSharp2;

namespace EngineTesting
{
    public static class WinGame
    {

        public static void WinningGame(TileObject tileObject)
        {
            GameObject gameObject = tileObject as GameObject;

            if (gameObject is KingObject && gameObject.MovementLogic() == null)
            {
                Console.WriteLine("lolololo");
                Commands.WinCondition(WinningGame);
                Commands.FinishGame(gameObject);
                Console.ReadKey();
            }
        }

    }
}
