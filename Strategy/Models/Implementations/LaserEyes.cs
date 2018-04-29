using System;

namespace Strategy 
{
    public class LaserEyes : Power
    {
        public void UsePower(){
            System.Console.WriteLine("tire des rayons lasers par les yeux !!");
        }

        public override string ToString(){
            return "LaserEyes";
        }
    }
}