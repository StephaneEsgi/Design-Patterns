using System;

namespace Strategy 
{
    public class BatEars : HeadGadget
    {
        public void DoHeadAction()
        {
            System.Console.WriteLine("accroît son ouïe et perçoit son environnement !");
        }

        public override string ToString()
        {
            return "BatEars";
        }
    }
}