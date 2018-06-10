using System;

namespace Memento 
{
    public class ProductMemento  
    {  
        public string Name { get; private set; }  
        public string Description { get; private set; }  
        public double Cost { get; private set; }  
        public ProductState State { get; private set; }  
 
        public ProductMemento(string name, string description, double cost, ProductState state)  
        {  
            Name = name;  
            Description = description;  
            Cost = cost;  
            State = state;  
        }  
    }  
}