namespace FinalProjectCSharp2;

class Collider : Component
{
    public float Radius;

    public Collider(Rigidbody rigidbody, TileObject gameObject, float radius = 3) : base(gameObject)
    {
        Radius = radius;
        rigidbody.AssignCollider(this);
    }

    public void OnCollision(Collider other)
    {
        Console.WriteLine("I'm walking here.");
    }
}