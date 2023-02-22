using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectCSharp2.Rendering
{
    public class Renderer : RenderingMember
    {
        public Renderer(RenderingMediator mediator) : base(mediator) { }
        public void SendNewRendering(string url)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Presenter changed image URL to '{0}'.", url);
            //_mediator.UpdateImage(url);
        }

        public void ReceiveRenderingQuestion(string question, RenderedObject attendee)
        {
            throw new NotImplementedException();
        }

        public void AnswerRenderingQuestion(string answer, RenderedObject attendee)
        {
            throw new NotImplementedException();
        }



    }
}
