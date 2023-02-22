using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FinalProjectCSharp2.Rendering
{
    public class RenderedObject : RenderingMember
    {
        public RenderedObject(RenderingMediator mediator) : base(mediator)
        {
        }

        public void AskRenderingQuestion(string question)
        {
        }

        internal void ReceiveRenderingAnswer(string answer)
        {
            throw new NotImplementedException();
        }
    }
}
