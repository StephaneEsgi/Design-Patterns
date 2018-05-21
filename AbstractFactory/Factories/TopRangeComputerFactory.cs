using System;

namespace AbstractFactory
{
    public class TopRangeComputerFactory : AbstractFactory
    {
        public override Cpu createCpu()
        {
            return new Cpu {
                Brand = "Intel",
                ModelName = "i7",
                Price = 659f
            };
        }

        public override MotherBoard createMotherBoard()
        {
            return new MotherBoard();
        }

        public override Ram createRam()
        {
            return new Ram();
        }
    }
}