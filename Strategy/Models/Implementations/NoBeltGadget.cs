using System;

namespace Strategy 
{
    public class NoBeltGadget : BeltGadget
    {
        public void DoAction()
        {
            // on ne fait rien
        }

        public override string ToString()
        {
            return "Emplacement vide";
        }
    }
}