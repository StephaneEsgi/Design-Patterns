using System;

namespace FactoryMethod 
{
    public class Rectangle : Shape
    {
        public float LongSideSize { get; set; }
        public float ShortSideSize { get; set; }

        public void Draw(){
            System.Console.WriteLine($"Rectangle of [{LongSideSize}-{ShortSideSize}]");
        }
    }
}