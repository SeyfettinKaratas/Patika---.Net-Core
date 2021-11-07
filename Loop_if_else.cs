using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Loop_if_else
    {
        static void Main(string[] args)
        {
            int time = DateTime.Now.Hour;
            if (time>=6 && time<11)
            {
                Console.WriteLine("Good Morning!");
            }
            else if (time <= 18)
            {
                Console.WriteLine("Good Afternoon!");
            }
            else
            {
                Console.WriteLine("Good Night!");
            }

            string result = time <= 18 ? "Good Afternoon" : "Good Night";
            result = time >= 6 && time < 11 ? "Good morning" : time <= 18 ? "Good afternoon" : "Good night";
            Console.WriteLine(result);
            

            Console.ReadLine();
        }
    }
}
