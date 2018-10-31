using System.Collections.Generic;

namespace FieldsDemo
{
    public class Customer
    {
        public int ID;
        public string Name;

        public List<Order> Orders = new List<Order>();

        public Customer(int id)
        {
            this.ID = id;
        }

        public Customer(int id, string name)
            : this(id)
        {
            this.Name = name;
        }

        public void Promote()
        {
            // some code here....
            //The code in the class intializes the List Order.
            //Suppose in our main class we add some orders to List, 
            //if we accidently re-initialize HERE, the orders already added
            //will be wiped out.

            Orders = new List<Order>();
        }
    }
}
