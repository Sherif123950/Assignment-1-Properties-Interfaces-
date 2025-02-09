using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1_Properties_Interfaces_.Interfaces.Assignment2
{
    internal class Car : IEngineVehicle
    {
        public void Start()
        {
            Console.WriteLine("Car Started ......");
        }

        public void Stop()
        {
            Console.WriteLine("Car Stopped.");
        }
    }
}
