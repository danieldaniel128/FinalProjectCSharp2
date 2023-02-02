using System.ComponentModel;

namespace FinalProjectCSharp2
{

   
    class DemoImplmentation
    {
        public static void Implement()
        {
          
            // engine components
            EngineManager engine = new EngineManager();
            engine.renderingManager.TileMap = new UpgradedTileMap(8,8);



            // engine components

            
            GameObject gameObject = new GameObject('f', ConsoleColor.DarkYellow);
            GameObject gameObject2 = new GameObject('T', ConsoleColor.DarkGreen);
            engine.renderingManager.ChangeGridToChessGrid(' ', ConsoleColor.DarkRed); 
            engine.renderingManager.PlaceGameObjectOnGrid(gameObject, new MyVector2(0, 0), new MyVector2(7, 1));
            engine.renderingManager.DrawGrid();



        }
    }
}
