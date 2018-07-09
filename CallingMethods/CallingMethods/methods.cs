using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



    public class methods
    {
        public static void AddInput()
        {
            Console.WriteLine("Choose a number.");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(number1 + 2 + " This is your number plus 2.");
            Console.ReadLine();

        }
        public static void MultiplyInput()
        {
            Console.WriteLine("Choose a number.");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(number1 * 2 + " This is your number multiplied by 2");
            Console.ReadLine();
        }
        public static void DivideInput()
        {
            Console.WriteLine("Choose a number.");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(number1 / 2 + " This is your number divided by 2");
            Console.ReadLine();
        }
    }
