using System;

namespace Flyweight
{
    class Program
    {
        static void Main(string[] args)
        {
            ShapeObjectFactory sof = new ShapeObjectFactory();
            IShape shape = sof.GetShape("Rectangle");
            shape.Print();

            shape = sof.GetShape("Rectangle");
            shape.Print();
           
            shape = sof.GetShape("Circle");
            shape.Print();
           
            shape = sof.GetShape("Circle");
            shape.Print();
           
            shape = sof.GetShape("Rectangle");
            shape.Print();
        }
    }
}
