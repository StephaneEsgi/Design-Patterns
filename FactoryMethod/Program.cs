using System;
using System.Collections.Generic;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();

            shapes.Add(ShapeFactory.CreateShape("Circle"));
            shapes.Add(ShapeFactory.CreateShape<Circle>());
            shapes.Add(ShapeFactory.CreateShape("Rectangle"));
            shapes.Add(ShapeFactory.CreateShape<Rectangle>());
            shapes.Add(ShapeFactory.CreateShape("Square"));
            shapes.Add(ShapeFactory.CreateShape<Square>());

            foreach (var shape in shapes)
            {
                shape.Draw();
            }
        }
    }
}
