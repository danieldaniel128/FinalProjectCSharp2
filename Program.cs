class Program
{

    public static void Main(string[] args)
    {
        bool isDanielAPeasent = true;


        if (isDanielAPeasent)
            Console.WriteLine("He is an insect");
        else
            Console.WriteLine("nothing, he is still an insect");

        Positions positions = new Positions(5,4);

        Positions positions1 = new Positions(3,4);

        (positions - positions1).ToString();


       

     
    }
}






