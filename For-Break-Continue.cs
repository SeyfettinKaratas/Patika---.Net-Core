using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int c = int.Parse( Console.ReadLine());
            for (int i = 0; i < c; i++)
            {
                if (i%2==1)
                {
                    Console.WriteLine(i);
                }
            }
            

            int x = int.Parse(Console.ReadLine());
            int sumodd = 0;
            int sumeven = 0;
            for (int i = 0; i < x; i++)
            {
                if (i % 2 == 1)
                {
                    sumodd += i;
                }
                else
                {
                    sumeven += i;
                }
            }
            Console.WriteLine(sumeven);
            Console.WriteLine(sumodd);

            //break, continue

            for (int i = 0; i < 10; i++)
            {
                if (i == 4)
                    break;
                Console.WriteLine(i);
            }
            for (int i = 0; i < 10; i++)
            {
                if (i == 4)
                    continue;
                Console.WriteLine(i);
            }


            Console.ReadLine();
        }
    }
}
