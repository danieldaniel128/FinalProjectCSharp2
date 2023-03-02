namespace FinalProjectCSharp2;

/// <summary>
/// A class to return the transform of the object
/// </summary>
public class Transform : Component
{
    public MyVector2 Position = new MyVector2(0,0);
    public Transform(TileObject gameObject) : base(gameObject)
    {
        gameObject.Components[0] = this;
    }


}