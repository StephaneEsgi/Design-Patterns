using System;

namespace Facade 
{
    public class MachineAPopcorn 
    {
        public void Marche(){
            System.Console.WriteLine("Mise en route de la machine à Pop-Corn !");
        }

        public void Eclater(){
            System.Console.WriteLine("Préparation du Pop-Corn...");
        }

        public void Arret(){
            System.Console.WriteLine("Arrêt de la machine à Pop-Corn.");
        }
    }
}