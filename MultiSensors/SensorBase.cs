using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiSensors
{
    internal abstract class SensorBase
    {
        public string Id { get; set; }
        public string SerialNumber { get; set; }

        public SensorBase() 
        {
            Console.WriteLine("Blank base class constructor");
        }

        public void DisplayHardwareInfo()
        {
            Console.WriteLine($"{Id} {SerialNumber}");
        }

    }
}
