using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionHW
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**********************************************************************");



            List<int> primeNumbers = new List<int>();
            List<int> non_primeNumbers = new List<int>();

            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("Please enter a number : ");
                string number = Console.ReadLine();
                int newNumber;
                if (Int32.TryParse(number, out newNumber))
                {
                    if (newNumber < 0)
                    {
                        Console.WriteLine("Error!");
                    }
                    else
                    {
                        int count = 0;                       
                        int j = 2;
                        while (i < newNumber)
                        {
                            if (newNumber % j == 0)
                                count++;
                            j++;
                        }

                        if (count != 0)
                        {
                            non_primeNumbers.Add(newNumber);
                        }
                            
                        else
                        {
                            primeNumbers.Add(newNumber);
                        }
                    }
                }
                else
                    Console.WriteLine("Error!");
            }
            int sumPrimeNumbers = 0;
            int sumNonPrimeNumbers = 0;
            primeNumbers.Sort();
            foreach (var item in primeNumbers)
            {
                Console.WriteLine(item);
                sumPrimeNumbers += item;
            }
            non_primeNumbers.Sort();
            foreach (var item in non_primeNumbers)
            {
                Console.WriteLine(item);
                sumNonPrimeNumbers += item;
            }
            Console.WriteLine((sumPrimeNumbers/primeNumbers.Count).ToString());
            Console.WriteLine((sumNonPrimeNumbers / non_primeNumbers.Count).ToString());


            Console.WriteLine("**********************************************************************");

            int[] numbers = new int[20];

            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("Enter a number please : ");
                int n =Convert.ToInt32( Console.ReadLine());
                numbers[i] = n;
            }

            Array.Sort(numbers);
            int sum = 0;
            for (int i = 0; i < 3; i++)
            {
                sum += numbers[i];
            }
            int summax = 0;
            for (int i = numbers.Length-3 ; i < numbers.Length; i++)
            {
                summax += numbers[i];
            }

            Console.WriteLine(sum.ToString());
            Console.WriteLine(summax.ToString());
            Console.WriteLine((sum/3).ToString());
            Console.WriteLine((summax/3).ToString());
            Console.WriteLine((sum+summax).ToString());


            Console.WriteLine("**********************************************************************");


            List<string> letters = new List<string>();
            Console.Write("Enter a sentence : ");
            string sentence = Console.ReadLine();        
            char[] vowel = { 'a', 'e', 'o', 'ö', 'u', 'ü', 'ı', 'i'  };
            foreach (char c in sentence)
            {
                foreach (char letter in vowel)
                {
                    if (c == letter)
                    {
                        letters.Add(c.ToString());
                    }
                }
            }

            letters.Sort();


            Console.ReadKey();
        }
    }
}
