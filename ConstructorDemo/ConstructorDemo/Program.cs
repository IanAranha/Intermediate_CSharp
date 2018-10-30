using System;

namespace ConstructorDemo
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var customer = new Customer(123, "Ian");
            var customer2 = new Customer(456);;
            customer2.Name = "Tadpole";
            var customer3 = new Customer();
            customer3.ID = 789;
            customer3.Name = "Bozo";
            Console.WriteLine(customer);
            Console.WriteLine(customer2);
            Console.WriteLine(customer3);
            Console.WriteLine("First customer: "+ customer.ID + " "+ customer.Name);
            Console.WriteLine("Second customer: " + customer2.ID + " " + customer2.Name);
            Console.WriteLine("Third customer: " + customer3.ID + " " + customer3.Name);


        }
    }
}
