using System;
using System.Collections.Generic;

namespace Flyweight
{
    public class ShapeObjectFactory
    {
        IShape shape = null;
        Dictionary<string, IShape> shapes = new Dictionary<string, IShape>();

        public IShape GetShape(string key)
        {
            if (shapes.ContainsKey(key))
            {
                shape = shapes[key];
            }
            else
            {
                switch (key)
                {
                    case "Rectangle":
                        shape = new Ractangle();
                        shapes.Add(key, shape);
                        break;

                    case "Circle":
                        shape = new Circle();
                        shapes.Add(key, shape);
                        break;

                    default:
                        throw new Exception("Invalid value");
                }
            }

            return shape;
        }
    }
}