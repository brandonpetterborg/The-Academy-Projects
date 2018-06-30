using System;


namespace consoleAppMain
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");
            Console.WriteLine("What course are you on?");
            string course = Console.ReadLine();
            Console.WriteLine("What page number are you on?");
            int pageNumber = Console.Read();
            Console.WriteLine("Do you need help with anything? Please answer \"True\" or \"False\"");
            bool answer = Convert.ToBoolean(Console.ReadLine());
            if (answer ==true) { Console.WriteLine("please provide specifics"); };
            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            
            string positiveExperiences = Console.ReadLine();
            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific");
            string feeedback = Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");
            int hours = Console.Read();
            Console.WriteLine("Thank you for your answers. An instructor will respond to this shortly. Have a great day!");
            Console.Read();



        }
    }
}