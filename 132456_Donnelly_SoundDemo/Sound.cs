using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using WMPLib;
using System.IO;

namespace _132456_Donnelly_SoundDemo
{
    public class Sound
    {

        WindowsMediaPlayer player = new WindowsMediaPlayer();

        List<byte[]> resources = new List<byte[]>();

        public Sound()
        {
            resources.Add(Properties.Resources.Action_Hero);
            resources.Add(Properties.Resources.Lost_In_The_Forest);
            resources.Add(Properties.Resources.mixkit_raising_me_higher_34);
            resources.Add(Properties.Resources.Steel_Rods);
            resources.Add(Properties.Resources.Stormfront);
            resources.Add(Properties.Resources.Night_Music);
        }

        public string getBackgroundMusicName(byte[] bm, string fn)
        {

            byte[] b = bm;
            FileInfo fileInfo = new FileInfo(fn + "_td.wma");

            FileStream fs = fileInfo.OpenWrite();
            fs.Write(b, 0, b.Length);
            fs.Close();

            return fileInfo.Name;
        }

        public void playBackground()
        {
            player.controls.play();
        }

        public void stopBackground()
        {
            player.controls.stop();
        }

        public void setBackgroundMusic(int index, string fn)
        {
            player.URL = getBackgroundMusicName(resources[index], fn);// fileInfo.Name;
            player.controls.stop();
        }

        public void PlayWeWillRockYou()
        {
            SoundPlayer player = new SoundPlayer();
            string filePath = AppDomain.CurrentDomain.BaseDirectory;
            player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "\\fast-sweeping-transition.wav";
            player.Play();
        }

        public void PlayCreakingDoor()
        {
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "\\bubble-alert.wav";
            player.Play();
        }

        public void PlayHeartBeat()
        {
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "\\Heart Beat 03.wav";
            player.Play();
        }
    }
}
