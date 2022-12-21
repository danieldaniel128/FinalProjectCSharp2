using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows;


namespace FinalProjectCSharp2
{


    public  class VectorTesting
    {

        static Vector2Extension vector = new Vector2Extension();
        public static void Test()
        {
          var pos = vector.CreateVector(7, 10);
          var pos2 = vector.CreateVector(3, 5);
          var pos3 = vector.CreateVector(3, 7);
            pos3 += Vector2Extension.Left;
          Vector2 pos4 = new Vector2(5,6);

            //pos += Vector.Down;          //  Console.WriteLine(vector.VectorValueAsVector(pos));
          //  Console.WriteLine(pos.ToString());
          //Console.WriteLine(pos.Equals(pos2));
          //  Console.WriteLine(Vector2.Distance(pos, pos2));
          //  Console.WriteLine(Vector2.Normalize(pos));
            while (pos != pos2)
            {
               
             
                pos =Vector2Extension.MoveTowards(pos, pos2, 0.001f);
                Console.WriteLine("Current position: " + pos);


            }

        }




    }
}
