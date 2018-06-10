using System;
using System.Collections.Generic;
using static System.Console;

namespace Composite 
{
    public class Directory : Component
    {
        private List<Component> _children = new List<Component>();

        public Directory(string name) : base(name) { }

        public override void Add(Component component)
        {
            _children.Add(component);
        }

        public override void Remove(Component component)
        {
            _children.Remove(component);
        }

        public override void Display(int depth)
        {
            WriteLine(new String('-', depth) + name);

            // Affichage récursif des noeuds
            foreach (Component component in _children)
            {
                component.Display(depth + 2);
            }
        }
    }
}