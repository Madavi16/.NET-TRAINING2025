using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoFile2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string firstname, lastname, gender;
            int age;
            char grade;
            int score1, score2, score3;
            Console.WriteLine("Enter your First Name: ");
            firstname=Console.ReadLine();
            Console.WriteLine("Enter your Last Name: ");
            lastname=Console.ReadLine();
            Console.WriteLine("Enter Gender: ");
            gender=Console.ReadLine();
            Console.WriteLine("Enter Grade: ");
            grade=Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Enter Age: ");
            age=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your 3 scores: ");
            score1=Convert.ToInt32(Console.ReadLine());
            score2=Convert.ToInt32(Console.ReadLine());
            score3=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Student Info \n****************************\n");
            Console.WriteLine($"FirstName = {firstname} \nLastName = {lastname} \nGender = {gender} \nAge = {age}\nGrade = {grade}");
            Console.WriteLine($"Score1 = {score1}\nScore2 = {score2} \nScore3 = {score3}");
            Console.WriteLine("*******************************");
           
            Console.ReadLine();
        }
    }
}
