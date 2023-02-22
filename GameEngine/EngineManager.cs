namespace FinalProjectCSharp2;

public class EngineManager : Singelton<EngineManager>, IBehaviorMethods
{

    ////public UpgradedTileMap Grid { get; set; }//private set or method that will set differently, maybe only private and will get access only through Tilemap???
    private List<IUpdate> updateables = new List<IUpdate>();
    public List<IUpdate> Updateables { get => updateables; set => updateables = value; }
    public bool IsRunning { get; private set; }//get is private too?

    IRenderingMediator rendering = new RenderingManager();

    public EngineManager()
    {
       
        IsRunning = true;
    }


    public virtual void Start()
    {

    }


    public virtual void Update()
    {

    }

    public void AddUpdateable(IUpdate update)
    {
        Updateables.Add(update);
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
            rendering.DrawGrid();
          
            foreach (IUpdate item in Updateables)
            {
                item.Update();
            }

            Commands.TileSelect();
            Console.ReadLine();
            Console.Clear();
       
        }
    }





}