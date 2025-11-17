using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] jagArray = new int[5][];

            jagArray[0] = new int[5] {3,4,5,6,7};
            jagArray[1] = new int[7] { 8, 9, 10, 11, 12, 23,24 };
            jagArray[2] = new int[3] {25,26,27} ;
            jagArray[3] = new int[4] { 50, 34, 56, 67 };
            jagArray[4] = new int[2] { 66, 16 };

            Console.WriteLine("Displaying Jagged Array: ");
            for(int i=0;i<jagArray.Length;i++)
            {
                for(int j=0;j<jagArray[i].Length;j++)
                {
                    System.Console.Write(jagArray[i][j] + " ");
                }
                System.Console.WriteLine();
            }

            //student marks example

            Console.WriteLine("\n Example of Jagged array with user input\n------------------------------------------");
            Console.WriteLine("Enter number of students: ");
            int students=Convert.ToInt32(Console.ReadLine());

            int[][] marks=new int[students][];

            for(int i=0;i<students;i++)
            {
                Console.WriteLine($"\nEnter number of subjects for student {i + 1}: ");
                int subjects=Convert.ToInt32(Console.ReadLine());

                marks[i]=new int[subjects];

                for(int j=0;j<subjects;j++)
                {
                    Console.WriteLine($"Enter marks for subject {j+1}:");
                    marks[i][j]=Convert.ToInt32(Console.ReadLine());
                }
            }
            int highest = 0;
            int topperIndex = 0;
            Console.WriteLine("\nDisplaying marks of students: ");
            for (int i = 0; i < students; i++)
            {
                Console.Write($"\nStudents {i + 1}: ");
                int total = 0;
                for (int j = 0; j < marks[i].Length; j++)
                {
                    Console.Write(marks[i][j] + " ");
                    total += marks[i][j];
                }
                Console.WriteLine();
                Console.WriteLine($"Total mark of Student {i + 1}: {total}");

                if (highest < total)
                {
                    highest = total;
                    topperIndex = i;
                }
            }
            Console.WriteLine($"\nStudent {topperIndex + 1} has got the highest marks = {highest}.");
            Console.ReadLine();

        }
    }
}
