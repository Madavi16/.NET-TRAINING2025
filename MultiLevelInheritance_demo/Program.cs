using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MultiLevelInheritance_demo
{
    
    internal class Program
    {
        static void Main(string[] args)
        {

            Professor professor = new Professor();
            Professor professor1 = new Professor() { Name = "Chiru", Course = "CSE" };
            Console.WriteLine("\nEnter Name: ");
            professor.Name = Console.ReadLine();
            Console.WriteLine("\nEnter course: ");
            professor.Course=Console.ReadLine();
            professor.ShowName();
            professor.ShowCourse();
            professor.ConductResearch();
            Console.WriteLine();
            professor1.ShowName();
            professor1.ShowCourse();
            professor1.ConductResearch();
            Console.ReadLine();
        }
    }
}
