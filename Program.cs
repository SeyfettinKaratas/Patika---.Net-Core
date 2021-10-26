using System;

namespace Patika___.Net_Core
{
    class Program
    {
        static void Main(string[] args)
        {
            int değer=2;
            Console.WriteLine(değer);
            //string str=string.empty boş string oluşturur..
            byte b=2;
            sbyte b1=2;

            short s=2;
            ushort s1=2;

            Int16 i16=2;
            int i=2;
            Int32 i32=2;
            Int64 i64=2;

            uint ui=2;
            long l=2;
            ulong ul=2;

            float f=2;
            double d=2;
            decimal d1=2;

            char c='s';
            string str="s";

            bool a=true;
            bool b2=false;

            DateTime dt= DateTime.Now;
            Console.WriteLine(dt);
             
            object o1="x";
            object o2='x';
            object o3=4;
            object o4=4.3;

            string str1=string.Empty;
            str1="seyfo";
            string ad="seyfo";
            string soyad="kara";
            string tamisim=ad+" "+soyad;

            int i1=2;
            int i2=4;
            int i3=i1*i2;

            bool t1=10<2;

            string str20="20";
            int i20=20;
            string str2020=str20+i20.ToString();

            System.Console.WriteLine(str2020);

            int i21=i20+Convert.ToInt32(str20);

            int i22=i20+int.Parse(str20);

            string dateTime=DateTime.Now.ToString("dd.MM.yyyy");
            System.Console.WriteLine(   dateTime);
            string dateTime1=DateTime.Now.ToString("dd/MM/yyyy");
            System.Console.WriteLine(   dateTime1);
            string hour=DateTime.Now.ToString("HH.mm");
            System.Console.WriteLine(   hour);








        }
    }
}
