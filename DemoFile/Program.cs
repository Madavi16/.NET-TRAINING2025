using System;

namespace DemoFile
{
    internal class SampleProgram
    {
        static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = 10;
            float avg_score = 67.45f;
            double precise_value = 12345.674920479282;
            decimal money_amount = 1234567890.12m;
            char grade = 'A';
            string message = "Hello, welcome to the session";

            Console.WriteLine("Num1 value is : "+num1);
            Console.WriteLine("Num2 value is : {0} ", num2);

            Console.WriteLine($"Average Score = {avg_score} \n Precise value = {precise_value} \n Amount = {money_amount}" );
            Console.Write($"Grade = {grade}\n");
            Console.WriteLine("Message : "+message);
            
            //Console.ReadLine();

        }

    }
}