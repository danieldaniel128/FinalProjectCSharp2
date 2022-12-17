using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectCSharp2
{
    public class Vector
    {
        public Vector2 vector2;
        private int _x;
        public int x { get => _x; set => _x = value; }
        private int _y;
        public int y { get => _y; set => _y = value; }


        private static Vector2 _down = new Vector2(0, -1);
        public static Vector2 Up = new Vector2(0, 1);
        public static Vector2 Right = new Vector2(1, 0);
        public static Vector2 Left = new Vector2(-1, 0);
        public static Vector2 Down { get => _down; private set => _down = new Vector2(0, -1); }
        //public static Vector Up { get => _up; private set => _up = new Vector(0, 1); }
        //static Vector _right;
        //public static Vector Right { get => _right; private set => _right = new Vector(1, 0); }

        //static Vector _left;
        //public static Vector Left { get => _left; private set => _left = new Vector(0, 1); }

        public Vector Vector2Plus(Vector vec1, Vector vec2)
        {
            Console.WriteLine($"{vec2.x}, {vec2.y}");
            vec1.x += vec2.x;
            vec1.y += vec2.y;
            return vec1;
        }
        public Vector2 CreateVector(int x, int y)
        {
            vector2 = new Vector2(x, y);
            return vector2;
        }
        public override string ToString()
        {
            return $"({x},{y})";
        }
        public Vector (int x, int y)
        {
            this.x = x;
            this.y = y;
            vector2 = new Vector2(x, y);
            
        }
    }
}
