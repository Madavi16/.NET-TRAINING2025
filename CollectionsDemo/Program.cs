using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CollectionsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList arraylist = new ArrayList();
            Console.WriteLine("Initial capacity"+arraylist.Capacity);
            arraylist.Add(10);
            Console.WriteLine("Capacity after adding one item:"+arraylist.Capacity);

            arraylist.Add("Test item 1");
            arraylist.Add(true);
            arraylist.Add(15.5);

            Console.WriteLine("Capcity after adding four items " +arraylist.Capacity);

            Console.WriteLine("\n Items in Arraylist is: ");
            foreach(var item in arraylist)
            {
                Console.WriteLine(item);
            }

            //removing elements

            arraylist.Remove(true);
            Console.WriteLine("After remove true arraylist items are: "+arraylist.Capacity);
            foreach(var item in arraylist)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("after removing true capcity"+arraylist.Capacity);
            
            //adding elements
            arraylist.Add("Rishi");
            arraylist.Add("Chiru");
            arraylist.Add("Mahe");

            //inserting elements using insert
            arraylist.Insert(1, "New item at index 1");
            Console.WriteLine("After adding 7 values capacity is"+arraylist.Capacity);
            foreach(var item in arraylist)
            {
                Console.WriteLine(item);
            }
            ArrayList arraylist2 = new ArrayList();
            arraylist2.Add("First item in ararylist2");
            arraylist2.Add("Second item also added to arraylist2");

            //AddRange
            arraylist.AddRange(arraylist2);
            Console.WriteLine("after adding 9 values capacity"+arraylist.Capacity);

            //InsertRange
            ArrayList deptList = new ArrayList() { "IT", "HR", "Admin", "FInance" };
            arraylist.InsertRange(2,deptList);
            Console.WriteLine("After inserted deptlist in the index position 2 in array list"+arraylist.Capacity);
            foreach (var item in arraylist)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("After adding 13 values capacity"+arraylist.Capacity);
            Console.WriteLine($"Hr is there in arraylist or not? {arraylist.Contains("HR")}");
            Console.WriteLine($"Total count: {arraylist.Count}");

            Console.WriteLine($"arraylist[4]: {arraylist[4]}");

            //getrange
            ArrayList arrayList3 = arraylist.GetRange(3, 5);
            Console.WriteLine("Arraylist3 values are: ");
            foreach(var item in arrayList3)
            {
                Console.WriteLine(item);
            }

            //arraylist reverse
            Console.WriteLine("After reverse arraylist3");
            arrayList3.Reverse();
            foreach(var  array in arrayList3)
            {
                Console.WriteLine(array);
            }

            //Console.WriteLine("After reverse arraylist");
            //arraylist.Reverse();
            //foreach (var item in arraylist)
            //{
            //    Console.WriteLine(item);

            ////}

            //RemoveRange

            Console.WriteLine("After removerange (2,2) arraylist3");
            arrayList3.RemoveRange(2, 2);
            foreach(var item in arrayList3)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Arraylist elements before using RemoveAt: "); 
            foreach(var item in arraylist)
            {
                Console.WriteLine(item);
            }
            //RemoveAt
            Console.WriteLine("After RemoveAt(1) ArrayList");
            arraylist.RemoveAt(1);
            foreach( var item in arraylist)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();

        }
    }
}
