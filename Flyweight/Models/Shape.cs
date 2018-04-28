using System;

namespace Flyweight
{
    public class Shape
    {
        public string Name { get; set; }

        public override string ToString(){
            return Name;
        }
    }
}