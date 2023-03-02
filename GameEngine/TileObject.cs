namespace FinalProjectCSharp2;

public abstract class TileObject : IComparer<TileObject>, ICloneable
{
    public int Actor { get; set; }
    public event Action OnStep;
    public char ObjectChar = 'o';
    public ConsoleColor Color = ConsoleColor.Green;

    public abstract List<Component> Components { get; protected set; }
    public Transform transform { get; set; }


    /// <summary>
    /// Creates new TileObject and attaches it to the it's actor
    /// </summary>
    /// <param name="actor"></param>
    /// <param name="objectChar"></param>
    /// <param name="color"></param>
    public TileObject(int actor, char objectChar, ConsoleColor color)
    {
        Actor = actor;
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

    /// <summary>
    /// called every step the tile object is making
    /// </summary>
    public void MakeStep()
    {
        OnStep?.Invoke();
    }
    /// <summary>
    /// Subscribe an action to OnStep Event
    /// </summary>
    /// <param name="action"></param>
    public void AddToStep(Action action)
    {
        OnStep += action;
    }
    /// <summary>
    /// Unsubscribe all subscribers of the OnStep Event
    /// </summary>
    public void RemoveSteps()
    {
        OnStep = null;
    }

    public void AddComponent(Component component)
    {
        Components.Add(component);
    }

    /// <summary>
    /// Compare two TileObjectss by their positions
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>
    public int Compare(TileObject? a, TileObject? b)
    {
        // should compare positions
        if (a.transform.Position == b.transform.Position)
        {
            OnStep.Invoke();
            return 0;
        }
        else
            return -1;
    }

    /// <summary>
    /// Shallow cloning TileObject
    /// </summary>
    /// <returns> return shallow cloned TileObject</returns>
    public virtual object Clone()
    {
        var tileObject = (TileObject)MemberwiseClone();
        tileObject.transform = new Transform(tileObject);
        return tileObject;
    }


}
public static class TileObjectExtensions
{
    /// <summary>
    /// moving a TileObject position to a new position on TilMap grid
    /// </summary>
    /// <param name="tileObject"></param>
    /// <param name="newPosition"></param>
    public static void PutTileObjectOnBoard(this TileObject tileObject, MyVector2 newPosition)
    {
        if (newPosition.X <= TileMap.Instance.Width && newPosition.Y <= TileMap.Instance.Height)
        {
            tileObject.transform.Position = newPosition;

        }
    }

}
