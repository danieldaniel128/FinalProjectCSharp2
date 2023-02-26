using System.Numerics;

namespace FinalProjectCSharp2;

public class Tile : BaseTile
{
    public override MyVector2 Position { get; protected set; }

    private TileObject _gameObject;
    
    public override TileObject gameObject { get => _gameObject;  
        set 
        {
            _gameObject=value;
            if (_gameObject != null)
                TileContainer = $"[{_gameObject.ObjectChar}]";
            else
                TileContainer = "[ ]";
        }  
    }
    public override string TileContainer { get; set; }

    /// <summary>
    /// Creates a tile with index on grid
    /// </summary>
    /// <param name="x"></param>
    /// <param name="y"></param>
    public Tile(int x, int y)
    {
        Position = new MyVector2(x, y);
        gameObject = null;
    }

    /// <summary>
    /// creates a tile with index on grid and its color. default color is white
    /// </summary>
    /// <param name="x"></param>
    /// <param name="y"></param>
    /// <param name="tileColor"></param>
    public Tile(int x, int y,ConsoleColor tileColor=ConsoleColor.White) : base(tileColor)
    {
        Position = new MyVector2(x, y);
        TileColor = tileColor;
        gameObject = null;
    }

    /// <summary>
    /// creates a tile with index on grid and attach to it a TileObject
    /// </summary>
    /// <param name="x"></param>
    /// <param name="y"></param>
    /// <param name="gameObject"></param>
    public Tile(int x, int y, TileObject gameObject)
    {
        Position = new MyVector2(x, y);
        this.gameObject = gameObject;
    }


}