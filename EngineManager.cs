using System.Runtime.InteropServices;

namespace FinalProjectCSharp2;

public class EngineManager // : Engine???
{

    public UpgradedTileMap Grid { get; set; }//private set or method that will set differently, maybe only private and will get access only through Tilemap???
    public RenderingManager renderingManager = new RenderingManager();
   

    

    public EngineManager()
    {
        Grid = renderingManager.TileMap;
        IsRunning = true;

    }

    public bool IsRunning { get; private set; }//get is private too?



    public void Start() 
    {
        GameObject gameObject1 = new GameObject('d');
        renderingManager.ChangeGridToChessGrid(' ', ConsoleColor.Red);
        Grid.Grid[0, 4].gameObject = gameObject1;
    }



    public void Pause()
    {
        IsRunning = !IsRunning;
    }

    public void EngineLoop()
    {
        Start();
        while (IsRunning) //gameloop
        {
            Update();
        }
    }

    public void EngineLoop(GameObject gameObject, GameObject gameObject2)
    {
        Start();
        while (IsRunning) //gameloop
        {
            Grid.Grid[0, 0].gameObject = gameObject;
            Grid.Grid[0, 2].gameObject = gameObject;
            //tilemap.Grid[1, 0].gameObject = gameObject;
            //tilemap.Grid[1,2].gameObject = gameObject;

            //tilemap.Grid[3, 0].gameObject = gameObject2;
            //tilemap.Grid[3, 2].gameObject = gameObject2;
            //tilemap.Grid[4, 0].gameObject = gameObject2;
            //tilemap.Grid[4, 2].gameObject = gameObject2;

     
            Update();

        }
    }

    public void Update()
    {
        Console.Clear();
        renderingManager.DrawGrid();
        Thread.Sleep(500);
    }
}