using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1_Properties_Interfaces_.Interfaces.Assignment3
{
    internal class MediaPlayer
    {
        private readonly IMedia _media;

        public MediaPlayer(IMedia media)
        {
            this._media = media;
        }
        public void Play()
        {
            this._media.Play();
        }
        public void Stop()
        {
            this._media.Stop();
        }
    }
}
