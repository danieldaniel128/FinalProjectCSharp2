using System.ComponentModel;
using System.Runtime.CompilerServices;
using FinalProjectCSharp2;


   
    class Engine : EngineManager
    {
 

      private void Start()
    {
      


    }
     private void Update()
    {
        renderingManager.TileMap = new UpgradedTileMap(8, 8);
        GameObject gameObject = new GameObject('f', ConsoleColor.DarkYellow);
        GameObject gameObject2 = new GameObject('T', ConsoleColor.DarkGreen);
        renderingManager.ChangeGridToChessGrid(' ', ConsoleColor.DarkRed);
        renderingManager.PlaceGameObjectOnGrid(gameObject, new MyVector2(0, 0), new MyVector2(7, 1));
        Console.Clear();
        renderingManager.DrawGrid();
        Thread.Sleep(500);
    }

    
    }

