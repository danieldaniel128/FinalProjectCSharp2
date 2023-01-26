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

        static MyVector2 vector = new MyVector2();
        public static void Test()
        {
          var pos = new MyVector2(7, 10);
          var pos2 = new MyVector2(3, 5);
          var pos3 = new MyVector2(3, 7);
            pos3 += MyVector2.Left;
          MyVector2 pos4 = new MyVector2(5,6);

            //pos += Vector.Down;          //  Console.WriteLine(vector.VectorValueAsVector(pos));
          //  Console.WriteLine(pos.ToString());
          //Console.WriteLine(pos.Equals(pos2));
          //  Console.WriteLine(Vector2.Distance(pos, pos2));
          //  Console.WriteLine(Vector2.Normalize(pos));
            while (pos != pos2)
            {
               
             
                pos =MyVector2.MoveTowards(pos, pos2, 1f);
                Console.WriteLine("Current position: " + pos);


            }

        }




    }
}
