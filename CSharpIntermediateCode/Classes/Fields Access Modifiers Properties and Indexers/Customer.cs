using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fields
{
    public class Customer
    {
        ////List<Order> Orders;

        ////public Customer()
        ////{
        ////    Orders = new List<Order>();

        ////}

        ////OR

        //readonly List<Order> Orders = new List<Order>();

        /////////////////////////////

        public int Id;
        public string Name;
        public readonly List<Order> Orders = new List<Order>();

        public Customer(int id)
        {
            this.Id = id;
        }

        public Customer(int id, string name)
            :this(id)
        {
            this.Name = name;
        }

        public void Promote()
        {
            //Orders = new List<Order>();
        }
    }
}
