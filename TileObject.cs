namespace FinalProjectCSharp2;

public abstract class TileObject : IUpdate, IComparer<TileObject>, ICloneable
{
    public event Action OnTouch; 

    public abstract List<Component> Components { get; protected set; }
    public virtual Transform transform => Components[0] as Transform;


    public TileObject()
    {
        Components = new List<Component>();
        Components.Add(new Transform(this));
    }

    public void Update(float deltaTime)
    {
        foreach (var component in Components)
        {
            component.Update(deltaTime);
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
            OnTouch.Invoke();
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
        return tileObject;
    }
}
public static class TileObjectExtensions
{
    public static void Teleport(this TileObject tileObject,UpgradedTileMap tileMap, MyVector2 newPosition)
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
    public static void MoveTowards(this TileObject tileObject,UpgradedTileMap tileMap, MyVector2 newPosition, int speed)
    {
        if (newPosition.X <= tileMap.Width && newPosition.Y < tileMap.Height)
        {
         tileObject.transform.Position.MoveTowards(newPosition, speed);
        }
    }
}
