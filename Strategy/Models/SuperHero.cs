using System;
using System.Text;
using System.Collections.Generic;

namespace Strategy 
{
    public class SuperHero : Human
    {
        public List<Power> BirthPowers { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder("\n\tSuper-pouvoirs : ");

            for (int i = 0; i < BirthPowers.Count; i++)
                sb.Append($"\n\t\t{BirthPowers[i]}");

            return base.ToString() + sb.ToString();
        }
    }
}