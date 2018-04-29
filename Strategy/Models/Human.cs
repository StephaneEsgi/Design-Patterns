using System;

namespace Strategy 
{
    public class Human
    {
        public string Name { get; set; }
        public string RealName { get; set; }

        public int Charisma { get; set; }
        public int Strength { get; set; }
        public float KmRange { get; set; }

        public override string ToString()
        {
            return $"{Name} [Vrai nom : {RealName}]\n\tCharisme : {Charisma}\n\tForce : {Strength}\n\tPortée : {KmRange}";
        }
    }
}