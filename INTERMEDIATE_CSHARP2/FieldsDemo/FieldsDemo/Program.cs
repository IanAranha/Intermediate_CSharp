﻿using System;

namespace FieldsDemo
{

    class MainClass
    {
        public static void Main(string[] args)
        {
            var customer = new Customer(1);
            customer.Orders.Add(new Order());
            customer.Orders.Add(new Order());
            customer.Orders.Add(new Order());

            Console.WriteLine(customer.Orders.Count);

            customer.Promote();

            Console.WriteLine(customer.Orders.Count);

        }
    }
}
