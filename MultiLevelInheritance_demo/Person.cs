using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MultiLevelInheritance_demo
{
        internal class Person
        {
       
            public Person()
            {
                Console.WriteLine("\nPerson Constructor called");
            }

            public string Name;
            public void ShowName() => Console.WriteLine($"Name: {Name}");

        }

        class Teacher : Person
        {
            public Teacher()
            {
                Console.WriteLine("\nTeacher Constructor");
            }
            public string Course;
            public void ShowCourse() => Console.WriteLine($"{Name} teaches {Course}");
        }

        class Professor : Teacher
        {
            public Professor()
            {
                Console.WriteLine("\nProfessor Constructor");
            }
            public void ConductResearch() => Console.WriteLine($"{Name} is conducting R&D in {Course}");

        }
    
    
}
