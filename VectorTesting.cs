﻿using System;
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
          var pos = new MyVector2(0, 0);
          var pos2 = new MyVector2 (20,-20);
          var pos3 =  new MyVector2(0, 8);
            var pos6 = new MyVector2(8, 8);
            var pos5 = pos3 * pos6;
            var pos7 = pos3 + new MyVector2(1, 0);
            
            pos3 = pos3.Normalize();
//<<<<<<< Updated upstream
                Console.WriteLine($"Vector2Normal is: {pos3} ");
          pos3 += MyVector2.Left;
//=======
//>>>>>>> Stashed changes
          


         


            pos.MoveTowards( pos2, 0.5f);
            Console.WriteLine($"pos:{pos} arrived to pos2:{pos2} ");



        }




    }
}
