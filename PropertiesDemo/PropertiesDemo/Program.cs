using System;

namespace PropertiesDemo
{

    class MainClass
    {
        public static void Main(string[] args)
        {
            var person = new Person();
            person.Birthdate = new DateTime(1966, 06, 29);
            Console.WriteLine(person.Age);
        }
    }
}
