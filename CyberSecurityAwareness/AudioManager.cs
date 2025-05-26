using System;
using System.Media;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberSecurityAwareness
{
    using System.Media;

    public class AudioManager
    {
        public static void PlayGreeting()
        {
            SoundPlayer player = new SoundPlayer(@"VoiceGretting.wav");
            player.Load();
            player.PlaySync();  // Plays the sound in sync
        }
    }

}
