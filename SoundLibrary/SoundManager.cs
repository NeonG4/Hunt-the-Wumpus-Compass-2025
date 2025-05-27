using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace SoundLibrary
{
    public class SoundManager : ISoundManager
    {
        public void StartSound(string soundName)
        {
            throw new NotImplementedException();
        }

        public void StopAllSounds()
        {
            throw new NotImplementedException();
        }
    }
    public interface ISoundManager
    {
        public void StartSound(string soundName);
        public void StopAllSounds();
    }
}
