using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerOverloadingDemo
{
    internal class ExceptionHandling
    {

        static void Main(string[] args)
        {
            try
            {
                int x, y, z;
                Console.WriteLine("Enter two numbers: ");
                x = Convert.ToInt32(Console.ReadLine());
                y = Convert.ToInt32(Console.ReadLine());
                z = x / y;
                Console.WriteLine($"Result : {z}");
            }
            catch(DivideByZeroException e1)
            {
                throw new Exception($"exception occured while divide by 0 {e1.Message}\n Source: {e1.Source}");
            }
            catch(Exception e1)
            {
                throw new Exception(e1.Message);

            }
            finally
            {
                Console.WriteLine("End of the program.");
            }
            Console.ReadLine();
        }
    }
}
