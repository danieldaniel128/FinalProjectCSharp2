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

        static Vector vector = new Vector();
        public static void Test()
        {
          var pos = vector.CreateVector(3, 5);
          var pos2 = vector.CreateVector(3, 5);
          //pos += Vector.Down;
          Console.WriteLine(pos.ToString());
          Console.WriteLine(pos.Equals(pos2));

        }




    }
}
