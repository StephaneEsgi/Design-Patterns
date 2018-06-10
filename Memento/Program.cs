using System;
using static System.Console;

namespace Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product("Product A", "The first product in inventory", 50.00);  
            WriteLine(product);  
            ProductStateMemory memory = new ProductStateMemory();  
            memory.Memento = product.Memento;  
            product.Name = "Product B";  
            product.Description = "We have a change";  
            product.Cost = 60.00;  
            product.State = ProductState.CHANGED;  
            WriteLine(product);  
            product.RestoreMemento(memory.Memento);  
            WriteLine(product);  
            Console.ReadLine();
        }
    }
}
