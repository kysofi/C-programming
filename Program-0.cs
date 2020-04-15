using System;
using static System.Console;
namespace TipAmount
{
    class Program
    {
        static void Main(string[] args)
        {
            string inValue;
            string inValue2;
            double totalCharges;
            double tipAmount_15;
            double tipAmount_20;
            double taxAmount;
            double taxAmount2;
            double totalSum;
            double totalSum2;


            WriteLine("Please enter the total charges for the food purchases:");
            WriteLine();
            inValue = ReadLine();
            if (double.TryParse(inValue, out totalCharges))
            {
            WriteLine("Total Before Taxes and Tip: " + totalCharges);
            }
            ReadKey();

            WriteLine("Please enter a tip percentage that you want to pay. It can be 15% or 20%:");
            WriteLine();
            inValue2 = ReadLine();

            // If you want a 15% tip
            if (inValue2 == "15%")
            {
                if (double.TryParse(inValue2, out tipAmount_15))

                {
                    WriteLine();
                    taxAmount = totalCharges * 0.09;
                    WriteLine("Tax (9%): " + taxAmount);

                    tipAmount_15 = totalCharges * 0.15;
                    WriteLine("Tip (15%)" + tipAmount_15);

                    totalSum = totalCharges + taxAmount + tipAmount_15;
                    WriteLine("Total Including Taxes with  15 % Tip:" + totalSum);
                }
            }
            // If you want a 20% tip
            else
            {
                taxAmount2 = totalCharges * 0.09;
                WriteLine("Tax (9%): " + taxAmount2);

                tipAmount_20 = totalCharges * 0.2;
                WriteLine("Tip (20%)" + tipAmount_20);

                totalSum2 = totalCharges + taxAmount2 + tipAmount_20;
                WriteLine("Total Including Taxes with  20 % Tip:" + totalSum2);
                ReadKey();
            }
        }
    }
}
