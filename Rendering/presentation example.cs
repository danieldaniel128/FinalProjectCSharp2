using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectCSharp2.Rendering
{
    public abstract class PresentationMember
    {
        protected Mediator _mediator;

        public PresentationMember(Mediator mediator)
        {
            _mediator = mediator;
        }

        public string Name { get; set; }

        public void ReceiveAnswer(string answer)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("{0} received answer.\n'{1}'.", Name, answer);
        }
    }


    public class Presenter : PresentationMember
    {
        public Presenter(Mediator mediator) : base(mediator) { }

        public void SendNewImageUrl(string url)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Presenter changed image URL to '{0}'.", url);
            _mediator.UpdateImage(url);
        }

        public void ReceiveQuestion(string question, Attendee attendee)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Presenter received question from {0}.\n'{1}'"
                , attendee.Name, question);
        }

        public void AnswerQuestion(string answer, Attendee attendee)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Presenter answered question for {0}.\n'{1}'"
                , attendee.Name, answer);
            _mediator.SendAnswer(answer, attendee);
        }
    }


    public class Attendee : PresentationMember
    {
        public Attendee(Mediator mediator) : base(mediator) { }

        public void AskQuestion(string question)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("{0} asked question.\n'{1}'", Name, question);
            _mediator.SendQuestion(question, this);
        }

        public void ReceiveImage(string url)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Image for {0} updated to '{1}'.", Name, url);
        }
    }


    public class Mediator
    {
        public Presenter Presenter { get; set; }

        public List<Attendee> Attendees { get; set; }

        public void UpdateImage(string url)
        {
            foreach (Attendee attendee in Attendees)
            {
                attendee.ReceiveImage(url);
            }
        }

        public void SendAnswer(string answer, Attendee attendee)
        {
            attendee.ReceiveAnswer(answer);
        }

        public void SendQuestion(string question, Attendee attendee)
        {
            Presenter.ReceiveQuestion(question, attendee);
        }
    }
}
