using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsReportCard
{
    internal class Student
    {
        public string name;
        public int[] subjectMarks = new int[3];

        public void CalculateResult(out int total, out double average, out string grade)
        {
            total = 0;
            for (int i = 0; i < subjectMarks.Length; i++)
            {
                total += subjectMarks[i];
            }
            average = total / subjectMarks.Length;

            if (average >= 90)
                grade = "A+";
            else if (average >= 80)
                grade = "A";
            else if (average >= 70)
                grade = "B+";
            else if (average >= 60)
                grade = "B";
            else if (average >= 50)
                grade = "C";
            else if (average >= 40)
                grade = "E";
            else
                grade = "Fail";
        }

        public void DisplayDetails(int total, double average, string grade)
        {
            Console.WriteLine("\nStudent Report\n--------------------------------");
            Console.WriteLine($"Name: {name}\nTotal Marks: {total}\nAverage: {average}\nGrade: {grade}");
        }
    }
}
