using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CollectionsDemo
{
    public class Restaurant
    {
        public int OrderID { get; set; }
        public string CustomerName { get; set; }
        public decimal TotalAmount { get; set; }

    }
    internal class FoodifyApp
    {
        static void Main(string[] args)
        {
            Restaurant restaurant= new Restaurant();

            ArrayList menu = new ArrayList()
            {
                new Restaurant{OrderID=101,CustomerName="Maheshwari",TotalAmount=750},
                new Restaurant{OrderID=102,CustomerName="Rishikesh",TotalAmount=1300},
                new Restaurant{OrderID=103,CustomerName="Sowmiya",TotalAmount=890},
                new Restaurant{OrderID=104,CustomerName="Bharathh",TotalAmount=2100},
                new Restaurant{OrderID=105,CustomerName="Ravi",TotalAmount=550}
            };

            while(true)
            {
                Console.WriteLine("\nAvailable Services are: ");
                Console.WriteLine("1. Adding New Order Details");
                Console.WriteLine("2. Display all Order details");
                Console.WriteLine("3. Search Order by OrderID");
                Console.WriteLine("4. Remover Order by OrderID");
                Console.WriteLine("5. Total number of Orders");
                Console.WriteLine("6. Sort Orders by Amount");
                Console.WriteLine("7. Reversing the Order List");
                Console.WriteLine("8. Exit");

                Console.WriteLine("Enter your choice of service: ");
                int choice=Convert.ToInt32(Console.ReadLine());

                switch(choice)
                {
                    case 1:
                        Console.WriteLine("\nEnter new order details with Order ID, CustomerName and Amount: ");
                        restaurant.OrderID = Convert.ToInt32(Console.ReadLine());
                        restaurant.CustomerName = Console.ReadLine();
                        restaurant.TotalAmount= Convert.ToInt32(Console.ReadLine());
                        menu.Add(restaurant);
                        break;
                    case 2:
                        Console.WriteLine("\nDisplaying Order Details: ");
                        foreach(Restaurant res in menu)
                        {
                            Console.WriteLine($"Order ID: {res.OrderID}\nCustomer Name: {res.CustomerName}\nTotal Amount: {res.TotalAmount}");
                          
                        }
                        break;
                    case 3:
                        Console.WriteLine("\nEnter Order Id to search: ");
                        int searchId=Convert.ToInt32(Console.ReadLine());
                        Restaurant foundId = null;
                        foreach(Restaurant res in menu)
                        {
                            if(res.OrderID==searchId)
                            {
                                foundId= res;
                                break;

                            }
                        }
                        if(foundId != null)
                        {
                            Console.WriteLine($"Order ID: {foundId.OrderID}\nCustomer Name: {foundId.CustomerName}\nTotal Amount; {foundId.TotalAmount}");
                        }
                        else
                        {
                            Console.WriteLine("Order not found!");
                        }
                        break;
                    case 4:
                        Console.WriteLine("\nEnter Order Id to remove: ");
                        int removeID=Convert.ToInt32(Console.ReadLine());
                        Restaurant IdToRemove = null;
                        foreach(Restaurant res in menu)
                        {
                            if(res.OrderID == removeID)
                            {
                                IdToRemove = res;
                                break;
                            }
                        }
                        if(IdToRemove != null)
                        {
                            menu.Remove(IdToRemove);
                            Console.WriteLine("Order removed successfully");
                        }
                        else
                        {
                            Console.WriteLine("Order not found");
                        }
                        break;

                    case 5:
                        Console.WriteLine($"\nTotal Orders: {menu.Count}");
                        break;
                    case 6:
                        Console.WriteLine("\nSorting order by amount: ");
                        if(menu.Count==0)
                        {
                            Console.WriteLine("No orders to Sort!");
                            break;
                        }
                        menu.Sort(new OrderComparer());
                        Console.WriteLine("Orders Sorted by amount Successfully");
                        foreach(Restaurant res in menu)
                        {
                            Console.WriteLine($"Order ID: {res.OrderID}\nCustomer Name: {res.CustomerName}\nTotal Amount: {res.TotalAmount}");
                        }
                        break;

                    case 7:
                        menu.Reverse();
                        Console.WriteLine("Order List after Reversing: ");
                        foreach (Restaurant res in menu)
                        {
                            Console.WriteLine($"Order ID: {res.OrderID}\nCustomer Name: {res.CustomerName}\nTotal Amount: {res.TotalAmount}");
                        }
                        break;
                    case 8:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid Entry!");
                        break;


                }
                Console.ReadLine();
            }
            

        }

        public class OrderComparer:IComparer
        {
            public int Compare(object x, object y)
            {
                return ((Restaurant)x).TotalAmount.CompareTo(((Restaurant)y).TotalAmount);
            }
        }

    }
}
