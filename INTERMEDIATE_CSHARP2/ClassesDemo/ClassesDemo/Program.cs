using System;

namespace ClassesDemo
{
    public class Person
    {
        public string Name;

        public void Introduce(string to)
        {
            Console.WriteLine("Hello {0}, my name is {1}", to, Name);
        }

    }

    class MainClass
    {
        public static void Main(string[] args)
        {
            var person = new Person();
            person.Name = "Ian";
            person.Introduce("Michael");
        }
    }
}
