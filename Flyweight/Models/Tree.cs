using System;
using System.Collections.Generic;

namespace Flyweight
{
    public class Tree
    {
        List<Shape> shapes;

        public Tree(List<Shape> shapes)
        {
            this.shapes = shapes;
        }

        public void Render()
        {
            foreach (var shape in shapes)
            {
                System.Console.Write(shape + " ");
            }
        }
    }
}