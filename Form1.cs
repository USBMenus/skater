using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Memory;
using System.Threading;

namespace skater
{
    public partial class Form1 : Form
    {
        public Mem mem = new Mem();
        public string on = "1";
        public string off = "0";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            checkGame();
        }

        void checkGame()
        {
            Process[] proc = Process.GetProcessesByName("Skate.crack");
            if (proc.Length == 1)
            {
                mem.OpenProcess(Process.GetProcessesByName("Skate.crack").FirstOrDefault().Id);
                statusInfoLabel.Text = "Attached";
                statusInfoLabel.ForeColor = Color.Green;
                attachErrLabel.Text = "Successfully Attached";
                attachErrLabel.Location = new Point(422, attachErrLabel.Location.Y);
                enableAll();
            }
            else if (proc.Length == 0)
            {
                statusInfoLabel.Text = "Not Attached";
                statusInfoLabel.ForeColor = Color.Red;
                attachErrLabel.Text = "No Instances Detected";
                attachErrLabel.Location = new Point(415, attachErrLabel.Location.Y);
                disableAll();
            } else
            {
                statusInfoLabel.Text = "Not Attached";
                statusInfoLabel.ForeColor = Color.Red;
                attachErrLabel.Text = "Too Many Instances Detected";
                attachErrLabel.Location = new Point(381,attachErrLabel.Location.Y);
                disableAll();
            }
        }

        private void checkBox1_CheckedChanged_2(object sender, EventArgs e)
        {
            
        }

        public void wait(int milliseconds)
        {
            var timer1 = new System.Windows.Forms.Timer();
            if (milliseconds == 0 || milliseconds < 0) return;

            timer1.Interval = milliseconds;
            timer1.Enabled = true;
            timer1.Start();

            timer1.Tick += (s, e) =>
            {
                timer1.Enabled = false;
                timer1.Stop();
            };

            while (timer1.Enabled)
            {
                Application.DoEvents();
            }
        }

        private void rainbowHueSlider_Scroll(object sender, ScrollEventArgs e)
        {
            rainbowHueUD.Value = rainbowHueTB.Value;
        }

