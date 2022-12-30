using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

    public class Transform : Component
    {
        Vector2 position = new Vector2(0,0);

    public Transform(TileObject to) : base(to)
    {
    }
}
