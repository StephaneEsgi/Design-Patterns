using System;

namespace AbstractFactory 
{
    public class OutOfRangeComputerFactory : AbstractFactory
    {
        public override Cpu CreateCpu()
        {
            return new Cpu();
        }

        public override MotherBoard CreateMotherBoard()
        {
            return new MotherBoard();
        }

        public override Ram CreateRam()
        {
            return new Ram();
        }
    }
}