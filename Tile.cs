using System.Numerics;

namespace FinalProjectCSharp2;

public class Tile : BaseTile
{
    public override Vector2 Position { get; protected set; }
    public override TileObject _gameObject { get; protected set; }

    public Tile(int x, int y)
    {
        Position = new Vector2(x, y);
        TileContainer = "[ ]";
        _gameObject = null;
    }

    public Tile(int x, int y,char tileObject,ConsoleColor tileColor=ConsoleColor.White) : base(tileObject)
    {
        Position = new Vector2(x, y);
        TileColor = tileColor;
        TileContainer = "[0 ]";
        TileContainer=TileContainer.Replace(' ', tileObject);
        _gameObject = null;
    }
    public Tile(int x, int y, TileObject gameObject)
    {
        Position = new Vector2(x, y);
        _gameObject = gameObject;
    }


}