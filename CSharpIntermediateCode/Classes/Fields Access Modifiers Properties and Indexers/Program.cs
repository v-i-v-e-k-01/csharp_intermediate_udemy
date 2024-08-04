using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Fields
{
    public class Program
    {
        static void Main(string[] args)
        {
            //// Fields

            //var customer = new Customer(1);

            //customer.Orders.Add(new Order());
            //customer.Orders.Add(new Order());

            ////customer.Promote();

            //Console.WriteLine(customer.Orders.Count);

            ////////////////////////////////


            ////Access Modifiers

            ////private --(Encapsulation in practice)

            ////see Person Class

            //var person = new Person();

            //person.SetBirthdate(new DateTime(1982, 1, 1));

            //Console.WriteLine(person.GetBirthdate().ToString("dd-MM-yyyy"));

            ////////////////////////////////
            
            //Properties -- Encapsulates fields, and their setters and getters

            // see Person Class

            var person = new Person(new DateTime(1982,1,1));
            //person.Birthdate = new DateTime(1982, 1, 1);
            Console.WriteLine(person.Age);

            ///////////////////////////////

            //Indexers

            var cookie = new HttpCookie();
            cookie["name"] = "Mosh";
            Console.WriteLine(cookie["name"]);




        }
    }
}
