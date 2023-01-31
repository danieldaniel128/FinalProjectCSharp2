namespace FinalProjectCSharp2
{

   
    class DemoImplmentation
    {
        public static void Implement()
        {
          
            UpgradedTileMap tileMap = new UpgradedTileMap(8, 8);
            GameObject gameObject = new GameObject('f', ConsoleColor.DarkYellow);
            GameObject gameObject2 = new GameObject('T', ConsoleColor.DarkGreen);
            //EngineManager engineManager = new EngineManager(tileMap);
            tileMap.ChangeGridToChessGrid(' ', ConsoleColor.Red);
           // tileMap.AddGameObjectToGrid(gameObject2, new MyVector2(0,1));
            tileMap.AddGameObjectToGrid(gameObject, new MyVector2(0,0), new MyVector2(7,1));

            //tileMap.PlaceGameObjectsOnGrid(gameObject);
            //tileMap.Grid[1, 1].gameObject = gameObject;
            //tileMap.Grid[2, 2].gameObject = gameObject2;
            tileMap.DrawGrid();
           // engineManager.EngineLoop();


        }
    }
}
