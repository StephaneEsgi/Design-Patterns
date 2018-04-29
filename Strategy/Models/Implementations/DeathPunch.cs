using System;

namespace Strategy 
{
    public class DeathPunch : Power
    {
        public void UsePower(){
            System.Console.WriteLine("frappe avec son 'poing de la mort qui tue' !");
        }

        public override string ToString(){
            return "DeathPunch";
        }
    }
}