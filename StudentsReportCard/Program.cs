using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsReportCard
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"\n====== Students Mark Evaluation System =====");
            Console.WriteLine("Enter number of Students: ");
            int n=Convert.ToInt32( Console.ReadLine() );

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\nEnter details for Student #{i+1}");
                Student student = new Student();
                Console.Write("Enter Student Name: ");
                student.name= Console.ReadLine();

                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"Enter marks for Subject {j+1}: ");
                    student.subjectMarks[j]=Convert.ToInt32( Console.ReadLine() );
                }

                student.CalculateResult(out int total, out double average, out string grade);
                student.DisplayDetails(total, average, grade);
            }
            Console.WriteLine("\nPress Enter to exit...");
            Console.ReadLine();
         

        }
    }
}
