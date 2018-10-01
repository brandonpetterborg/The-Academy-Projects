using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            //for (int i = 1; i < 101; i++)
            //{

            //    if (i % 3 == 0)
            //    {
            //        Console.WriteLine("fizz");
            //    }
            //    else if (i % 5 == 0)
            //    {
            //        Console.WriteLine("buzz");
            //    }
            //    else
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            //    Console.ReadLine();
            //    List<int> oddList = new List<int>();
            //    for (int i = 0; i <= 100; i++)
            //    {
            //        if (IsOdd(i))
            //        {
            //            Console.WriteLine(i);
            //            oddList.Add(i);


            //        }

            //    }
            //    Console.ReadLine();

            //}
            //public static bool IsOdd(int value)
            //{
            //    return value % 2 != 0;
            //for (int i = 1; i < 101; i++)
            //{
            //    if (i % 3 == 0)
            //    {
            //        Console.WriteLine("fizz");
            //    }
            //    else if (i % 5 == 0)
            //    {
            //        Console.WriteLine("buzz");
            //    }
            //    else
            //    {
            //        Console.WriteLine(i);
            //    }
            //    Console.ReadLine();

            List<string> names = new List<string>()
            {
                "Derek",
                "Brandon",
                "Skyler"
            };
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();
         }
        
        
        

        
        

        
    }
}
