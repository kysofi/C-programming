using System;
using static System.Console;

namespace PE3
{
    class Program
    { 
      public static double CalculateTheAverage(int[] score, int minScore, int maxScore, int counter)
        {
            int total = 0;
            for (int i = 0; i < score.Length; i++)
            {
                total += score[i];
            }
            int without = maxScore + minScore;
            total -= without;
            return (double)total/(counter - 2); // without highest and lowest number
        }

        static void Main()
        {
            double avg;
            string inValue;
            int counter = 0;
            int[] score = new int[10];
            int min = 100, max = 0;
            int i = 0;
            WriteLine("Please enter homework {0} score [0 to 100] (-99 to exit): ", i + 1);
            inValue = ReadLine();
            // while the score is not equal to (-99 to exit)
            while (inValue != "-99") 
            {
                if (int.TryParse(inValue, out score[i]) == false)
                    WriteLine("Invalid data entered. Please try again");

                if (min > score[i]) { min = score[i]; }
                if (max < score[i]) { max = score[i]; }
                ++i;
                ++counter;
                WriteLine("Please enter homework {0} score [0 to 100] (-99 to exit): ", i + 1);
                inValue = ReadLine();

            }
            avg = CalculateTheAverage(score, min, max, counter);
            WriteLine();
            WriteLine("Homework App");
            WriteLine("Highest score: {0}", max);
            WriteLine("Lowest score: {0}", min);
            WriteLine("Average score, excluding the lowest and highest scores is: ", avg);
            ReadKey();
        }
    }
}