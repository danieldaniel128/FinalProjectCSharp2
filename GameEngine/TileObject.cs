namespace FinalProjectCSharp2;

public abstract class TileObject :IComparer<TileObject>, ICloneable
{
    public int Actor { get; set; }
    public event Action OnStep;
    public char ObjectChar = 'o';
    public ConsoleColor Color = ConsoleColor.Green;

    public abstract List<Component> Components { get; protected set; }
    public Transform transform { get; set; }



    public TileObject(int actor,char objectChar,ConsoleColor color)
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

    public void MakeStep() 
    {
        OnStep?.Invoke();
    }

    public void AddToStep(Action action) 
    {
        OnStep += action;
    }

    public void RemoveSteps()
    { 
        OnStep = null;
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
            OnStep.Invoke();
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


    public virtual object Clone()
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

}
