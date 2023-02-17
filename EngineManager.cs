namespace FinalProjectCSharp2;

class EngineManager : Singelton<EngineManager>, IBehaviorMethods
{

    ////public UpgradedTileMap Grid { get; set; }//private set or method that will set differently, maybe only private and will get access only through Tilemap???
    public RenderingManager renderingManager = new RenderingManager();
    private List<IUpdate> updateables = new List<IUpdate>();
    public List<IUpdate> Updateables { get => updateables; set => updateables = value; }

    public EngineManager()
    {

        IsRunning = true;

    }

    public bool IsRunning { get; private set; }//get is private too?

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
            renderingManager.DrawGrid();
          
            foreach (IUpdate item in Updateables)
            {
                item.Update();
            }

            Menu.TileSelect();
            Console.ReadLine();
            Console.Clear();
       
        }
    }





}