using System;

namespace AccessModifiersDemo
{
    public class Person
    {
        private DateTime _birthday;

        public void SetBirthdate(DateTime birthday)
        {
            _birthday = birthday;
        }

        public DateTime GetBirthdate()
        {
            return _birthday;
        }
    }

    class MainClass
    {
        public static void Main(string[] args)
        {
            var person = new Person();
            person.SetBirthdate(new DateTime(1966, 06, 29));
            Console.WriteLine(person.GetBirthdate());
        }
    }
}
