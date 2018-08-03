using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHub133
{
    class Program
    {
        static void Main(string[] args)
        {
            Days days = new Days();
            DaysOfWeek day = DaysOfWeek.Friday;

            Console.WriteLine("Enter the day of the week.");
            string userInput = Console.ReadLine();
            if (userInput == Convert.ToString(day)) 
            {

                Console.WriteLine("Today is " + userInput);
            }
            Console.ReadLine();
        }

        public enum DaysOfWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
    }
}
