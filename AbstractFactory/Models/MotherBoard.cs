using System;

namespace AbstractFactory 
{
    public class MotherBoard 
    {
        public string Brand { get; set; }
        public string ModelName { get; set; }
        public int UsbCount { get; set; }
        public int PciExpressCount { get; set; }
        public float Price { get; set; }
    }
}