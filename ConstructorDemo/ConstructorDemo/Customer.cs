using System;
using System.Collections.Generic;

namespace ConstructorDemo
{
    public class Customer
    {
        public int ID;
        public string Name;
        //When any customer enters, we always assign an empty list to this customer
        //Initialization should happen in this class and not in the main program class
        public List<Orders> Orders;


        //Initializing a new parameterless customer.
        //in main program will have to intitialize as
        // var customer = new Customer()
        // customer.id = 123
        // customer.name = "ian"
        public Customer()
        {
            Orders = new List<Orders>();
        }

        //second type of initialization
        // var customer = new Customer(123)
        // customer.name = "Ian"
        public Customer(int id)
            :this()
        {
            this.ID = id;
        }

        //third type of initialization:
        // var customer = new Customer(123, "Ian")
        public Customer(int id, string name)
            :this(id)
        {
            this.ID = id;
            this.Name = name;
        }


        //the :this() command lines causes the program to go back to original constructor and pull in the empty list initialization.
        //so no matter which method we use to construct a new customer, the new customer has an empty list.
    }
}
