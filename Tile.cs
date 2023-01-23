using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

public class Tile
{
    Vector2 position;
    GameObject gameObject;
    public string tileContainer;

    public Tile(int x, int y)
    {
        position.X = x;
        position.Y = y;
        tileContainer = "[ ]";
        gameObject = null;
    }
    public Tile(int x, int y,char tileObject)
    {
        position.X = x;
        position.Y = y;
        tileContainer = "[ ]";
        tileContainer=tileContainer.Replace(' ', tileObject);
        gameObject = null;
    }
    public Tile(int x, int y, GameObject gameObject)
    {
        position.X = x;
        position.Y = y;
        this.gameObject = gameObject;
    }
}
   

