using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Numerics;
using System.Runtime.Intrinsics;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace FinalProjectCSharp2
{
    public readonly struct Vector2 : IPositioning
    {
        /// <summary>
        /// this is a Class called Vector which adding Functionality to defualt Vector2 Struct
        /// CreateVector() Method is used to create a new Vector2 without the need to call the Vector2 Struct (from outside)
        /// Direction (Up,Down,Right,Left) will be used as a shortcut for traversing a vector in 2D space
        /// this class will be used as an extension of the default Vector2 Struct
        /// </summary>

        readonly float _x;
        readonly float _y;

        public float Magnitude => MathF.Sqrt(_x * _x + _y * _y);
        float IPositioning.X { readonly get => _x; set => throw new NotImplementedException(); }
        float IPositioning.Y { readonly get => _y; set => throw new NotImplementedException(); }

        public Vector2(float x, float y)
        {
            this._x = x;
            this._y = y;
        }

        public static Vector2 operator +(Vector2 pos1, Vector2 pos2)
        {
            return new Vector2(pos1._x + pos2._x, pos1._y + pos2._y);
        }


        public static Vector2 operator -(Vector2 pos1, Vector2 pos2)
        {
            return new Vector2(pos1._x - pos2._x, pos1._y - pos2._y);
        }
        public static bool operator == (Vector2 pos1, Vector2 pos2)
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
        public static bool operator !=(Vector2 pos1, Vector2 pos2)
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
        public static Vector2 operator * (Vector2 pos1, Vector2 pos2)
        {
            return new Vector2(pos1._x * pos2._x, pos1._y * pos2._y);
        }

        public static Vector2 Down = new Vector2(0, -1);
        public static Vector2 Up = new Vector2(0, 1);
        public static Vector2 Right = new Vector2(1, 0);
        public static Vector2 Left = new Vector2(-1, 0);
        public static Vector2 One = new Vector2(1, 1);
        public static Vector2 Zero = new Vector2(0, 0);


        public float Distance(Vector2 firstVector, Vector2 secondVector)
        {
            float distanceX = firstVector._x - secondVector._x;
            float distanceY = firstVector._y - secondVector._y;
            return MathF.Sqrt(distanceX * distanceX + distanceY * distanceY);
        }

 

        public static Vector2 MoveTowards(Vector2 current, Vector2 target, float speed)
        {
            
            float currentX = current._x;
            float currentY = current._y;
            float targetX = target._x;
            float targetY = target._y;

            Vector2 distance = target - current;

            float distanceX = target._x - current._x;
            float distanceY = target._y - current._y;

            current = new Vector2(currentX, currentY);

            target = new Vector2(targetX, targetY);

            while (current != target)
            {
                if (currentX < targetX)
                {
                    currentX += speed;
                }
                else
                {
                    currentX -= speed;
                }

                if (currentY < targetY)
                {
                    currentY += speed;
                }
                else
                {
                    currentY -= speed;
                }
                Vector2 newVec = new Vector2(currentX, currentY);
                Console.WriteLine(newVec);
            }
            return current;





        }



        public override string ToString() => $"({_x},{_y})";


        public override bool Equals(object obj)
        {
            if (!(obj is Vector2))
            {
                return false;
            }
            else
            {
                Vector2 vector = (Vector2)obj;

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
