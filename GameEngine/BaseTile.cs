namespace FinalProjectCSharp2;

public abstract class BaseTile
{
    public abstract MyVector2 Position { get; protected set; }

    public abstract TileObject gameObject { get; set; }

    private string _tileContainer;

    /// <summary>
    /// Contains TileObjects
    /// </summary>
    public virtual string TileContainer { get { return _tileContainer; } set => _tileContainer = value; }
    public ConsoleColor TileColor { get; set; }

    /// <summary>
    /// Creates Tile 
    /// </summary>

    public BaseTile()
    {
        gameObject = null;
    }

    /// <summary>
    /// Creates tile with color
    /// </summary>
    /// <param name="tileObject"></param>
    /// <param name="tileColor"></param>
    public BaseTile(ConsoleColor tileColor = ConsoleColor.White)
    {
        TileColor = tileColor;
        gameObject = null;
    }

    /// <summary>
    /// Creates GameObject Tile
    /// </summary>
    /// <param name="gameObject"></param>
    public BaseTile(TileObject gameObject)
    {
        this.gameObject = gameObject;
    }



}