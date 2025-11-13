using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DarrayExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //array 
            int[] numArr = new int[5] { 10, 20, 30, 40, 50 };
            foreach (int num in numArr)
            {
                Console.WriteLine(num);
            }
            int n;
            Console.WriteLine("Enter number of elements for myArr: ");
            n = Convert.ToInt32(Console.ReadLine());
            int[] myArr = new int[n];
            //myArr[0] = 100;
            //myArr[1] = 120;
            //myArr[2] = 130;
            //myArr[3] = 140;
            //myArr[4] = 150;

            Console.WriteLine($"ENter {myArr.Length} numbers: ");

            for (int i = 0; i < n; i++)
            {
                myArr[i] = Convert.ToInt32(Console.ReadLine());

            }

            Console.WriteLine("\n Array Elememnts are \n -------------------");

            foreach (var item in myArr)
            {
                Console.WriteLine(item);
            }

            //2d array

            int[,] arr1 = new int[2, 5] { { 35, 73, 86, 90, 45 }, { 65, 72, 81, 93, 66 } };

            Console.WriteLine("\n The 2d array elements are\n ------------------");
            for (int i = 0; i < arr1.GetLength(0); i++)
            {
                for (int j = 0; j < arr1.GetLength(1); j++)
                {
                    Console.Write(arr1[i, j] + " ");
                }
                Console.WriteLine();
            }


            //two dimensional array or matrix

            int[,] matrix = new int[2, 3];

            Console.WriteLine($"row length: {matrix.GetLength(0)}");
            Console.WriteLine($"column length: {matrix.GetLength(1)}");

            Console.WriteLine("Enter elements for 2*3 matrix: ");

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine($"Enter element [{i},{j}]: ");
                    matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("\n Matrix elements are \n----------------");

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
