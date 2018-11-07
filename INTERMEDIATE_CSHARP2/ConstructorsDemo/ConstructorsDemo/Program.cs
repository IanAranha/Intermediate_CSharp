using System;
using System.Collections.Generic;

namespace ConstructorsDemo
{

    class MainClass
    {
        public static void Main(string[] args)
        {
            var customer = new Customer(1,"Ian");
            var order = new Order();
            customer.Orders.Add(order);
            Console.WriteLine(customer.ID);
            Console.WriteLine(customer.Name);
        }
    }
}
