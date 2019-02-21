using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CyberPunk2020_Console
{
    class SoundClass
    {

        public static void RandomSoundPlay()
        {
            ConsoleKeyInfo cki;
            while (true)
            {
                //Thread.Sleep(40);
                cki = Console.ReadKey();
                if (cki.Key != ConsoleKey.Escape)
                {
                    Random random = new Random();
                    int audio = random.Next(0, 9);
                    SoundPlayer typeSound = new SoundPlayer();
                    typeSound.SoundLocation = Environment.CurrentDirectory + "/" + audio + ".wav";
                    typeSound.Play();
                }
                
            }
        }

        public static void BeepSound()
        {
            ConsoleKeyInfo cki;
            while (true)
            {
                cki = Console.ReadKey();
                if (cki.Key != ConsoleKey.Escape)
                {
                    Console.Beep();
                }
            }
        }

    }
}
