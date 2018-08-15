using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace textFile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("pick a number.");
            string text = Console.ReadLine();
            File.WriteAllText(@"c:\Users\12088\Documents\log\21.txt", text);
            string text1 = File.ReadAllText(@"c:\Users\12088\Documents\log\21.txt");
            Console.ReadLine();


            Console.WriteLine("pick a whole number.");
            int UI = Convert.ToInt32(Console.ReadLine());
            DateTime currentTime = DateTime.Now;
            DateTime add = currentTime.AddHours(UI);
            Console.WriteLine(string.Format("{0} {1}", currentTime, add));
            Console.ReadLine();
            
        }
    }
}
