using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsPatika
{
    class RecursiveMethods
    {
        static void Main(string[] args)
        {
            int result = 1;
            for (int i = 0; i < 5; i++)
            {
                result = result * 3;

            }

            Func f = new Func();
            Console.WriteLine(f.Expo(3,4));

            //extension methods

            string val = "a b c";

            bool result2 = val.CheckSpaces();
            Console.WriteLine(result2);
            if (result2)
            {
                Console.WriteLine(val.RemoveWhiteSpaces());
                
            }
            Console.WriteLine(val.MakeUpperCase());
            Console.WriteLine(val.MakeLowerCase());

            int[] ary = { 9, 3, 6, 2, 1, 5, 8 };

            ary.SortArray();
            ary.Printt();

            int number = 5;
            Console.WriteLine(number.IsEvenNumber());

            Console.WriteLine(val.GetFirstChar());
        }

        
    }

    public class Func
    {
        public int Expo(int n1,int n2)
        {
            if (n2<n1)
            {
                return n1;
            }
            return Expo(n1, n2 - 1) * n1;
        }

       
    }
    public static class Extension
    {
        public static bool CheckSpaces(this string param)
        {
            return param.Contains(" ");
        }
        public static string RemoveWhiteSpaces(this string param)
        {
            string[] arr = param.Split(" ");
            return string.Join("", arr);
        }
        public static string MakeUpperCase(this string param)
        {
            return param.ToUpper();
        }
        public static string MakeLowerCase(this string param)
        {
            return param.ToLower();
        }
        public static int SortArray(this int[] param)
        {
            Array.Sort(param);
            return param;
        }
        public static void Printt(this int[] param)
        {
            foreach (var item in param)
            {
                Console.WriteLine(item);
            }
        }
        public static bool IsEvenNumber(this int param)
        {
            return param % 2 == 0;
        }
        public static string GetFirstChar(this string param)
        {
            return param.Substring(0, 1);
        }

    }
}
