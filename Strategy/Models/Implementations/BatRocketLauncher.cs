using System;

namespace Strategy 
{
    public class BatRocketLauncher : WristGadget
    {
        public void Send()
        {
            System.Console.WriteLine("lance un missile !!!! WTF ?!");
        }

        public override string ToString()
        {
            return "BatRocketLauncher";
        }
    }
}