using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ArraysMethods
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**************************");
            //sort
            int[] sayi = { 23,12,4,86,72,3,11,17};
            foreach (var n in sayi)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("**************************");
            Array.Sort(sayi);
           
            foreach (var n in sayi)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("**************************");
            //clear sıfır değeri atar
            Array.Clear(sayi, 2, 2);

            foreach (var n in sayi)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("**************************");
            //reverse

            Array.Reverse(sayi);
            foreach (var n in sayi)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("**************************");
            //indexof
            int x=Array.IndexOf(sayi, 23);
            Console.WriteLine(x);
            Console.WriteLine("**************************");
            //resize
            Array.Resize<int>( ref sayi,9);
            sayi[8] = 99;
            foreach (var n in sayi)
            {
                Console.WriteLine(n);
            }

        }
    }
}
