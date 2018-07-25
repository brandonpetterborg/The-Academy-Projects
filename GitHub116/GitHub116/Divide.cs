using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHub116
{
    public class Divide
    {
        public void Math(int number1)
        {
            Console.WriteLine(number1 / 2);
            Console.ReadLine();

        }

        public void Math(float number1)
        {
            Console.WriteLine(number1 / 2);
            Console.ReadLine();

        }


        public void outArgExample( out int number)
        {
            number = 10;
        }
    }
}
