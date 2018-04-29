using System;

namespace Strategy 
{
    public class BatHeadShot : HeadGadget
    {
        public void DoHeadAction()
        {
            System.Console.WriteLine("place un coup de boule très Bat ^^ !");
        }

        public override string ToString()
        {
            return "BatHeadShot";
        }
    }
}