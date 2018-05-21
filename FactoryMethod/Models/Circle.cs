using System;

namespace FactoryMethod 
{
    public class Circle : Shape
    {
        public float Radius { get; set; }

        public void Draw(){
            System.Console.WriteLine($"Circle with a radius of {Radius}");
        }
    }
}