using System;

namespace Facade 
{
    public class Projecteur 
    {
        public void Marche(){
            System.Console.WriteLine("Mise en route du projecteur.");
        }

        public void ModeGrandEcran(){
            System.Console.WriteLine("Mise en mode grand écran.");
        }

        public void Arret(){
            System.Console.WriteLine("Arrêt du projecteur.");
        }
    }
}