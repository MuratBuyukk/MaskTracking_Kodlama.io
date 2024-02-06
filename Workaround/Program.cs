using Business.Concrete;
using Business.Abstract;
using Entities.Concrete;
using System;

namespace Workaround
{
     class Program
    {
        static void Main(string[] args)
        {
            // Variables();
            SayHi("Engin");
            SayHi("Engin");
            SayHi("Engin");
            SayHi();
            int result = Sum(3, 5);
            Sum();

            string[] students = new string[3];
            students[0] = "Engin";
            students[1] = "Kerem";
            students[2] = "Berkay";

            students = new string[4];
            students[3] = "Ilker";


            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine(students[i]);
            }

            string[] cities1 = new[] { "Ankara", "Istanbul", "Izmır" };
            string[] cities2 = new[] { "Bursa", "Antalya", "Diyarbakir" };

            cities2 = cities1;
            cities1[0] = "Adana";
            Console.WriteLine(cities2[0]);

            int number1 = 10;
            int number2 = 20;
            number2 = number1;
            number1 = 30;
            Console.WriteLine(number2);

            Person person1 = new Person();
            person1.FirstName = "ENGİN";
            person1.SurName = "DEMİROĞ";
            person1.BirthYear = 1985;
            person1.NationalIdentity = 123;

            Person person2 = new Person();
            person2.FirstName = "MURAT";


            foreach (var c in cities1)
            {
                Console.WriteLine(c);
            }

            List<string> newCities = new List<string> { "NewAnkara", "NewIstanbul", "NewIzmir" };
            newCities.Add("AddAmasya");
            foreach (var c in newCities)
            {
                Console.WriteLine(c);
            }

            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);


        }

        static void SayHi(string Name = "Noname")
        {
            Console.WriteLine("Hello!!... " + Name);
        }

        private static void Variables()
        {
            Console.WriteLine("Hello World");
            Console.ReadLine();
        }

        static int Sum(int number1 = 10 , int number2 = 5)
        {
            int result = number1 + number2;
            Console.WriteLine("Sum: " + result);
            return result;
        }


    }
}
