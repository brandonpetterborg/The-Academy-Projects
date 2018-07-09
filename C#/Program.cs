using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose a number. We will add 2, multiply by 2, then divide by 2");
            int number1 = Convert.ToInt32(Console.ReadLine());
            //int number1 = Convert.ToInt32(Console.ReadLine());


            methods.AddInput(number1);
            methods.MultiplyInput(number1);
            methods.DivideInput(number1);
                
        }
    }
}
