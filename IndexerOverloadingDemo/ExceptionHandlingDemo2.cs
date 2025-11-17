using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace IndexerOverloadingDemo
{
    class ExceptionHandlingDemo2
    {
        public static void MethodDivide()
        {
            try
            {
                int x, y, z;
                Console.WriteLine("Enter two numbers: ");
                x = Convert.ToInt32(Console.ReadLine());
                y = Convert.ToInt32(Console.ReadLine());
                z = x / y;
                Console.WriteLine($"Result: {z}");
            }
            catch (DivideByZeroException e)
            {
                throw new Exception($"exception caught in method divide occured while divide by zero {e.Message}\n Source: {e.Source}");
                throw e;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                Console.WriteLine("End of the Program.");
            }
        }


        static void Main(string[] args)
        {
            try
            {
                MethodDivide();
            }
            catch(Exception e)
            {
                Console.WriteLine($"Exception caught in Main: {e.Message}");
            }
            Console.ReadLine();
        }

    }
}