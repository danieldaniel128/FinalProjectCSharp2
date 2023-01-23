using FinalProjectCSharp2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Rigidbody : Component
{
    public const float EarthGravity = -9.8f;
    public float Gravity = -9.8f;

    //MyVector2 Velocity = new MyVector2();
    IPositioning positioning = new MyVector2();
    Collider _collider;
    public Collider Collider => _collider;

    public Rigidbody(GameObject go) : base(go)
    {
        Physics.Instance.Add(this);
    }

    public void AssignCollider(Collider collider)
    {
        _collider = collider;
    }

    public override void Update(float deltaTime)
    {
        MyVector2 displacement = new MyVector2(positioning.X, positioning.Y + Gravity * deltaTime);
        gameobject.transform.Position = new MyVector2
            (gameobject.transform.Position + displacement.x, gameobject.transform.Position.y + displacement.y);
    }
}
