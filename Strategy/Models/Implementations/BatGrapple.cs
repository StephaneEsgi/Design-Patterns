using System;

namespace Strategy 
{
    public class BatGrapple : WristGadget
    {
        public void Send()
        {
            System.Console.WriteLine("lance son grappin !");
        }

        public override string ToString()
        {
            return "BatGrapple";
        }
    }
}