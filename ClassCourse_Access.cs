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

            Employer worker1 = new Employer("Seyfo","kara",12345,"rsh" );            
            worker1.EmployeeInfoes();

            
            Employer worker2 = new Employer();
            worker2.Name = "Seyfo";
            worker2.Surname = "Kara";
            worker2.No = 12345;
            worker2.Department = "rsh";
            worker2.EmployeeInfoes();
            Employer worker3 = new Employer("Seyfo", "kara");
            worker3.EmployeeInfoes();

            Console.ReadKey();
        }

        class Employer
        {
            public string Name;
            public string Surname;
            public int No;
            public string Department;

            public Employer(string name, string surname, int no, string department)
            {
                this.Name=name;
                this.Surname = surname;
                this.No = no;
                this.Department = department;

            }
            public Employer(string name, string surname)
            {
                this.Name = name;
                this.Surname = surname;
               

            }
            public Employer() { }

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
