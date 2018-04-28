using System;

namespace Observer
{
    public class ClassB : Observer
    {
        // On implémente Observer donc on doit définir les méthodes de cette interface (en l'occurence ici une seule)
        public void Update(){
            System.Console.WriteLine("ClassB");
        }
    }
}