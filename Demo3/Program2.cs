using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo3
{
    internal class Program2
    {
        static void Main(string[] args)
        {
            //switch
            Console.WriteLine("Choose the option 1.Add \n2.Sub \n3.Mult \n4.Div");
            int choice = Convert.ToInt32(Console.ReadLine());
            double n1, n2;
            Console.WriteLine("Enter the first num: ");
            n1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the second num: ");
            n2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("The answer is: ");
            switch (choice)
            {
                case 1:

                    Console.WriteLine("Adddition is: " + (n1 + n2));
                    break;

                case 2:

                    Console.WriteLine("Subtraction is: " + (n1 - n2));
                    break;
                case 3:

                    Console.WriteLine("Multiplication is: " + (n1 * n2));
                    break;
                case 4:
                    if (n2 != 0)
                    {
                        Console.WriteLine("Division is : " + (n1 / n2));
                    }
                    else
                    {
                        Console.WriteLine("Error: Division by zero is not allowed");
                    }
                    break;
                default:
                    Console.WriteLine("No solution");
                    break;

            }

            Console.ReadLine();
                

        }
    }
}
