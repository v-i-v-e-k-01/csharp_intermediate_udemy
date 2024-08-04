using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    public class Vehicle
    {
        private readonly string _registrationNumber;
        //public Vehicle()
        //{
        //    Console.WriteLine("Vehicle is being initialized");
        //}

        public Vehicle(string registrationNumber)
        {
            _registrationNumber = registrationNumber;
            Console.WriteLine("Registration is being initialized {0}", _registrationNumber);
        }
    }

    public class Car: Vehicle
    {
        public Car(string registrationNumber)
            :base(registrationNumber)
        {
            Console.WriteLine("Car is being initialized {0}", registrationNumber);
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var car = new Car("xyz1234");
        }
    }
}
