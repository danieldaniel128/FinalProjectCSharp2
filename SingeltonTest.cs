using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectCSharp2
{
    public class SingeltonTest : Singelton<SingeltonTest>
    {
        public int x;
    }
}
