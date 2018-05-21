using System;

namespace FactoryMethod 
{
    public class Square : Shape
    {
        public float SideSize { get; set; }

        public void Draw(){
            System.Console.WriteLine($"Square of [{SideSize}-{SideSize}]");
        }
    }
}