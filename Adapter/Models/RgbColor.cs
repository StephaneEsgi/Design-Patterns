using System;

namespace Adapter 
{
    public class RgbColor 
    {
        public int R { get; set; }
        public int G { get; set; }
        public int B { get; set; }

        public RgbColor(int r, int g, int b)
        {
            R = r;
            G = g;
            B = b;
        }

    }
}