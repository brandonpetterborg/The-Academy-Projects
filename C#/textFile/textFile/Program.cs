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
        }
    }
}
