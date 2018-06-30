using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace booleanASPpage37
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            int age = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Have you ever had a DUI?");
            string DUI = Console.ReadLine();
            Console.WriteLine("How many speeding tickets do you have?");
            int tickets = Int32.Parse(Console.ReadLine());
          
           //if(age > 15 && DUI == "no" && tickets <= 3)
           // {
           //     Console.WriteLine("Qualified");
           // }
           //else
           // {
           //     Console.WriteLine("Not qualified");
           // }
           // Console.ReadLine();
        }
    }
}
