using System;

namespace Strategy 
{
    public class BatBomb : BeltGadget
    {
        public void DoAction()
        {
            System.Console.WriteLine("utilise une grenade !");
        }

        public override string ToString()
        {
            return "BatBomb";
        }
    }
}