using System;

namespace Memento 
{
    public class Product 
    {
        private String name, description;  
        private double cost;  
        private ProductState state = ProductState.NEW;  
 
        public Product(string name, string description, double cost)  
        {  
            this.name = name;  
            this.description = description;  
            this.cost = cost;
            state = ProductState.LOADED;  
        }  
 
        public string Name  
        {  
            get { return name; }  
            set  
            {  
                name = value;  
                state = ProductState.CHANGED;  
            }  
        }  
 
        public string Description  
        {  
            get { return description; }  
            set  
            {  
                description = value;  
                state = ProductState.CHANGED;  
            }  
        }  
 
        public double Cost  
        {  
            get { return cost; }  
            set  
            {  
                cost = value;  
                state = ProductState.CHANGED;  
            }  
        }

        public override string ToString() {
            return $"Name: {Name}\nDescription: {Description}\nCost: {Cost}\nState: {State}\r\n";
        }
 
        public ProductState State  
        {  
            get { return state; }  
            set { state = value; }  
        }  
 
        public ProductMemento Memento  
        {  
            get { return new ProductMemento(name, description, cost, state); }  
        }  
 
        public void RestoreMemento(ProductMemento memento)  
        {  
            this.name = memento.Name;
            this.description = memento.Description;
            this.cost = memento.Cost;
            this.state = memento.State;
        }  
    }
}