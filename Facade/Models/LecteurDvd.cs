using System;

namespace Facade 
{
    public class LecteurDvd 
    {
        public void Marche() 
        {
            System.Console.WriteLine("Allumage du lecteur DVD.");
        }

        public void Jouer(string film) 
        {
            System.Console.WriteLine($"Lancement du film '{film}' !");
        }

        public void Stop() 
        {
            System.Console.WriteLine("Arrêt du film.");
        }

        public void Ejecter() 
        {
            System.Console.WriteLine("Ejection du DVD.");
        }

        public void Arret() 
        {
            System.Console.WriteLine("Arrêt du lecteur DVD.");
        }

    }
}