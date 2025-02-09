using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1_Properties_Interfaces_.Interfaces.Assignment3
{
    internal class Audio:IMedia
    {
        public void Play()
        {
            Console.WriteLine("Audio starting to play....");
        }

        public void Stop()
        {
            Console.WriteLine("Audio is stopped.");
        }
    }
}
