using System;

namespace ClassAccessModifiersDemo
{

    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var vehicle = new Vehicle("PEN");
            var car = new Car();
        }
    }
}
