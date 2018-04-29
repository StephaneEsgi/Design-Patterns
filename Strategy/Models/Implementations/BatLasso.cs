using System;

namespace Strategy 
{
    public class BatLasso : BeltGadget
    {
        public void DoAction()
        {
            System.Console.WriteLine("lance son lasso !!");
        }

        public override string ToString()
        {
            return "BatLasso";
        }
    }
}