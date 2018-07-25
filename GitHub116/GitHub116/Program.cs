using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHub116
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input number");
            int userInput = Convert.ToInt32(Console.ReadLine());
            Divide math1 = new Divide();
            math1.Math(userInput);
        }

       
    }
}
