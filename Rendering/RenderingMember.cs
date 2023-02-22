using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectCSharp2
{
    public abstract class RenderingMember
    {

        protected RenderingMediator _renderingMediator;

        public RenderingMember(RenderingMediator mediator)
        {
            _renderingMediator = mediator;
        }

        //public string Name { get; set; }   //presentation member example

        public void ReceiveRenderingAnswer(string answer)
        {
            //Console.ForegroundColor = ConsoleColor.Cyan;
            //Console.WriteLine("{0} received answer.\n'{1}'.", Name, answer);
        }

    }
}
