using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(days.pazar);
            Console.WriteLine((int)days.pazartesi);

            int sıcaklık = 32;
            if (sıcaklık<=(int)havaDurumu.normal)
            {
                Console.WriteLine("dışarı çıkmak için havanın ısınmasını bkleyelim");
            }
            else if (sıcaklık >= (int)havaDurumu.sıcak)
            {
                Console.WriteLine("dışarı çıkmak için hava iyi");
            }
            else if (sıcaklık >= (int)havaDurumu.normal && sıcaklık<(int)havaDurumu.çoksıcak)
            {
                Console.WriteLine("hadi dışarı çıkalım");
            }

        }
    }

    enum days
    {
        pazartesi,
        salı,
        çarşamba,
        perşembe,
        cuma=23,
        cumartesi,
        pazar
    }

    enum havaDurumu
    {
        soğuk=5,
        normal=20,
        sıcak=25,
        çoksıcak=30
    }
}
