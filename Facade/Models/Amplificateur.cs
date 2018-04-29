using System;

namespace Facade 
{
    public class Amplificateur 
    {
        int volume;

        public void Marche()
        {
            System.Console.WriteLine("Mise en route de l'ampli !");
        }

        public void SetSonSurround()
        {
            System.Console.WriteLine("Activation du son Surround.");
        }

        public void SetVolume(int volume)
        {
            this.volume = volume;
            System.Console.WriteLine($"Réglage du volume de l'ampli à {volume}.");
        }

        public void Arret()
        {
            System.Console.WriteLine("Arrêt de l'ampli.");
        }
    }
}