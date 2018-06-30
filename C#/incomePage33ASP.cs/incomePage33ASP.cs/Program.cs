using System;


namespace incomePage33ASP.cs
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Anonymous Income Comparison Program");
           
            Console.WriteLine("Person 1");
            Console.WriteLine("hourly Rate?");
            float hourlyRate = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Hours worked per week?");
            float hoursWeek = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Annual salary of Person 1:");
            Console.WriteLine(hourlyRate * hoursWeek * 52);
         


            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate");
            float hourlyRate2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Hours worked per week?");
            float hoursWeek2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Annual salary of Person 2:");
            Console.WriteLine(hourlyRate2 * hoursWeek2 * 52);
            Console.WriteLine("Does person 1 make more than person 2?");

            if (hourlyRate + hoursWeek > hourlyRate2 + hoursWeek2)
            {
                Console.WriteLine("True");
            }
            else Console.WriteLine("false");
            Console.ReadLine();
        }
    }
}
