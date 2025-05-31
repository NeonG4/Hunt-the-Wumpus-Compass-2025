using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace SoundLibrary
{
    public class SoundManager : ISoundManager, IDisposable
    {
        public SoundManager() { }

        SoundPlayer music = new SoundPlayer();
        public void StartSound(string soundName)
        {
            SoundPlayer sound = new SoundPlayer(soundName);
            sound.Play();
        }
        public void StartMusic(string soundName)
        {
            music = new SoundPlayer(soundName);
            music.Play();
        }
        public void StopAllSounds()
        {
            music.Stop();
        }
        public void Dispose()
        {
            music.Stop();
            music.Dispose();
        }
    }
    public interface ISoundManager
    {
        public void StartSound(string soundName);
        public void StopAllSounds();
        public void StartMusic(string soundName);
    }
}
