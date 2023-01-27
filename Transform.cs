using FinalProjectCSharp2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

public class Transform : Component
{
    public MyVector2 Position;

    public Transform(TileObject go) : base(go)
    {
    }
}
