using System;

namespace FieldsDemo
{

    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Create a new customer
            var customer = new Customer(1);

            //Add two orders to the customers list

            customer.Orders.Add(new Order());
            customer.Orders.Add(new Order());

            //If we display the Orders, we should see two items.
            Console.WriteLine(customer.Orders.Count);

            //Now, if we call the promote() method which is in the Customer object
            //That will reinitialize the list and set it to zero

            customer.Promote();
            Console.WriteLine(customer.Orders.Count);

            //The way around this is to set the List to READ ONLY.
            //in the customer class, line 10 should become
            //public  readonly List<Order> Orders = new List<Order>();

            // if you try to initialize the list elsewhere in code, the IDE will throw an error BEFORE
            //it compiles, runs the code.

        }
    }
}
