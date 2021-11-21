using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class ClassCourse
    {
        static void Main(string[] args)
        {
            ///public her yerden erişm sağlar
            ///private sadece bulunduğu class içinde
            ///internal sadece bulunduğu projeden
            ///protected sadece tnaımlandığı sınıf veya kalıtım alan sınıflardan ulaşılabilir.
            ///

            Employer worker1 = new Employer();
            worker1.Name = "Seyfo";
            worker1.Surname = "Kara";
            worker1.No = 12345;
            worker1.Department = "rsh";
            worker1.EmployeeInfoes();

            
            Employer worker2 = new Employer();
            worker2.Name = "Seyfo";
            worker2.Surname = "Kara";
            worker2.No = 12345;
            worker2.Department = "rsh";
            worker2.EmployeeInfoes();

            Console.ReadKey();
        }

        class Employer
        {
            public string Name;
            public string Surname;
            public int No;
            public string Department;

            public void EmployeeInfoes()
            {
                Console.WriteLine("worker name : "+Name);
                Console.WriteLine("worker surname : "+Surname);
                Console.WriteLine("worker no : "+No);
                Console.WriteLine("worker department : "+Department);

            }
        }
    }
}
