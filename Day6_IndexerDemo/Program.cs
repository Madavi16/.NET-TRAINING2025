using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_IndexerDemo
{
    class StudentMarks
    {
        private int[] marks = new int[5];
        public int this[int index] //indexer
        {
            get
            {
                if(index<0 || index>=marks.Length)
                {
                    Console.WriteLine("Invalid index, returning -1");
                    return -1;
                }
                return marks[index];
            }
            set
            {
                if (index < 0 || index >= marks.Length)
                {
                    Console.WriteLine("Invalid index! cannot set value.");
                }
                else
                {
                    marks[index] = value;
                }
            }
        }
        public void DisplayMarks()
        {
            Console.WriteLine($"\n--------- Student Marks ---------\n");
            for (int i = 0; i < marks.Length; i++)
            {
                Console.WriteLine($"SUbject {i + 1}: {marks[i]}");
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            StudentMarks studentMarks = new StudentMarks();
            studentMarks[0] = 85;
            studentMarks[1] = 90;
            studentMarks[2] = 78;
            studentMarks[3] = 89;
            studentMarks[4] = 93;

            studentMarks[5] = 66;//will shows validation msg from if-else in get and set


            //getting marks using indexer 
            for(int i=0;i<5;i++)
            {
                Console.WriteLine($"Mark of Student {i+1}: {studentMarks[i]}");
            }
            Console.WriteLine($"\n Mark in subject 1: {studentMarks[0]}");
            Console.WriteLine($"\n Mark in subject 5: {studentMarks[4]}");

            //attempting to get and invalid index
            Console.WriteLine($"Mark of Student 6: {studentMarks[5]}");
            //displays all marks
            studentMarks.DisplayMarks();


            EmployeeList_IndexerDemo employee = new EmployeeList_IndexerDemo();
            Console.WriteLine($"employee[1] : {employee[1]}");
            Console.WriteLine($"employee[2] : {employee[2]}");
            
            //employee[2] = "Madhavi";
            Console.WriteLine($"employee[3] : {employee[3]}");

            Console.WriteLine($"Employee[1]: {employee["Jana"]}");
            Console.WriteLine($"Employee[2]: {employee["Mahe"]}");
           //employee[3] = "M";
            Console.WriteLine($"Employee[3]: {employee["Chiru"]}");

            Console.ReadLine();


        }
    }
}
