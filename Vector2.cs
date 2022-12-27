﻿using System;
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
    public readonly struct Vector2 : IPositioning
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
        float IPositioning.X { readonly get => _x; set => throw new NotImplementedException(); }
   
        float IPositioning.Y { readonly get => _y; set => throw new NotImplementedException(); }
    
        // Vector2 Properties
        public readonly float Magnitude => MathF.Sqrt(_x * _x + _y * _y); // return a Vector2's Magnitude aka the Length of the Vector2
        public readonly Vector2 Normalized => new Vector2(_x / this.Magnitude, _y / this.Magnitude); // returns a Normalized Vector2 (which is vector with values between -1 and 1)
        public static Vector2 Down = new Vector2(0, -1);
        public static Vector2 Up = new Vector2(0, 1);
        public static Vector2 Right = new Vector2(1, 0);
        public static Vector2 Left = new Vector2(-1, 0);
        public static Vector2 One = new Vector2(1, 1);
        public static Vector2 Zero = new Vector2(0, 0);
      
        public Vector2(float x, float y)
        {
            this._x = x;
            this._y = y;
        }

        // Operators
        public static Vector2 operator +(Vector2 pos1, Vector2 pos2)
        {
            return new Vector2(pos1._x + pos2._x, pos1._y + pos2._y);
        }
        public static Vector2 operator -(Vector2 pos1, Vector2 pos2)
        {
            return new Vector2(pos1._x - pos2._x, pos1._y - pos2._y);
        }
        public static Vector2 operator / (Vector2 pos1, Vector2 pos2)
        {
            return new Vector2(pos1._x / pos2._x, pos1._y / pos2._y);
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




        // Vector2 Methods
        public static float Dot(Vector2 vec1, Vector2 vec2) // returns Dot product of 2 vectors
        {
            return vec1._x * vec2._x + vec1._y * vec2._y; 
        }
        public float Distance(Vector2 firstVector, Vector2 secondVector)
        {
            float distanceX = firstVector._x - secondVector._x;
            float distanceY = firstVector._y - secondVector._y;      
            return MathF.Sqrt(distanceX * distanceX + distanceY * distanceY); 
        }
        public static Vector2 MoveTowards(Vector2 current, Vector2 target, float speed)
        {
            while (!current.Equals(target))
            { 
              
                float distance = current.Distance(current, target);
                Console.WriteLine("Current position: " + current);
                Console.WriteLine("Distance: " + distance);
  
                if (current._x < target._x) current = new Vector2(Math.Min(current._x + speed, target._x), current._y);
                else current = new Vector2(Math.Max(current._x - speed, target._x), current._y);
         
                if (current._y < target._y) current = new Vector2(current._x, Math.Min(current._y + speed, target._y));
                else current = new Vector2(current._x, Math.Max(current._y - speed, target._y));

                Thread.Sleep(16); // PlaceHolder For Now
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