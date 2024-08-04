using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Introduction
{
    //******************* Section 2: Classes *******************

    //---------------- Introduction to Classes ----------------
    public class Person
    {
        public string Name;

        public void Introduce()
        {
            Console.WriteLine("Hi, my name is "+Name);
        }

        public static void Hey()
        {
            Console.WriteLine("Hey this is static member");
        }

        public void Introduce(string to)
        {
            Console.WriteLine("Hi {0}, I am {1}", to, Name);
        }

        public static Person Parse(string str)
        {
            var person = new Person();
            person.Name = str;
            return person;
        }
    }



    public class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            // OR
            // Person person = new Person();

            person.Name = "Mosh";
            person.Introduce();

            //Class Members

            ////Instance Members
            person.Introduce(); //uses object 

            ////Static Members
            Person.Hey();  //uses class, no object needed

            person.Introduce("Mesh");

            var p = Person.Parse("John");

            p.Introduce();
        }

        
    }
}
