using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Constructors
{
    public class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer();
            Console.WriteLine("Customer 1: ");
            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);

            var customer2 = new Customer(2);
            Console.WriteLine("Customer 2: ");
            Console.WriteLine(customer2.Id);
            Console.WriteLine(customer2.Name);

            var customer3 = new Customer("John");
            Console.WriteLine("Customer 3: ");
            Console.WriteLine(customer3.Id);
            Console.WriteLine(customer3.Name);

            var customer4 = new Customer("4, John");
            Console.WriteLine("Customer 4: ");
            Console.WriteLine(customer4.Id);
            Console.WriteLine(customer4.Name);

            var order = new Order();
            customer.Orders.Add(order);


        }
    }
}
