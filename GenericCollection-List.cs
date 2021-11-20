using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<T>
            //T--> object
            List<int> numberList = new List<int>();
            numberList.Add(23);
            numberList.Add(10);
            numberList.Add(4);
            numberList.Add(5);
            numberList.Add(92);
            numberList.Add(34);

            List<string> colorList = new List<string>();
            colorList.Add("red");
            colorList.Add("blue");
            colorList.Add("orange");
            colorList.Add("yellow");
            colorList.Add("green");

            Console.WriteLine(colorList.Count);
            Console.WriteLine(numberList.Count);

            foreach (var number in numberList)
            {
                Console.WriteLine(number);
            }
            foreach (var color in colorList)
            {
                Console.WriteLine(color);
            }

            numberList.ForEach(number => Console.WriteLine(number));
            colorList.ForEach(color => Console.WriteLine(color));

            numberList.Remove(4);
            colorList.Remove("green");
            numberList.ForEach(number => Console.WriteLine(number));
            colorList.ForEach(color => Console.WriteLine(color));

            numberList.RemoveAt(0);
            colorList.RemoveAt(1);
            numberList.ForEach(number => Console.WriteLine(number));
            colorList.ForEach(color => Console.WriteLine(color));

            if (numberList.Contains(10)) 
            {
                Console.WriteLine("List have 10");
            }

            Console.WriteLine(colorList.BinarySearch("yellow"));

            string[] animals = { "cat", "dog", "bird" };
            List<string> animalList = new List<string>(animals);

            animalList.Clear();


            List<Users> userList = new List<Users>();
            Users user1 = new Users();
            user1.Name = "Seyfo";
            user1.Name = "kara";
            user1.Age = 27;
            Users user2 = new Users();
            user2.Name = "Seyfo1";
            user2.Name = "kara1";
            user2.Age = 271;

            userList.Add(user1);
            userList.Add(user2);

            List<Users> newList = new List<Users>();
            newList.Add(new Users()
            {
                Name = "emin",
                Surname="aykan",
                Age=27
            });

            foreach (Users user in userList)
            {
                Console.WriteLine("user name :"+user.Name);
                Console.WriteLine("user surname :" + user.Surname);
                Console.WriteLine("user age :" + user.Age);
            }

            newList.Clear();
        }
    }


    public class Users
    {
        private string name;
        private string surname;
        private int age;

        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public int Age { get => age; set => age = value; }
    }
}
