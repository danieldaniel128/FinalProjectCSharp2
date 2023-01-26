using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Numerics;
using System.Runtime.Intrinsics;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace FinalProjectCSharp2
{
    public readonly struct MyVector2 : IPositioning
    {
        /// <summary>
        /// this is a Class called Vector which adding Functionality to defualt Vector2 Struct
        /// CreateVector() Method is used to create a new Vector2 without the need to call the Vector2 Struct (from outside)
        /// Direction (Up,Down,Right,Left) will be used as a shortcut for traversing a vector in 2D space
        /// this class will be used as an extension of the default Vector2 Struct
        /// </summary>

        // fields
        private readonly float _x;
        private readonly float _y;
       
        // Vector2 Properties
        public readonly float Magnitude => MathF.Sqrt(_x * _x + _y * _y); // return a Vector2's Magnitude aka the Length of the Vector2
        public readonly MyVector2 Normalized => new MyVector2(_x / this.Magnitude, _y / this.Magnitude); // returns a Normalized Vector2 (which is vector with values between -1 and 1)

       public float X { get => _x; set => throw new NotImplementedException(); }
       public float Y { get => _y; set => throw new NotImplementedException(); }

        public static MyVector2 Down = new MyVector2(0, -1);
        public static MyVector2 Up = new MyVector2(0, 1);
        public static MyVector2 Right = new MyVector2(1, 0);
        public static MyVector2 Left = new MyVector2(-1, 0);
        public static MyVector2 One = new MyVector2(1, 1);
        public static MyVector2 Zero = new MyVector2(0, 0);



        public MyVector2(float x, float y)
        {
            this._x = x;
            this._y = y;
        }

        // Operators
        public static MyVector2 operator +(MyVector2 pos1, MyVector2 pos2)
        {
            return new MyVector2(pos1._x + pos2._x, pos1._y + pos2._y);
        }
        public static MyVector2 operator -(MyVector2 pos1, MyVector2 pos2)
        {
            return new MyVector2(pos1._x - pos2._x, pos1._y - pos2._y);
        }
        public static MyVector2 operator /(MyVector2 pos1, MyVector2 pos2)
        {
            return new MyVector2(pos1._x / pos2._x, pos1._y / pos2._y);
        }
        public static bool operator ==(MyVector2 pos1, MyVector2 pos2)
        {
            if (pos1._x == pos2._x && pos1._y == pos2._y)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public MyVector2 Normalize() => new MyVector2(_x / this.Magnitude, _y / this.Magnitude);
        public static bool operator !=(MyVector2 pos1, MyVector2 pos2)
        {
            if (pos1._x != pos2._x && pos1._y != pos2._y)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static MyVector2 operator *(MyVector2 pos1, MyVector2 pos2)
        {
            return new MyVector2(pos1._x * pos2._x, pos1._y * pos2._y);
        }




        // Vector2 Methods
        public static float Dot(MyVector2 vec1, MyVector2 vec2) // returns Dot product of 2 vectors
        {
            return vec1._x * vec2._x + vec1._y * vec2._y;
        }
        public float Distance(MyVector2 firstVector, MyVector2 secondVector)
        {
            float distanceX = firstVector._x - secondVector._x;
            float distanceY = firstVector._y - secondVector._y;
            return MathF.Sqrt(distanceX * distanceX + distanceY * distanceY);
        }
        public static MyVector2 MoveTowards(MyVector2 current, MyVector2 target, float speed)
        {
            while (!current.Equals(target))
            {

                float distance = current.Distance(current, target);
                Console.WriteLine("Current position: " + current);
                Console.WriteLine("Distance: " + distance);

                if (current._x < target._x) current = new MyVector2(Math.Min(current._x + speed, target._x), current._y);
                else current = new MyVector2(Math.Max(current._x - speed, target._x), current._y);

                if (current._y < target._y) current = new MyVector2(current._x, Math.Min(current._y + speed, target._y));
                else current = new MyVector2(current._x, Math.Max(current._y - speed, target._y));

                Thread.Sleep(16); // PlaceHolder For Now
            }
            return current;
        }

        public static MyVector2 Lerp(MyVector2 current, MyVector2 target, float percentage)
        {

            return new MyVector2(current._x + (target._x - current._x) * percentage,
                current._y + (target._y - current._y) * percentage);

        }

        public override string ToString() => $"({_x},{_y})";
        public override bool Equals(object obj)
        {
            if (!(obj is MyVector2))
            {
                return false;
            }
            else
            {
                MyVector2 vector = (MyVector2)obj;

                if (vector.GetHashCode() == GetHashCode())
                {
                    return true;
                }

            }

            return false;
        }
        public override int GetHashCode()
        {
            return ((int)_x * 100) + ((int)_y * 50);
        }
    }
}
