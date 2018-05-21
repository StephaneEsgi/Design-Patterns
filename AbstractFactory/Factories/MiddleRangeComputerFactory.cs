using System;

namespace AbstractFactory 
{
    public class MiddleRangeComputerFactory : AbstractFactory
    {
        public override Cpu createCpu()
        {
            return new Cpu {
                Brand = "Intel",
                ModelName = "i3",
                Price = 179f
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