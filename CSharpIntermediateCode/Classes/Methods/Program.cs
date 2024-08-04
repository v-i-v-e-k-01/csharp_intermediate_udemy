using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    // ---------------- Methods -----------------

    public class Calculator
    {
        public int Add(params int[] numbers)
        {
            return numbers.Sum();
        }
    }


    public class Program
    {
        static void Main(string[] args)
        {
            var calculator =new Calculator();

            var result = calculator.Add(1, 2, 3, 4, 5);
            //without params keyword -- var result = calculator.Add(new int[] {1,2,3,4,5});

            Console.WriteLine("Sum: "+result);

            //////////////////////////////////
            

            var point = new Point(10, 20);

            point.Move(new Point(40, 60));

            
            Console.WriteLine("Point is at ({0}, {1})",point.X ,point.Y);

            point.Move(100, 200);
            Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y);

            ///////////////////////////////////


            int number;

            var result2 = int.TryParse("abc", out number);

            if (result2)
                Console.WriteLine(number);
            else
                Console.WriteLine("Conversion failed");
            

        }
    }

}
