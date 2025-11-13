using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutDiscard
{
    internal class ParamExample
    {
        static int x;
        int y;

        void NonStaticMethod()
        {
            Console.WriteLine("Non static function");
        }
        static void StaticMethod()
        {
            Console.WriteLine("Static Function");
        }
        static void Main(string[] args)
        {
            Console.WriteLine(SumofInteger(10,20));
            Console.WriteLine(SumofInteger(34,56,67));
            Console.WriteLine(SumofInteger(78,78,50,34,24));
            Console.WriteLine(SumofInteger());
    
            Sum(45, 78, 56);
            Sum(89, 76, 90, 99, 45);
            Sum();

            ParamExample obj=new ParamExample();
            //params with others (non-static function)
            Console.WriteLine("\n===== Student Details =====");
            obj.DisplayDetails("Ravi", 90, 90, 89, 72, 40);
            obj.DisplayDetails("Madhavi", 89, 78, 91, 76, 82);
            obj.DisplayDetails("Rishikesh", 73, 77, 65, 92, 54, 71);

            x = 900;
            obj.y = 200;

            StaticMethod();
            obj.NonStaticMethod();

            Console.WriteLine($"Static variable accessing without object: {x}");
            Console.WriteLine($"Non static variable accessing with object: {obj.y}");
            Console.ReadLine();
        }

        //static function dont need object to call
        static int SumofInteger(params int[] nums)
        {
            int sum = 0;
            foreach(int num in nums)
            {
                sum += num;
            }
            return sum;
        }
        static void Sum(params int[] nums)
        {
            int total = 0;
            foreach (var n in nums)
            {
                total += n;
                
            }
            Console.WriteLine($"Sum: {total}");
        }

        //params with other parameter
        //non static function needs object to call
         void DisplayDetails(string name, params int[] marks)
        {
            
            Console.WriteLine($"\nStudent name: {name}");
            Console.WriteLine($"Marks: {string.Join(",",marks)}");
            Console.WriteLine($"Average: {marks.Average()}");
           
        }
    }
}
