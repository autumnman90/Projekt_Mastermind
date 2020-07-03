using System;
using System.Collections.Generic;
using System.Media;
using System.Text;
using System.Windows.Media;
using System.Windows.Controls;

namespace Projekt_Mastermind
{
    class Sound
    {

        public static void PlaySoundLoop()
        {
            SoundPlayer playSound = new SoundPlayer(Properties.Resources.Musik);
            
            playSound.PlayLooping();
            
            
        }

    }
}
