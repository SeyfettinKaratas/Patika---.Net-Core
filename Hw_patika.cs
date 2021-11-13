using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Patika
{
    class Hw_patika
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a positive number : ");
            int n1=Convert.ToInt32( Console.ReadLine());
            //Q1 -------------------------------------------------------------
            int[] ar = new int[n1];
            for (int i = 0; i < n1; i++)
            {
                Console.WriteLine("Please enter a positive number : ");
                ar[i]= Convert.ToInt32(Console.ReadLine());
                if (ar[i]%2==0)
                {
                    Console.WriteLine(ar[i]);
                }
            }
            Console.ReadKey();
            //-----------------------------------------------------------------

            //Q2 --------------------------------------------------------------
            Console.WriteLine("Please enter a positive number : ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter a positive number : ");
            int m = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Please enter a positive number : ");
                ar[i] = Convert.ToInt32(Console.ReadLine());
                if (ar[i] % m == 0 || arr[i]==m)
                {
                    Console.WriteLine(ar[i]);
                }
            }
            Console.ReadKey();
            //-----------------------------------------------------------------

            //Q3 --------------------------------------------------------------

            Console.WriteLine("Please enter a positive number : ");
            int n2 = Convert.ToInt32(Console.ReadLine());


            string[] ary = new string[n2];
            for (int i=n2; i >0 ; i--)
            {
                Console.WriteLine("Please enter a string value : ");
                ary [i] = Console.ReadLine();                
            }
            for (int i = 0; i < n2; i++)
            {
                Console.WriteLine(ary[i]);
            }

                Console.ReadKey();

            //-----------------------------------------------------------------

            //Q4 --------------------------------------------------------------

            Console.WriteLine("Please enter a sentence : ");
            string value = Console.ReadLine();
            int countLetter = value.Length;

            string[] words = value.Split(' ');
            int wordsCount = words.Length;
            Console.WriteLine(wordsCount);

        }
    }
}
