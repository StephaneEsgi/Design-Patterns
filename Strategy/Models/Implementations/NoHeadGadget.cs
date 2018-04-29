using System;

namespace Strategy 
{
    public class NoHeadGadget : HeadGadget
    {
        public void DoHeadAction()
        {
            // on ne fait rien
        }

        public override string ToString()
        {
            return "Emplacement vide";
        }
    }
}