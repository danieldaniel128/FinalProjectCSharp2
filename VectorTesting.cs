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

      
        public static void Test()
        {
          var pos = new Vector2(7, 10);
          var pos2 = new Vector2 (3, 5);
          var pos3 =  new Vector2(3, 7);
          pos3 += Vector2.Left;
          
          Vector2 pos4 = new Vector2(5,6);

            //pos += Vector.Down;          //  Console.WriteLine(vector.VectorValueAsVector(pos));
          //  Console.WriteLine(pos.ToString());
          //Console.WriteLine(pos.Equals(pos2));
          //  Console.WriteLine(Vector2.Distance(pos, pos2));
          //  Console.WriteLine(Vector2.Normalize(pos));
         
                pos =Vector2.MoveTowards(pos, pos2, 0.001f);
                Console.WriteLine("Current position: " + pos);
            

        }




    }
}
