namespace FinalProjectCSharp2;

public abstract class TileObject : IUpdate, IComparer<TileObject>, ICloneable
{
    public event Action OnMoved;
    public char ObjectChar = 'o';
    public ConsoleColor Color = ConsoleColor.Green;

    public abstract List<Component> Components { get; protected set; }
    public Transform transform { get; set; }
    //Components[0] as Transform;



    public TileObject(char objectChar,ConsoleColor color)
    {
        Components = new List<Component>();
        Components.Add(new Transform(this));
        ObjectChar = objectChar;
        Color = color;
        transform = Components[0] as Transform;
    }

    public bool Step(MyVector2 direction)
    {
        
        MyVector2 normlizedDirection = direction.Normalized;

        transform.Position += normlizedDirection;

        return true;
    }

   

    public void Update()
    {

        foreach (var component in Components)
        {
            component.Update();
        }
    }

    public void AddComponent(Component component)
    {
        Components.Add(component);
    }


    public int Compare(TileObject? a, TileObject? b)
    {
        // should compare positions
        if (a.transform.Position == b.transform.Position)
        {
            OnMoved.Invoke();
            return 0;
        }
        if (a.transform.Position < b.transform.Position)
        {
            return -1;
        }
        if (a.transform.Position > b.transform.Position)
        {
            return 1;
        }
        else
        {
            return -4; // a placeHolder
        }
    }


    public object Clone()
    {
        var tileObject = (TileObject)MemberwiseClone();
        tileObject.transform = new Transform(tileObject);
        return tileObject;
    }

  
}
public static class TileObjectExtensions
{
    public static void PutTileObjectOnBoard(this TileObject tileObject,TileMap tileMap, MyVector2 newPosition)
    {
        if (newPosition.X <= tileMap.Width && newPosition.Y <= tileMap.Height)
        {
            tileObject.transform.Position = newPosition;
            
        }
    }



    /// <summary>
    /// will move the position of the TileObject to a new chosen Position in a fixed speed
    /// </summary>
    /// <param name="tileObject"></param>
    /// <param name="newPosition"></param>
    /// <param name="speed"></param>
    public static void MoveTowards(this TileObject tileObject,TileMap tileMap, MyVector2 newPosition, int speed)
    {
        if (newPosition.X <= tileMap.Width && newPosition.Y < tileMap.Height)
        {
         tileObject.transform.Position.MoveTowards(newPosition, speed);
        }
    }
}
