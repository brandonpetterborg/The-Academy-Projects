using System;
using System.Collections.Generic;


namespace iteration
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] testScores = { 98, 99, 85, 70, 82, 34, 91, 90, 94 };

            //for (int i = 0; i < testScores.Length; i++)
            //{
            //    if (testScores[i] > 85)
            //    {
            //        Console.WriteLine("Passing test score: " + testScores[i]);
            //    }
            //}
            //Console.ReadLine();

            //List<int> testScores = new List<int>();
            //testScores.Add(98);
            //testScores.Add(99);
            //testScores.Add(81);
            //testScores.Add(72);
            //testScores.Add(70);

            //foreach (int score in testScores)
            //{
            //    if (score > 85)
            //    {
            //        Console.WriteLine("Passing test score: " + score);
            //    }
            //}
            //Console.ReadLine();
            //List<int> intList = new List<int>
            //{
            //    4,
            //    10,
            //    21,
            //    19,
            //    6,
            //    13,
            //    28,
            //    24
            //};
            //Console.WriteLine(intList);
            //Console.Read();
            try
            { 
            Console.WriteLine("Pick a number");
            int userInput = Convert.ToInt32(Console.ReadLine());
            List<int> intList = new List<int>();
            intList.Add(4);
            intList.Add(10);
           
                foreach (int item in intList)
                {
                    Console.WriteLine(item / userInput);
                }
                Console.ReadLine();
            }
            catch (FormatException ex)
            {
                Console.WriteLine("please enter a whole number");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Cannot divide by 0.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            finally
            {
                Console.ReadLine();
            }
                //Console.WriteLine("Select index");
            //int index = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(intList[index]);
            //Console.ReadLine();
        }
    }
}
