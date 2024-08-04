using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CastingBoxing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //upcasting
            Text text = new Text();
            Shape shape = text;

            text.Width = 200;
            shape.Width = 100;
            //gives 100 as both refer to same object but different views

            //downcasting
            Shape shape2 = new Text();

            Text text2 = (Text)shape2;

            //boxing -- upcasting to object class (which is base class of all objects)

            var list = new ArrayList();
            list.Add(1); //int object,value type can be upcasted/boxed to object class
            list.Add("Mosh"); //string object, reference type, cannot be boxed

            list.Add(DateTime.Today); //DateTime object, struct type, can be upcasted/boxed

            //unboxing
            object obj = 10;
            int number = (int)obj;


            //boxing and unboxing has processing penalty, thus should be avoided, which is in case of ArrayList() wherein element data type can be anything and needs to be converted to object data type first and then store.

            //whereas generic data types like  List<>() have predefined data type so it takes objects of the same data type and rejects all others. Saves processing and conversion of boxing.

            //like in example below "anotherList" accepts only integer objects and "names" accept only strings

            var anotherList = new List<int>();
            var names = new List<string>();
            names.Add("jk");

        }
    }
}
