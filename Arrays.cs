using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops2
{
    class Arrays
    {
        static void Main(string[] args)
        {
            string[] colors = new string[5];
            string[] animals = { "cat", "dog", "bird", "monkey" };

            int[] a ;
            a = new int[5];
            colors[0] = "blue";
            a[3] = 10;
            Console.WriteLine(animals[1]);
            Console.WriteLine(i[3]);
            Console.WriteLine(colors[0]);

            Console.WriteLine("Lütfen dizinin eleman sayısını giriniz");
            int arraylenght = int.Parse(Console.ReadLine());
            int[] numberArray = new int[arraylenght];

            for (int i = 0; i < arraylenght; i++)
            {
                Console.Write("Lüfen {0}. sayısı giriniz: ",i+1);
                numberArray[i]= int.Parse(Console.ReadLine());
            }
            int sum = 0;
            foreach (var number in numberArray)
            {
                sum += number;
            }
            Console.WriteLine(sum/arraylenght);
        }
    }
}
