using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shipingQuoteASPPage41
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("Enter package weight.");
            int packageWeight = Int32.Parse(Console.ReadLine());
            if (packageWeight > 50) //checking package weight 
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
                return;
            }
         
            Console.WriteLine("Enter package width");
            int packageWidth = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter package height");
            int packageHeight = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter package length");
            int packageLength = Int32.Parse(Console.ReadLine());
            
            if (packageWidth + packageHeight + packageLength > 50) //checking to see if W+H+L > 50
            {
                Console.WriteLine("Package too big to be shipped via Package Express");
                Console.ReadLine();
                return;
            }
            int quote = ((packageWeight * packageWidth * packageLength * packageHeight) / 100);
            Console.WriteLine("Your estimated total for shipping this package is $"+ quote +". Thank you.");
            Console.ReadLine();
        }
    }
}
