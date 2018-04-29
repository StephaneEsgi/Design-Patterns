using System;

namespace Adapter 
{
    public class ArgbColor
    {
        public int A { get; set; }
        public int R { get; set; }
        public int G { get; set; }
        public int B { get; set; }

        public ArgbColor(int a, int r, int g, int b)
        {
            A = a;
            R = r;
            G = g;
            B = b;
        }

        public override string ToString(){
            return $"[A:{A}, R:{R}, G:{G}, B:{B}]";
        }
    }
}