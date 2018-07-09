using System;
using System.Collections.Generic;


namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //LIST!!
            //List<int> intList = new List<int>();
            //intList.Add(4);
            //intList.Add(10);
            //Console.WriteLine("Select index");
            //int index = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(intList[index]);
            //Console.ReadLine();
            //END LIST!!
            //List<string> stringList = new List<string>();
            //stringList.Add("A");
            //stringList.Add("B");
            //Console.WriteLine("Select index");
            //int index = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(stringList[index]);
            //Console.ReadLine();

            //PAGE 52
            //1.
            List<string> stringList = new List<string> { "red", "blue", "green", "orange", "purple", "gold", "maroon", "black", "white", "yellow", "red", "blue" };
            Console.WriteLine("Select text to search for");
            string userInput = Console.ReadLine();
          
            for (int i = 0; i < stringList.Count; i++)
            {
                if (stringList[i] == userInput)
                {
                    Console.WriteLine(i);

                }
            }
            Console.ReadLine();

            //.2
            //for (int i = 0; i - 1 < i++; i++)
            //{
            //    Console.WriteLine("oh dear");
            //}

            //4.
            //string[] stringArray = { "red", "blue", "green", "orange" };
            //Console.WriteLine("input text");
            //string userInput = Console.ReadLine();

            //for (int i = 0; i <= 3; i++)
            //{
            //    Console.WriteLine(stringArray[i] + " " + userInput);
            //}
            //Console.ReadLine();

            //5

            //ARRAY!!
            //int[] numArray = new int[5];
            //numArray[0] = 5;
            //numArray[1] = 2;
            //numArray[2] = 10;
            //numArray[3] = 200;
            //numArray[4] = 5000;

            //int[] numArray1 = new int[] { 5, 2, 10, 200, 5000 };

            //string[] stringArray = { "brandon", "Petterborg", };
            //Console.WriteLine("Select index from array");

            //    try
            //    {
            //        int index = Convert.ToInt32(Console.ReadLine());
            //        Console.WriteLine(stringArray[index]);
            //        Console.ReadLine();

            //    }
            //    catch
            //    {
            //        Console.WriteLine("Index number does not exist.");

            //    }
            //    Console.ReadLine();

            //int[] numArray = { 5, 2, 10, 200, 5000 };
            //Console.WriteLine("Select index from array");
            //int index = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(numArray[index]);
            //Console.ReadLine();
            //END ARRAY!!


        }
    }
}
