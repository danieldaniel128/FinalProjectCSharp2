namespace FinalProjectCSharp2
{

   
    class DemoImplmentation
    {
        public static void Implment()
        {
            UpgradedTileMap tilemap = new UpgradedTileMap(5, 5);
            GameObject gameObject = new GameObject('f', ConsoleColor.DarkYellow);
            GameObject gameObject2 = new GameObject('T', ConsoleColor.DarkGreen);
            EngineManager engineManager = new EngineManager(tilemap);
            engineManager.EngineLoop(gameObject,gameObject2, tilemap);


        }
    }
}
