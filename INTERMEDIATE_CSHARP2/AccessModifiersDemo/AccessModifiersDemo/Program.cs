using System;

namespace AccessModifiersDemo
{
    class MainClass
    {
        public class Person
        {
            private DateTime _birthday;

            public void SetBirthday(DateTime birthday)
            {
                _birthday = birthday;
            }

            public DateTime GetBirthday()
            {
                return _birthday;
            }

        }

        public class Vehicle
        {
            public string type { get; set; }

        }



        public static void Main(string[] args)
        {
            var person = new Person();
            person.SetBirthday(new DateTime(1966, 10, 04));
            Console.WriteLine(person.GetBirthday());

            var vehicle = new Vehicle();
            vehicle.type = "Car";
            Console.WriteLine("I bought a new {0}", vehicle.type);
        }
    }
}
