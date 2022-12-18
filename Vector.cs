using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Numerics;
using System.Runtime.Intrinsics;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectCSharp2
{
    public struct Vector
    {
        public Vector2 vector2;
        private int _x;
        public int x { get => _x; set => _x = value; }
        private int _y;
        public int y { get => _y; set => _y = value; }


        public static Vector2 Down = new Vector2(0, -1); 
        public static Vector2 Up = new Vector2(0, 1);
        public static Vector2 Right = new Vector2(1, 0);
        public static Vector2 Left = new Vector2(-1, 0);
        public static Vector2 One = new Vector2(1, 1);
        public static Vector2 Zero = new Vector2(0, 0);

        public Vector2 CreateVector(int x, int y)
        {
            vector2 = new Vector2(x, y);
            return vector2;
        }
        public override string ToString()
        {
            return $"({x},{y})";
        }

    }
}
