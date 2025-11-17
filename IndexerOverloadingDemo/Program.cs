using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerOverloadingDemo
{
    public class
        EmployeeDirectory
    {
        private string[] EmpNames = { "Anas", "Bhoomi", "Ranjith", "Indu" };
        private int[] EmpIDs = { 101, 102, 103, 104 };

        public string this[int index]
        {
            get { return EmpNames[index]; }
            set { EmpNames[index] = value; }
        }
        public string this[string Empid]
        {
            get
            {
                for (int i = 0; i < EmpIDs.Length; i++)
                {
                    if (EmpIDs[i].ToString() == Empid)
                        return EmpNames[i];
                }
                return "Employee Not Found";
            }

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
                EmployeeDirectory empDirectory = new EmployeeDirectory();
                Console.WriteLine($"Empolyee[2]: {empDirectory[1]}");
                Console.WriteLine($"Empolyee[4]: {empDirectory[4]}");
                Console.WriteLine($"Employee[3]: {empDirectory["103"]}");
                Console.WriteLine($"Employee[4]: {empDirectory["105"]}");
                Console.ReadLine();

            Console.WriteLine();
        }
    }
}
