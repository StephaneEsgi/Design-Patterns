using System;

namespace Facade 
{
    public class Ecran 
    {
        public void Baisser()
        {
            System.Console.WriteLine("Descente de l'écran.");
        }

        public void Monter()
        {
            System.Console.WriteLine("L'écran remonte.");
        }
    }
}