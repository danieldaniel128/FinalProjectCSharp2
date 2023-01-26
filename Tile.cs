using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

public class Tile 
{
    Vector2 _position;
    GameObject _gameObject;
    public string TileContainer;

    public Tile(int x, int y)
    {
        _position.X = x;
        _position.Y = y;
        TileContainer = "[ ]";
        _gameObject = null;
    }

    public Tile(int x, int y,char tileObject)
    {
        _position.X = x;
        _position.Y = y;
        TileContainer = "[ ]";
        TileContainer=TileContainer.Replace(' ', tileObject);
        _gameObject = null;
    }
    public Tile(int x, int y, GameObject gameObject)
    {
        _position.X = x;
        _position.Y = y;
        this._gameObject = gameObject;
    }
}
   

