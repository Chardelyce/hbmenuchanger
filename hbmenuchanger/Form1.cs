using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hbmenuchanger
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"D:\hbmenuchanger\hbmenuchanger\goocean.wav");
            player.PlayLooping();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

       

        private void toolStripButton1_Click(object sender, EventArgs e)//file button
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {

                    filePath = openFileDialog.FileName;


                    var fileStream = openFileDialog.OpenFile();

                   
                }
            }
        }
        private void toolStripButton2_Click(object sender, EventArgs e)//github
        {
           
           
            
            ProcessStartInfo psInfo = new ProcessStartInfo
            {
                FileName = "https://github.com/Chardelyce/hbmenuchanger",
                UseShellExecute = true
            };
            Process.Start(psInfo);
        }
       
        
        
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
           
        }

        private void installSwitchHomebrewToolStripMenuItem_Click(object sender, EventArgs e)//switch  sd setup
        {
            
        }

        private void gBATempToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)//other file to click
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {

                    filePath = openFileDialog.FileName;


                    var fileStream = openFileDialog.OpenFile();


                }
            }
        }

        

        private void sdsetupcomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProcessStartInfo psInfo1 = new ProcessStartInfo
            {
                FileName = "https://www.sdsetup.com/",
                UseShellExecute = true
            };
            Process.Start(psInfo1);
        }
        private void switchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProcessStartInfo psInfo2 = new ProcessStartInfo
            {
                FileName = "https://gbatemp.net/forums/nintendo-switch.283/?prefix_id=50",
                UseShellExecute = true
            };
            Process.Start(psInfo2);
        }
        private void switchHmbrewGuideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProcessStartInfo psInfo3= new ProcessStartInfo
            {
                FileName = "https://switch.homebrew.guide/index.html",
                UseShellExecute = true
            };
            Process.Start(psInfo3);
        }

        private void emulationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProcessStartInfo psInfo4 = new ProcessStartInfo
            {
                FileName = "https://gbatemp.net/forums/nintendo-switch.283/?prefix_id=66",
                UseShellExecute = true
            };
            Process.Start(psInfo4);
        }

        private void rOMHacksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProcessStartInfo psInfo5 = new ProcessStartInfo
            {
                FileName = "https://gbatemp.net/forums/nintendo-switch.283/?prefix_id=56",
                UseShellExecute = true
            };
            Process.Start(psInfo5);
        }

        private void switchHmbrewWikiToolStripMenuItem_Click(object sender, EventArgs e)
        {
        
            ProcessStartInfo psInfo6 = new ProcessStartInfo
            {
                FileName = "https://switchbrew.org/wiki/Main_Page",
                UseShellExecute = true
            };
            Process.Start(psInfo6);
        }

        private void switchEmulationToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ProcessStartInfo psInfo7 = new ProcessStartInfo
            {
                FileName = "https://github.com/yuzu-emu/yuzu",
                UseShellExecute = true
            };
            Process.Start(psInfo7);
        }

        private void httpswwwpatreoncomyuzuteamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProcessStartInfo psInfo8 = new ProcessStartInfo
            {
                FileName = "https://www.patreon.com/yuzuteam",
                UseShellExecute = true
            };
            Process.Start(psInfo8);
        }

        private void httpsswitchhomebrewguidedonatehtmlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProcessStartInfo psInfo9 = new ProcessStartInfo
            {
                FileName = "https://switch.homebrew.guide/donate.html",
                UseShellExecute = true
            };
            Process.Start(psInfo9);
        }

        private void httpsgithubcomswitchbrewnxhbmenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProcessStartInfo psInfo10 = new ProcessStartInfo
            {
                FileName = "https://github.com/switchbrew/nx-hbmenu",
                UseShellExecute = true
            };
            Process.Start(psInfo10);
        }

        private void paypalmekermit00ToolStripMenuItem_Click(object sender, EventArgs e)
        {
       
            ProcessStartInfo psInfo11 = new ProcessStartInfo
            {
                FileName = " https://www.paypal.com/paypalme/kermit00",
                UseShellExecute = true
            };
            Process.Start(psInfo11);
        }
    }
}
