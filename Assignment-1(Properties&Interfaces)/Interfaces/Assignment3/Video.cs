using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1_Properties_Interfaces_.Interfaces.Assignment3
{
    internal class Video : IMedia
    {
        public void Play()
        {
            Console.WriteLine("Video is starting to play....");
        }

        public void Stop()
        {
            Console.WriteLine("Video is stopped.");
        }
    }
}
