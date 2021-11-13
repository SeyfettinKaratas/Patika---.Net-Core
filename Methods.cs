using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsPatika
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 2;
            int b= 3;

            int result = Sum(a, b);
            Console.WriteLine(result);

            Methods example = new Methods();
            example.PrintScreen(result.ToString());

           // int result2= example.IncandSum(a, b);
            //example.PrintScreen(result2.ToString());
            example.PrintScreen((a+b).ToString());


            int result3 = example.IncandSum( ref a, ref b);
            example.PrintScreen(result3.ToString());
            example.PrintScreen((a + b).ToString());

        }
        static int Sum(int n1, int n2)
        {
            return (n1 + n2);
        }
    }

    class Methods
    {
        public void PrintScreen(string var1)
        {
            Console.WriteLine(var1);
        }

        public int IncandSum(ref int n1,ref int n2)
        {
            n1 += 1;
            n2 += 1;
            return n1 + n2;
        }
    }
}
