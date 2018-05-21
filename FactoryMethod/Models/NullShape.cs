using System;

namespace FactoryMethod 
{
    public class NullShape : Shape
    {
        public void Draw(){
            System.Console.WriteLine("NullShape");
        }
    }
}