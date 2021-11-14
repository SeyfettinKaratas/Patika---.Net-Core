using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string value = "dersimiz csharp, hoşgeldiniz";
            string value1 = "dersimiz csharp";
            //length
            Console.WriteLine(value.Length);
            //toupper tolower
            Console.WriteLine( value.ToUpper());
            Console.WriteLine(value.ToLower());
            //concat
            Console.WriteLine(string.Concat(value,"merhaba"));
            //compare compare to //compare de küçük büyük harf duyarlılığı var
            Console.WriteLine(value.CompareTo(value1));
            Console.WriteLine(string.Compare(value,value1,true));
            Console.WriteLine(string.Compare(value, value1, false));
            //contains
            Console.WriteLine(value.Contains(value1));
            Console.WriteLine(value.EndsWith("hoşgeldiniz"));
            Console.WriteLine(value.StartsWith("merhaba"));
            //indexof
            Console.WriteLine(value.IndexOf("cs"));
            Console.WriteLine(value.IndexOf("csss"));
            Console.WriteLine(value.LastIndexOf("i"));
            //ınsert
            Console.WriteLine(value.Insert(0,"merhaba"));
            //padleft padright
            Console.WriteLine(value+value1.PadLeft(30));//sonuna 30a tamamlayana dek boşluk ekle
            Console.WriteLine(value + value1.PadLeft(30,'*'));
            Console.WriteLine(value.PadRight(50)+value1);
            Console.WriteLine(value.PadRight(50,'-') + value1);
            //remove
            Console.WriteLine(value.Remove(10));
            Console.WriteLine(value.Remove(5,3));
            Console.WriteLine(value.Remove(0,1));
            //replace
            Console.WriteLine(value.Replace("csharp","c#"));
            Console.WriteLine(value.Replace(" ", "*"));
            //split
            Console.WriteLine(value.Split(' ')[1]);
            //substring
            Console.WriteLine(value.Substring(4));
            Console.WriteLine(value.Substring(4,6));
        }
    }
}
