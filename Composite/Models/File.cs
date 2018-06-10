using System;
using static System.Console;

namespace Composite 
{
    public class File : Component
    {
        public File(string name) : base(name) { }

        public override void Add(Component c)
        {
            WriteLine("Cannot add to a leaf");
        }

        public override void Remove(Component c)
        {
            WriteLine("Cannot remove from a leaf");
        }

        public override void Display(int depth)
        {
            WriteLine(new String('-', depth) + name);
        }
    }
}