using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Encapsulation
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.Name = "seyfo";
            student.Surname = "kara";
            student.StudentNumber = 12;
            student.Studentclass = 1;
            student.GetStudentInfoes();
            student.ClassPlus();
            student.ClassMines();
            Student student1 = new Student("deniz", "arda", 1,1);
            student1.ClassMines();
            student1.ClassMines();
            student1.GetStudentInfoes();

            Console.ReadKey();
        }
    }
    class Student
    {
        private string name;

        private string surname;

        private int studentNumber;

        private int studentclass;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Surname { get => surname; set => surname = value; }
        public int StudentNumber { get => studentNumber; set => studentNumber = value; }
        public int Studentclass
        {
            get => studentclass; set
            {
                if (value<1)
                {
                    Console.WriteLine("class must be unless 1!!");
                    studentclass = 1;
                }
                else
                studentclass = value;
            } }

        public Student(string name, string surname, int studentNumber, int studentclass)
        {
            Name = name;
            Surname = surname;
            StudentNumber = studentNumber;
            Studentclass = studentclass;
        }
        public Student() { }

        public void GetStudentInfoes()
        {
            Console.WriteLine("*******studentinfoes********");
            Console.WriteLine("student name :{0}", this.Name);
            Console.WriteLine("student surname :{0}", this.Surname);
            Console.WriteLine("student number :{0}", this.StudentNumber);
            Console.WriteLine("student class :{0}", this.Studentclass);
        }
        public void ClassPlus()
        {
            this.studentclass += 1;
        }
        public void ClassMines()
        {

            this.studentclass -= 1;
        }

    }
}
