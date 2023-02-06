using System;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectCSharp2
{
    public class UpdateTest : Component
    {
        int counter = 0;
        public UpdateTest(TileObject gameObject) : base(gameObject)
        {
          

        }

        public override void Update()
        {
            Console.WriteLine(counter++);
         
        }


    }


}
