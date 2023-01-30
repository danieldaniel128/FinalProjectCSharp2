namespace FinalProjectCSharp2;

public class EngineManager // : Engine???
{

    public UpgradedTileMap Grid { get; set; }//private set or method that will set differently, maybe only private and will get access only through Tilemap???
    

    public EngineManager(UpgradedTileMap tileMap)
    {
        Grid = tileMap;
        IsRunning = true;
    }

    public bool IsRunning { get; private set; }//get is private too?



    public void Start() 
    {
        GameObject gameObject1 = new GameObject('d');
        Grid.ChangeGridToChessGrid(' ', ConsoleColor.Red);
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

    public void Update()
    {
        Console.Clear();
        Grid.DrawGrid();
        Thread.Sleep(500);
    }
}