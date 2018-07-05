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

            List<int> testScores = new List<int>();
            testScores.Add(98);
            testScores.Add(99);
            testScores.Add(81);
            testScores.Add(72);
            testScores.Add(70);

            foreach (int score in testScores)
            {
                if (score > 85)
                {
                    Console.WriteLine("Passing test score: " + score);
                }
            }
            Console.ReadLine();
        }
    }
}
