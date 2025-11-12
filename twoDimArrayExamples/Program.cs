using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace twoDimArrayExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //user input for 2D array

            Console.WriteLine("Enter number of rows: ");
            int rows = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter number of columns: ");
            int cols = Convert.ToInt32(Console.ReadLine());

            int[,] arr = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.WriteLine($"Enter element [{i},{j}]: ");
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("\n Matrix2 Elements \n-----------------");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }


                //2d array student marks

                Console.WriteLine("Enter row size: ");
                int rowSize = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter column size: ");
                int colsSize = Convert.ToInt32(Console.ReadLine());

                int[,] studentsMarks = new int[rowSize, colsSize];

                for (int i = 0; i < rowSize; i++)
                {
                    Console.WriteLine($"Enter the marks for Student {i + 1}: ");
                    for (int j = 0; j < colsSize; j++)
                    {
                        Console.WriteLine($"Enter the marks for subject {j + 1}: ");
                        studentsMarks[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }

                Console.WriteLine("Displaying the marks of students: ");

                for (int i = 0; i < rowSize; i++)
                {
                    int total = 0;
                    Console.WriteLine($"\nStudent {i + 1} Marks are \n");
                    for (int j = 0; j < colsSize; j++)
                    {
                        Console.Write(studentsMarks[i, j] + " ");
                        total += studentsMarks[i, j];
                    }
                    Console.WriteLine();
                    Console.WriteLine($"\nTotal mark of Student {i + 1}: {total}");
                }



                Console.ReadLine();

        }
    }
}
