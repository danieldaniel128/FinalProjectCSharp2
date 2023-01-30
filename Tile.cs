using System.Numerics;

namespace FinalProjectCSharp2;

public class Tile : BaseTile
{
    public override Vector2 Position { get; protected set; }

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

    public Tile(int x, int y)
    {
        Position = new Vector2(x, y);
        gameObject = null;
    }

    public Tile(int x, int y,char tileChar,ConsoleColor tileColor=ConsoleColor.White) : base(tileChar)
    {
        Position = new Vector2(x, y);
        TileColor = tileColor;
        gameObject = null;
    }
    public Tile(int x, int y, TileObject gameObject)
    {
        Position = new Vector2(x, y);
        this.gameObject = gameObject;
    }


}