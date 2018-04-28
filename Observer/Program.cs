using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            // On crée un objet qui hérite d'Observable
            var observable = new ConcreteObservable();

            // On "inscrit" 2 classes implémentant Observer auprès de l'Observable
            observable.AddObserver(new ClassA());
            observable.AddObserver(new ClassB());

            // On déclenche les méthodes Update() au sein des classes inscrites auprès de l'Observable
            observable.NotifiyObservers();

        }
    }
}
