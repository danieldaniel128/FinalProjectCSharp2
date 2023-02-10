namespace FinalProjectCSharp2;

class Rigidbody : Component
{
    public const float EarthGravity = -9.8f;
    public float Gravity = -9.8f;

    //MyVector2 Velocity = new MyVector2();
    IPositioning position = new MyVector2();
    Collider _collider;
    public Collider Collider => _collider;

    public Rigidbody(TileObject go) : base(go)
    {
        Physics.Instance.Add(this);
    }

    public void AssignCollider(Collider collider)
    {
        _collider = collider;
    }

    public override void Update()
    {
       GravityHandler();
    }

    public void GravityHandler()
    {
        MyVector2 displacement = new(position.X, position.Y + (int)Gravity * 5);
        gameobject.transform.Position = new MyVector2
            (gameobject.transform.Position.X + displacement.X, gameobject.transform.Position.Y + displacement.Y);
    }
}