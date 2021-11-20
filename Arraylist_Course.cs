using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Arraylist_Course
    {
        static void Main(string[] args)
        {
            ArrayList arr = new ArrayList();
            arr.Add("ayşe");
            arr.Add(2);
            arr.Add(true);
            arr.Add("A");

            Console.WriteLine(arr[1]);

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
            string[] color = { "red", "yellow" };
            List<int> number = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 88 };
            arr.AddRange(color);
            arr.AddRange(number);


            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }

            arr.Sort(); // runtime problem occur because of type of values different

            Console.WriteLine(arr.BinarySearch(8));

            arr.Reverse();
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }

            arr.Clear();
            arr.Reverse();
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
