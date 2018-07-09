using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



    public class methods
    {
        public static int AddInput(int number1)
        {
         
            Console.WriteLine(number1 + 2);
            int output = Convert.ToInt32(Console.Read());
            Console.ReadLine();
            return output;

        }
        public static int MultiplyInput(int number1)
        {
        Console.WriteLine(number1 * 2);
        int output = Convert.ToInt32(Console.Read());
        Console.ReadLine();
        return output;
    }
        public static int DivideInput(int number1)
        {
        Console.WriteLine(number1 / 2);
        int output = Convert.ToInt32(Console.Read());
        Console.ReadLine();
        return output;
    }
    }
