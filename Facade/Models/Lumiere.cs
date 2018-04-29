using System;

namespace Facade 
{
    public class Lumiere 
    {
        static int MAX_INTESITY = 20;
        int intensity = MAX_INTESITY;

        public void Attenuer(int value){
            intensity -= value;
            if(intensity < 0)
                intensity = 0;
            System.Console.WriteLine($"Intensité de la lumière abaissée de {value} pts.");
        }

        public void Marche(){
            intensity = MAX_INTESITY;
            System.Console.WriteLine($"Intensité de la lumière ramenée au niveau max.");
        }
    }
}