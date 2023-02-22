using FinalProjectCSharp2.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectCSharp2
{
    public class RenderingMediator
    {
        public Renderer Renderer { get; set; }

        public List<RenderedObject> RenderedObjects { get; set; }

        public void UpdateRendering(string url)
        {
            foreach (RenderingMember renderedObject in RenderedObjects)
            {
                renderedObject.ReceiveRenderingAnswer(url);//replace url to something of rendering
            }
        }

        public void SendRenderingAnswer(string answer, RenderedObject renderedObject)
        {
            renderedObject.ReceiveRenderingAnswer(answer);
        }

        public void SendRenderingQuestion(string question, RenderedObject renderedObject)
        {
            Renderer.ReceiveRenderingQuestion(question, renderedObject);
        }


    }
}
