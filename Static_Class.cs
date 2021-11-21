using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Static_Class
    {
        static void Main(string[] args)
        {
            Console.WriteLine("employer count : {0}", Employer.EmployerCount );
            Employer employer = new Employer("ayşe","yılmaz","ik");
            Employer employer1= new Employer("ayşe", "yılmaz", "ik");
            Console.WriteLine("employer count : {0}", Employer.EmployerCount);

            //Functions f = new Functions();
            Console.WriteLine("sum of numbers: {0}",Functions.Sum(100,200));
            Console.WriteLine("mines of numbers: {0}", Functions.Mines(100, 200));
            Console.ReadKey();

        }
    }

    class Employer
    {
        private static int employerCount;

        public static int EmployerCount { get => employerCount; }

        private string Name;
        private string Surname;
        private string Department;

        static Employer()
        {
            employerCount = 0;

        }
        public Employer(string name, string surname, string department)
        {
            this.Name = name;
            this.Surname = surname;
            this.Department = department;
            employerCount += 1;
        }
    }

    static class Functions
    {
        public static long Sum(int a,int b)
        {
            return a + b;            
        }
        public static long Mines(int a, int b)
        {
            return a - b;
        }
    }
}
