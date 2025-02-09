using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1_Properties_Interfaces_.Interfaces.Assignment2
{
    internal class Motorcycle:IEngineVehicle
    {
        public void Start()
        {
            Console.WriteLine("Motorcycle Started ......");
        }

        public void Stop()
        {
            Console.WriteLine("Motorcycle Stopped.");
        }
    }
}
