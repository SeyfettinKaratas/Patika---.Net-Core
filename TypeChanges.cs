using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class TypeChanges
    {
        static void TypeChange()
        {
            //implicit convert
            byte a = 5;
            byte b = 10;
            short c = 10;
            int d = (a+b+c);
            Console.WriteLine(d);

            long h = d;
            Console.WriteLine("h:"+h);

            float i = h;
            Console.WriteLine("i:" + i);

            string e = "seyfo";
            char f = 'k';
            object g = e + f + d;
            Console.WriteLine("g:"+g);


            //emplicit convert

            int x = 4;
            byte y = (byte)x;
            Console.WriteLine("y:"+y);

            float w = 10.3f;
            byte v = (byte)w;
            Console.WriteLine("v:"+v);

            //ToString

            int xx = 6;
            string yy = xx.ToString();
            Console.WriteLine("yy:"+yy);

            string zz = 12.5f.ToString();
            Console.WriteLine("zz:" +zz);

            //System.Convert

            string s1 = "10";
            string s2 = "20";
            int sayi1, sayi2, toplam;
            sayi1 = Convert.ToInt32(s1);
            sayi2 = Convert.ToInt32(s2);
            toplam = sayi1 + sayi2;
            Console.WriteLine("Toplam:"+toplam);

            //Parse

            ParseMethod();

        }

        public static void ParseMethod()
        {
            string metin1 = "10";
            string metin2 = "10.25";
            int rakam1;
            double rakam2;
            rakam1 = Int32.Parse(metin1);
            rakam2 = double.Parse(metin2);
            Console.WriteLine("rakam1:"+rakam1);
            Console.WriteLine("rakam2:" + rakam2);
        }

    }
}
