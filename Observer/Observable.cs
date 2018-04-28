using System;
using System.Collections.Generic;

namespace Observer
{
    public abstract class Observable{

        // Cette liste va accueillir les classes, implémentant l'interface Observer, et qui souhaitent être notifiées
        protected List<Observer> observers = new List<Observer>();

        // Cette méthode permet d'ajouter une implémentation d'Observer à la liste à notifier
        public void AddObserver(Observer observer){
            observers.Add(observer);
        }

        // Cette méthode permet de retirer une implémentation d'Observer à la liste à notifier
        public void RemoveObserver(Observer observer){
            observers.Remove(observer);
        }

        // Cette méthode permet de notifier toutes les implémentations d'Observer inscrites, au travers de leur méthode Update()
        public void NotifiyObservers(){
            foreach(var obs in observers)
                obs.Update();
        }
    }
}