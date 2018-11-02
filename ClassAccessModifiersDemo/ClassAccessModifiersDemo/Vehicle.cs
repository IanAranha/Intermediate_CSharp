using System;

namespace ClassAccessModifiersDemo
{
    public class Vehicle
    {
        private readonly string registrationNumber;

        //public Vehicle()
        //{
        //    Console.WriteLine("Vehicle is being initiated....");
        //}

        public Vehicle(string registrationNumber)
        {
            this.registrationNumber = registrationNumber;
        }
    }
}
