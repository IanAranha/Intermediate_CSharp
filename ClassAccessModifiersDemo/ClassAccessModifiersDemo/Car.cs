using System;

namespace ClassAccessModifiersDemo
{
    public class Car : Vehicle
    {
        public Car()
            :base("062HKS")
        {
            Console.WriteLine("Car in being initialized....");
        }
    }
}
