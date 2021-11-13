using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsPatika
{
    class MethodsOverloading
    {
        static void Main(string[] args)
        {
            string n = "999";

            bool result = int.TryParse(n, out int outN);
            if (result)
            {
                Console.WriteLine("Function is successful!");
                Console.WriteLine(outN);
            }
            else
            {
                Console.WriteLine("Function is not successful!");
            }

            Method m = new Method();
            m.Sum(4, 5, out int sumResult);
            Console.WriteLine(sumResult);


            ///////

            int value = 999;
            m.PrintScreen(value);
            m.PrintScreen("a", " b");
            

        }




    }

    class Method
    {
        public void Sum(int a, int b,out int sum)
        {
            sum = a + b;
        }
        public void PrintScreen(string val)
        {
            Console.WriteLine(val);
        }
        public void PrintScreen(int val)
        {
            Console.WriteLine(val);
        }
        public void PrintScreen(string val, string val2)
        {
            Console.WriteLine(val+val2);
        }
    }
}
