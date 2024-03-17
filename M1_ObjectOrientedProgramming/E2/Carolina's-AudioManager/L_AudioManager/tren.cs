using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio.Wave;

namespace L_AudioManager
{
    public class tren : vehiculo
    {
        public override void VehiculoSound()
        {
            AudioFileReader audioFile = new AudioFileReader("Resources/tren.wav");
            WaveOutEvent waveOutEvent = new WaveOutEvent();

            waveOutEvent.Init(audioFile);
            waveOutEvent.Play();
            while (waveOutEvent.PlaybackState == PlaybackState.Playing) ;
            {
                System.Threading.Thread.Sleep(500);
            }

            waveOutEvent.Dispose();
            audioFile.Dispose();

        }
    }
}
