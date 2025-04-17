using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;
using WMPLib;
using System.Reflection;


namespace _132456_Donnelly_SoundDemo
{
    public partial class Form1 : Form
    {
        Sound playSounds = new Sound();
        //WindowsMediaPlayer player = new WindowsMediaPlayer();

        //List<byte[]> resources = new List<byte[]>();

        public Form1()
        {
            InitializeComponent();

            //resources.Add(Properties.Resources.Action_Hero);
            //resources.Add(Properties.Resources.Lost_In_The_Forest);
            //resources.Add(Properties.Resources.mixkit_raising_me_higher_34);
            //resources.Add(Properties.Resources.Steel_Rods);
            //resources.Add(Properties.Resources.Stormfront);

            //byte[] b = Properties.Resources.mixkit_raising_me_higher_34;
            //byte[] b = Properties.Resources.Action_Hero;
            //byte[] b = Properties.Resources.Paranoia;
            //FileInfo fileInfo = new FileInfo("test.wma");
            //FileStream fs = fileInfo.OpenWrite();
            //fs.Write(b, 0, b.Length);
            //fs.Close();
            comboBoxBackGroundMusic.SelectedIndex = 0;
            //player.URL = getBackgroundMusicName(resources[0],comboBoxBackGroundMusic.Text);// fileInfo.Name;
            //player.controls.stop();
            playSounds.setBackgroundMusic(comboBoxBackGroundMusic.SelectedIndex, comboBoxBackGroundMusic.Text);
        }

        //public string getBackgroundMusicName(byte[] bm,string fn)
        //{
            
        //    byte[] b = bm;
        //    FileInfo fileInfo = new FileInfo(fn + "_td.wma");

        //    FileStream fs = fileInfo.OpenWrite();
        //    fs.Write(b, 0, b.Length);
        //    fs.Close();

        //    return fileInfo.Name;
        //}

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            //SoundPlayer player = new SoundPlayer();
            //player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "\\1-16 We Will Rock You.wav";
            //player.Play();
            playSounds.PlayWeWillRockYou();
        }

        private void buttonSoundEffect_Click(object sender, EventArgs e)
        {
            //SoundPlayer player = new SoundPlayer();
            //player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "\\Door Creak and Scream.wav";
            //player.Play();
            playSounds.PlayCreakingDoor();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //playSounds.PlayHeartBeat();

            
            //player 
            if(button1.Text == "Play")
            {
                button1.Text = "Stop";
                //byte[] b = Properties.Resources.Steel_Rods;
                //FileInfo fileInfo = new FileInfo("test.wma");
                //FileStream fs = fileInfo.OpenWrite();
                //fs.Write(b, 0, b.Length);
                //fs.Close();
                //player.URL = fileInfo.Name;
                //player.controls.play();
                playSounds.playBackground();
            }
            else
            {
                button1.Text = "Play";
                //player.controls.stop();
                playSounds.stopBackground();
            }
            
        }

        private void comboBoxBackGroundMusic_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxBackGroundMusic.SelectedIndex != -1)
            {
                button1.Text = "Play";
                playSounds.stopBackground();
                playSounds.setBackgroundMusic(comboBoxBackGroundMusic.SelectedIndex, comboBoxBackGroundMusic.Text);
            }
            
            //player.controls.stop();
            //player.URL = getBackgroundMusicName(resources[comboBoxBackGroundMusic.SelectedIndex],comboBoxBackGroundMusic.Text);// fileInfo.Name;
        }
    }
}
