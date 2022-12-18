using FinalProjectCSharp2;
using System.Numerics;


namespace FinalProjectCSharp2
{
class Program 
{


     
    public static void Main(string[] args)
    {
           
     
        bool isDanielAPeasent = true;

        if (isDanielAPeasent)
            Console.WriteLine("He is an insect");
        else
            Console.WriteLine("nothing, he is still an insect");

        Positions positions = new Positions(10,5);
        Positions positions1 = new Positions(5,4);

        Console.WriteLine(positions + positions1);


        

       


        

    }
}

}






