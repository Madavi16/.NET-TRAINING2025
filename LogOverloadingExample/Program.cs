using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogOverloadingExample
{
    class Logger
    {
        public void Log(string message)
        {
            Console.WriteLine($"[LOG] : {message}");
        }
        public void Log( string message, int level)
        {
            string levelText;
            switch(level)
            {
                case 1:
                    levelText = "INFO";
                    break;
                case 2:
                    levelText = "WARNING";
                    break;
                case 3:
                    levelText = "ERROR";
                    break;
                default:
                    levelText = "UNKNOWN";
                    break;
            }
            Console.WriteLine($"[{levelText}] {message}");
        }
        public void Log(string message, DateTime time)
        {
            Console.WriteLine($"[{time}] {message}");
        }
        public void Log(string message, int level, DateTime time)
        {
            string levelText;
            switch (level)
            {
                case 1:
                    levelText = "INFO";
                    break;
                case 2:
                    levelText = "WARNING";
                    break;
                case 3:
                    levelText = "ERROR";
                    break;
                default:
                    levelText = "UNKNOWN";
                    break;
            }
            Console.WriteLine($"[{time}] [{levelText}] {message}");

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Logger logger = new Logger();
            Console.WriteLine("Enter a message: ");
            string message = Console.ReadLine();
            Console.WriteLine("Enter the level: ");
            int level = Convert.ToInt32(Console.ReadLine());    
            Console.WriteLine("\n========== Log Method Overloading Example ==========\n");
            logger.Log("System started successfully");
            logger.Log(message, level);
            logger.Log("User Login Detected", DateTime.Now);
            logger.Log(message, level, DateTime.Now);
            Console.ReadLine();


        }
    }
}
