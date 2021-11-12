using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops2
{
    class Program
    {
        static void Main(string[] args)
        {
            //while
            int n =int.Parse( Console.ReadLine());
            int c = 1;
            int toplam = 0;
            while (c<=n)
            {
                toplam += c;
                c++;

            }
            Console.WriteLine(toplam/n);

            char character = 'a';
            while (character<'z')
            {
                Console.WriteLine(character);
                character++;
            }

            string[] cars = { "bmw", "ford", "toyota", "nissan" };
            foreach (var car in cars)
            {
                Console.WriteLine(  car);
            }

        }
    }
}
