namespace FinalProjectCSharp2;

public class Transform : Component
{
    public MyVector2 Position = new MyVector2(0,0);
    // update with grid
    public Transform(TileObject gameObject) : base(gameObject)
    {

    }

   
}