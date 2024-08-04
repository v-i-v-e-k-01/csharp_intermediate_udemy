using System;
using System.Collections.Generic;


namespace Constructors
{
    //--------------- Constructors ---------------
    public class Customer
    {
        public int Id;
        public string Name;
        public List<Order> Orders;

        public Customer()
        {
            this.Orders = new List<Order>();
        }

        public Customer(string name)
            :this() // Runs Constructor without parameters first and then the current constructor
        {
            this.Name = name;
        }

        public Customer(int id)
            :this()
        {
            this.Id = id;
        }

        public Customer( int id, string name)
            :this(id)
        {
            //this.Id = id;
            this.Name = name;
        }
    }
}
