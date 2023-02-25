namespace FinalProjectCSharp2;

public class EngineManager : Singelton<EngineManager>
{

    public bool IsRunning { get; private set; }

    private IRendering rendering = new RenderingManager();
    public IRendering Rendering { get => rendering; private set => rendering = value; }


    /// <summary>
    /// This Class is the core of the engine
    /// </summary>
    public EngineManager()
    {
        IsRunning = true;
    }

    /// <summary>
    /// This method pauses the engine
    /// </summary>

    public void Pause()
    {
        IsRunning = !IsRunning;
    }

    /// <summary>
    /// This method activates the engine
    /// </summary>
    public void EngineLoop()
    {


        while (IsRunning) //gameloop
        {
            Rendering.ChangeGridToChessGrid();
            Rendering.DrawGrid();

            Commands.TileSelect();
            Console.ReadLine();
            Console.Clear();

        }
    }





}