using FinalProjectCSharp2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Collider : Component
{
    public float Radius;

    public Collider(Rigidbody rb, GameObject go, float radius = 3) : base(go)
    {
        Radius = radius;
        rb.AssignCollider(this);
    }

    public void OnCollision(Collider other)
    {
        Console.WriteLine("I'm walking here.");
    }
}

