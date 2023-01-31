using System.Numerics;

namespace FinalProjectCSharp2;

public abstract class BaseTile
{

    public abstract MyVector2 Position { get; protected set; }

    public abstract TileObject gameObject { get; set; }

    private string _tileContainer;
    public virtual string TileContainer { get {return _tileContainer; } set=> _tileContainer=value; }
    public ConsoleColor TileColor { get; set; }


    public BaseTile()
    {
        //TileContainer = "[ ]";
        gameObject = null;
    }

    public BaseTile(char tileObject, ConsoleColor tileColor = ConsoleColor.White)
    {
        TileColor = tileColor;
        //TileContainer = "[ ]";
        //TileContainer = TileContainer.Replace(' ', tileObject);
        gameObject = null;
    }
    public BaseTile(TileObject gameObject)
    {

        this.gameObject = gameObject;
       // if (gameObject != null)
        //    TileContainer = $"[{gameObject.ObjectChar}]";
        //else
        //    TileContainer = "[ ]";
    }


    
}