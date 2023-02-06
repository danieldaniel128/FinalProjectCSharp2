namespace FinalProjectCSharp2;

class EngineManager : IBehaviorMethods
{

    ////public UpgradedTileMap Grid { get; set; }//private set or method that will set differently, maybe only private and will get access only through Tilemap???
    public RenderingManager renderingManager = new RenderingManager();
    private List<IUpdate> updateables = new List<IUpdate>();
    public List<IUpdate> Updateables { get => updateables; set => updateables = value; }


    private static EngineManager instance;
    public static EngineManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new EngineManager();
            }

            return instance;
        }
    }




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
            foreach (IUpdate item in Updateables)
            {
                item.Update();
            }


            // menu (grid buttons, point an object)
            Console.ReadLine();

            Console.Clear();
            renderingManager.DrawGrid();
       
        }
    }





}