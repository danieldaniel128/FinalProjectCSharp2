using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectCSharp2
{
    internal class TileObjectExample : TileObject
    {
       // public event Action OnTouch;
    
        


        public override List<Component> Components { get; protected set; }

        public TileObjectExample(char objectChar, ConsoleColor color) : base(objectChar, color)
        {
        }
    }
}
