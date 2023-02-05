using System.Runtime.InteropServices;

namespace FinalProjectCSharp2;

abstract class EngineManager : IBehaviorMethods
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

    }



    public void Pause()
    {
        IsRunning = !IsRunning;
    }

    public  void EngineLoop()
    {
        
        Start();
        while (IsRunning) //gameloop
        {         
            Update();
        }
    }



     public virtual void Update()
    {
        //Console.WriteLine("hh");
        //Console.Clear();
        //renderingManager.DrawGrid();
        //Thread.Sleep(500);
    }


}