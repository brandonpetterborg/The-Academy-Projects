using System;



namespace mathPage32ASP.NET
{
    class Program
    {
        static void Main(string[] args)
        {
            int input;
            Console.WriteLine("Input integer");
            input = Console.Read();
            int product = input * 50;
            Console.WriteLine(product);
            Console.ReadLine();

            int add;
            Console.WriteLine("Input integer");
            add = Console.Read();
            int total = add + 25;
            Console.WriteLine(total);
            Console.ReadLine();

            int div;
            Console.WriteLine("input number");
            div = Console.Read();
            double quotient = div / 12.5;
            Console.WriteLine(quotient);
            Console.ReadLine();

            int TrueOrFalse;
            Console.WriteLine("input number");
            TrueOrFalse = Console.Read();
            bool trueOrFalse = TrueOrFalse > 50;
            Console.Write(trueOrFalse.ToString());
            Console.ReadLine();

            // Takes an input from the user, divides it by 7, 
            //and prints the remainder to the console (tip: think % operator).



        }
    }
}
