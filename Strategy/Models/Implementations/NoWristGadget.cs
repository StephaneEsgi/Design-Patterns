using System;

namespace Strategy 
{
    public class NoWristGadget : WristGadget
    {
        public void Send()
        {
            // on ne fait rien
        }

        public override string ToString()
        {
            return "Emplacement vide";
        }
    }
}