        private void guna2NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            rainbowHueTB.Value = Convert.ToInt32(rainbowHueUD.Value);
        }

        private void guna2NumericUpDown1_ValueChanged_1(object sender, EventArgs e)
        {
            fovTB.Value = Convert.ToInt32(fovUD.Value);
            mem.WriteMemory("Skate.crack.exe+08135380,40,80C", "float", fovUD.Value.ToString());
        }

        private void fovTS_CheckedChanged(object sender, EventArgs e)
        {
            if (fovTS.Checked)
            {
                fovUD.Enabled = true;
                fovTB.Enabled = true;
            }
            else
            {
                fovUD.Enabled = false;
                fovTB.Enabled = false;
            }
        }

        private void rainbowHueTS_CheckedChanged(object sender, EventArgs e)
        {
            if (rainbowHueTS.Checked)
            {
                rainbowHueTB.Enabled = true;
                rainbowHueUD.Enabled = true;
            }
            else
            {
                rainbowHueTB.Enabled = false;
                rainbowHueUD.Enabled = false;
            }
            if (rainbowHueTS.Checked)
                for (int i = 0; i < 360; i++)
                {
                    mem.WriteMemory("Skate.crack.exe+08411500,16C", "float", (rainbowHueUD.Value * i).ToString());
                    wait(1);
                    if (i == 359)
                        i = 0;
                    if (!rainbowHueTS.Checked)
                        break;
                }
            else
            {
                mem.WriteMemory("Skate.crack.exe+08411500,16C", "float", off);
            }
        }

        private void checkIfGameOpen_Tick(object sender, EventArgs e)
        {
            checkGame();
        }

        private void guna2ToggleSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            if (lockInAirTS.Checked)
                mem.WriteMemory("Skate.crack.exe+5618A20", "byte", on);
            else
                mem.WriteMemory("Skate.crack.exe+5618A20", "byte", off);
        }

        private void guna2TrackBar1_Scroll(object sender, ScrollEventArgs e)
        {
            this.Opacity = (double)opacityTB.Value/opacityTB.Maximum; 
        }

        private void guna2ToggleSwitch2_CheckedChanged(object sender, EventArgs e)
        {
            if (disableRagdollTS.Checked)
                mem.WriteMemory("Skate.crack.exe+53D4740", "byte", on);
            else
                mem.WriteMemory("Skate.crack.exe+53D4740", "byte", off);
        }

        private void disableWipeoutsTS_CheckedChanged(object sender, EventArgs e)
        {
            if (disableWipeoutsTS.Checked)
                mem.WriteMemory("Skate.crack.exe+56248D0", "byte", on);
            else
                mem.WriteMemory("Skate.crack.exe+56248D0", "byte", off);
        }

        private void guna2ToggleSwitch2_CheckedChanged_1(object sender, EventArgs e)
        {
            if (speedHackTS.Checked)
                mem.FreezeValue("Skate.crack.exe+084DAE50,40,20,8,A8", "float", on);
            else
                mem.UnfreezeValue("Skate.crack.exe+084DAE50,40,20,8,A8");
        }

        private void guna2ToggleSwitch1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (wireframeTS.Checked)
                mem.WriteMemory("Skate.crack.exe+08331A58,17C", "int", on);
            else
                mem.WriteMemory("Skate.crack.exe+08331A58,17C", "int", off);
        }

        private void guna2ToggleSwitch2_CheckedChanged_2(object sender, EventArgs e)
        {
            if (drawPlayersTS.Checked)
                mem.WriteMemory("Skate.crack.exe+5600D70", "byte", off);
            else
                mem.WriteMemory("Skate.crack.exe+5600D70", "byte", on);
        }

        private void sunRotationTS_CheckedChanged(object sender, EventArgs e)
        {
            if (sunRotationTS.Checked)
            {
                sunRotationTB.Enabled = true;
                sunRotationUD.Enabled = true;
            }
            else
            {
                sunRotationTB.Enabled = false;
                sunRotationUD.Enabled = false;
            }
        }

        private void sunRotationUD_ValueChanged(object sender, EventArgs e)
        {
            sunRotationTB.Value = Convert.ToInt32(sunRotationUD.Value);
                mem.WriteMemory("Skate.crack.exe+0565DF80,A0,28,24", "float", sunRotationUD.Value.ToString()); //X
                mem.WriteMemory("Skate.crack.exe+0565DF80,A0,28,28", "float", sunRotationUD.Value.ToString()); //Y
        }

        private void sunRotationTB_Scroll(object sender, ScrollEventArgs e)
        {
            sunRotationUD.Value = sunRotationTB.Value;
        }

        private void fovSlider_Scroll(object sender, ScrollEventArgs e)
        {
            fovUD.Value = Convert.ToInt32(fovTB.Value);
        }

        void enableAll()
        {
            fovTS.Enabled = true;
            rainbowHueTS.Enabled = true;
            sunRotationTS.Enabled = true;
            speedHackTS.Enabled = true;
            infJumpTS.Enabled = true;
            lockInAirTS.Enabled = true;
            wireframeTS.Enabled = true;
            disableRagdollTS.Enabled = true;
            disableWipeoutsTS.Enabled = true;
            drawPlayersTS.Enabled = true;
        }

        void disableAll()
        {
            fovTS.Enabled = false;
            rainbowHueTS.Enabled = false;
            sunRotationTS.Enabled = false;
            speedHackTS.Enabled = false;
            infJumpTS.Enabled = false;
            lockInAirTS.Enabled = false;
            wireframeTS.Enabled = false;
            disableRagdollTS.Enabled = false;
            disableWipeoutsTS.Enabled = false;
            drawPlayersTS.Enabled = false;
            fovUD.Enabled = false;
            sunRotationUD.Enabled = false;
            rainbowHueUD.Enabled = false;
        }

        private void infJumpTS_CheckedChanged(object sender, EventArgs e)
        {
            if (infJumpTS.Checked)
                mem.FreezeValue("Skate.crack.exe+084E5868,E30,190,3D9", "byte", "0");
            else
                mem.UnfreezeValue("Skate.crack.exe+084E5868,E30,190,3D9");
        }
    }
}
