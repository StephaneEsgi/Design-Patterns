using System;

namespace Observer
{
    public class ClassA : Observer
    {
        // On implémente Observer donc on doit définir les méthodes de cette interface (en l'occurence ici une seule)
        public void Update(){
            System.Console.WriteLine("ClassA");
        }
    }
}