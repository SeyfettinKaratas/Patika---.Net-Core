using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class TryCatchFinally
    {
        public static void ErrorF()
        {
            try
            {
                Console.WriteLine("Enter a number :");
                int n1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Entered number is : " + n1);

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error : "+ex.Message.ToString());              
            }
            finally //optinoal
            {
                Console.WriteLine("Process finished!");
            }

            try
            {
                // int a = int.Parse(null);
                //int a = int.Parse("test");
                int a = int.Parse("11111111111111111111111111111");
                Console.WriteLine(a.);
            }
            catch (ArgumentNullException ex)
            {

                Console.WriteLine("value is empty");
                Console.WriteLine(ex);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("value type not correct");
                Console.WriteLine(ex);
            }
            catch(OverflowException ex)
            {
                Console.WriteLine("value is too small or too big");
                Console.WriteLine(ex);
            }

            Console.Read();
        }


    }
}
