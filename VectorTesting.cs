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
          var pos = new Vector2(0, 0);
          var pos2 = new Vector2 (20,-9.3f);
          var pos3 =  new Vector2(3, 7);
          pos3 += Vector2.Left;
          
          Vector2 pos4 = new Vector2(5,6);

         
               
                Vector2.MoveTowards(pos, pos2, 0.5f);
            Console.WriteLine($"pos:{pos} arrived to pos2:{pos2} ");



        }




    }
}
