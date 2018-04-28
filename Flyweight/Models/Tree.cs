using System;
using System.Text;
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

        public string Render()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var shape in shapes)
            {
                sb.Append(shape.Name).Append(" ");
            }
            return sb.ToString();
        }
    }
}