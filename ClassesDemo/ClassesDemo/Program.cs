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

        //Creating a parse method to CREATE AND OBJECT FROM A STRING.
        public static Person Parse(string str)
        {
            var person = new Person();
            person.Name = str;
            return person;
        }
    }





    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var person = new Person();
            person.Name = "Ian Aranha";
            person.Introduce("Andrew");


            //Alternate approach: Creating an objct from a string.
            Console.WriteLine("Alternate way of creating objects.");
            var persons = Person.Parse("John");
            persons.Introduce("Tammy");
        }
    }
}
