using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Numerics;
using System.Runtime.Intrinsics;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectCSharp2
{
    public class Vector2Extension 
    {
        /// <summary>
        /// this is a Class called Vector which adding Functionality to defualt Vector2 Struct
        /// CreateVector() Method is used to create a new Vector2 without the need to call the Vector2 Struct (from outside)
        /// Direction (Up,Down,Right,Left) will be used as a shortcut for traversing a vector in 2D space
        /// this class will be used as an extension of the default Vector2 Struct
        /// </summary>
      

         
        public static Vector2 Down = new Vector2(0, -1); 
        public static Vector2 Up = new Vector2(0, 1);
        public static Vector2 Right = new Vector2(1, 0);
        public static Vector2 Left = new Vector2(-1, 0);
        public static Vector2 One = new Vector2(1, 1);
        public static Vector2 Zero = new Vector2(0, 0);

        public float Distance(Vector2 firstVector, Vector2 secondVector)
        {
            float distanceX = firstVector.X - secondVector.X;
            float distanceY = firstVector.Y - secondVector.Y;
            return MathF.Sqrt(distanceX * distanceX + distanceY * distanceY);
        }

 

        public Vector2 CreateVector(int x, int y) /// method to create vector
        {
            Vector2 vector = new Vector2(x, y);
            return vector;
        }

        public static Vector2 MoveTowards(Vector2 current, Vector2 target, float speed)
        {
            float distanceX = target.X - current.X;
            float distanceY = target.Y - current.Y;
          while (current != target)
            {
                Console.WriteLine(current);
           
                if (distanceX > 0)
                {
                    current.X -= speed;
                }
                if (distanceX < 0)
                {
                    current.X += speed;
                }
                if (distanceY > 0)
                {
                    current.Y -= speed;
                }
                if (distanceY < 0)
                {
                    current.Y += speed;
                }
                 distanceX = target.X - current.X;
                 distanceY = target.Y - current.Y;
            }
          return current;
        }


        public string VectorValueAsVector(Vector2 vector)
        {
            return $"({vector.X},{vector.Y})";
        }

    }
}
