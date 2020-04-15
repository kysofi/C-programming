using System;
using static System.Console;
using System.Windows.Forms;

namespace ProgramExercise2
{
    class Program
    {
        static void Main()
        {
            string inValue = "";
            int numberOfItems;
            double charge = 0;
            double totalCharge = 0;

            WriteLine("Please enter the number of items purchased: ");
            inValue = ReadLine();

            while (inValue !="-99") 
            {
                if (int.TryParse(inValue, out numberOfItems) == false)
                {
                    WriteLine("Invalid input");
                }
                    WriteLine("Please enter the number of items purchased: ");
                    inValue = ReadLine();
                    for (int i = 1; i < numberOfItems; i++)
                    {
                        if (i == 1)
                        {
                            charge = 2.99;
                        }
                        else if (i > 1 && i < 6) {
                            charge = 2.99 + ((i - 1) * 1.99);
                        }
                        else if (i > 5 && i < 15)
                        {
                            charge = 2.99+ (1.99 * 4) + ((i - 5) * 1.49);
                        }
                        else if (i > 15)
                        {
                            charge = 2.99 + (1.99 * 4) + (1.49 * 9) + ((i - 14) * 0.99);
                        }
                        totalCharge = totalCharge + charge;
                        WriteLine("The shipping charge for all item(s):{0:C}", totalCharge);
                    }

                inValue = ReadLine();
                
                }
            MessageBox.Show(totalCharge);


            ReadLine();
        }

        }
    }

