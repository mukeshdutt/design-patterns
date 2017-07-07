using System;

namespace Flyweight
{
    public class Circle : IShape
    {
        public void Print()
        {
            System.Console.WriteLine("Printing Circle");
        }
    }

    public class Ractangle : IShape
    {
        public void Print()
        {
            System.Console.WriteLine("Printing Ractangle");
        }
    }
}