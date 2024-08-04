using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverriding
{
    public class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public Position Position { get; set; }
        //public ShapeType Type { get; set; }

        public virtual void Draw()
        {
            Console.WriteLine();
        }
    }

    public class Circle : Shape
    {
        public override void Draw()
        {
            //base.Draw(); -- used when there's some common implementation in base class (here, can be drawing outline before circle)

            Console.WriteLine("Draw a circle");
        }
    }

    public class Rectangle : Shape
    {
        public override void Draw()
        {
            //base.Draw();

            Console.WriteLine("Draw a rectangle");
        }

    }

    //public enum ShapeType
    //{
    //    Circle,
    //    Rectangle
    //}

    public enum Position
    {
    }

    public class Canvas
    {
        public void DrawShapes(List<Shape> shapes)
        {
            foreach (var shape in shapes)
            {
                //switch (shape.Type)
                //{
                //            case ShapeType.Circle:
                //                Console.WriteLine("Draw a circle");
                //                break;
                //            case ShapeType.Rectangle:
                //                Console.WriteLine("Draw a rectangle");
                //                break;
                //}

                shape.Draw();
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var shapes = new List<Shape>();
            //shapes.Add(new Shape { Width = 100, Height = 100, Type = ShapeType.Rectangle });
            //shapes.Add(new Shape { Width = 100, Height = 30, Type = ShapeType.Circle });

            shapes.Add(new Rectangle { Width = 100, Height = 100 });
            shapes.Add(new Circle { Width = 100, Height = 30 });

            var canvas = new Canvas();
            canvas.DrawShapes(shapes);
        }
    }
}
