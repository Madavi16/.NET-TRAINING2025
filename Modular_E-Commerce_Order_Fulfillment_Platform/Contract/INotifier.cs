using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modular_E_Commerce_Order_Fulfillment_Platform
{
    public interface INotifier
    {
        void Notify(string message);
    }
    public class EmailNotifier:INotifier
    {
        public void Notify(string message)
        {
            Console.WriteLine($"[EMAIL]: {message}");
        }
    }
    public class SMSNotifier:INotifier
    {
        public void Notify(string message)
        {
            Console.WriteLine($"[SMS]: {message}");
        }
    }
}
