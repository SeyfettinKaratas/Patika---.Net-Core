using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class Operators
    {
        static void Main(string[] args)
        {
            int x = 3;
            int y = 3;
            y = y + 2;
            y += 2;
            y /= 2;

            // || && !
            bool a = true;
            bool b = false;
            if (a && b)
            {
                Console.WriteLine("Perfect");
            }
            if (a || b)
            {
                Console.WriteLine("Perfect");
            }
            if (a && !b)
            {
                Console.WriteLine("Perfect");
            }

            int c = 3;
            int d = 4;

            bool e = c < d;
            Console.WriteLine(e);
            e = c <= d;
            Console.WriteLine(e);
            e = c > d;
            Console.WriteLine(e);
            e = c >= d;
            Console.WriteLine(e);
            e = c == d;
            Console.WriteLine(e);
            e = c != d;
            Console.WriteLine(e);


            int n1 = 10;
            int n2 = 5;
            int n3 = n1 / n2;
            n3= n1 % 2;




        }
    }
}
