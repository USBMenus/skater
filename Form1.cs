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
        Process[] proc = Process.GetProcessesByName("Skate.crack");

        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (fixSkateboardCB.Checked)
                mem.WriteMemory("Skate.crack.exe+5618A20", "byte", on);
            else
                mem.WriteMemory("Skate.crack.exe+5618A20", "byte", off);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            boardSpeedTimer.Stop();
            checkGame();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            mem.WriteMemory("Skate.crack.exe+084DAE50,40,20,8,A8", "float", boardSpeedUD.Value.ToString());
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                boardSpeedTimer.Start();
                boardSpeedUD.Enabled = true;
            }
            else
            {
                boardSpeedTimer.Stop();
                boardSpeedUD.Enabled = false;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (disableRogdollCB.Checked)
                mem.WriteMemory("Skate.crack.exe+53D4740", "byte", on);
            else
                mem.WriteMemory("Skate.crack.exe+53D4740", "byte", off);
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (disableWipeoutsCB.Checked)
                mem.WriteMemory("Skate.crack.exe+56248D0", "byte", on);
            else
                mem.WriteMemory("Skate.crack.exe+56248D0", "byte", off);
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            mem.WriteMemory("Skate.crack.exe+08135380,40,80C", "float", fovUD.Value.ToString());
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            mem.WriteMemory("Skate.crack.exe+0565DF80,A0,28,24", "float", sunRotationXUD.Value.ToString());
        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {
            mem.WriteMemory("Skate.crack.exe+0565DF80,A0,28,28", "float", sunRotationYUD.Value.ToString());
        }

        void checkGame()
        {
            if (proc.Length == 1)
            {
                mem.OpenProcess(Process.GetProcessesByName("Skate.crack").FirstOrDefault().Id);
                MessageBox.Show("Successfully attached to skate", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (proc.Length == 0)
            {
                MessageBox.Show("No instances detected\nMake sure the game is running", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            } else
            {
                MessageBox.Show("Too many instances detected \nMake sure you only have one game open", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (wireframeCB.Checked)
                wireframeUD.Enabled = true;
            else
                wireframeUD.Enabled = false;
        }

        private void fovCB_CheckedChanged(object sender, EventArgs e)
        {
            if (fovCB.Checked)
                fovUD.Enabled = true;
            else
                fovUD.Enabled = false;
        }

        private void wireframeUD_ValueChanged(object sender, EventArgs e)
        {
            mem.WriteMemory("Skate.crack.exe+08331A58,17C", "int", wireframeUD.Value.ToString());
        }

        private void checkBox1_CheckedChanged_2(object sender, EventArgs e)
        {
            if (drawSkinnedCB.Checked)
            mem.WriteMemory("Skate.crack.exe+5600D70", "byte", off);
            else
            mem.WriteMemory("Skate.crack.exe+5600D70", "byte", on);
        }

        private void numericUpDown4_ValueChanged_1(object sender, EventArgs e)
        {
            mem.WriteMemory("Skate.crack.exe+08411500,16C", "float", numericUpDown4.Value.ToString());
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            mem.WriteMemory("Skate.crack.exe+08411500,40", "float", satXUD.Value.ToString());
        }

        private void satYUD_ValueChanged(object sender, EventArgs e)
        {
            mem.WriteMemory("Skate.crack.exe+08411500,44", "float", satYUD.Value.ToString());
        }

        private void satZUD_ValueChanged(object sender, EventArgs e)
        {
            mem.WriteMemory("Skate.crack.exe+08411500,48", "float", satZUD.Value.ToString());
        }

        private void checkBox1_CheckedChanged_3(object sender, EventArgs e)
        {
            if (rainbowCB.Checked)
                for (int i = 0; i < 360; i++)
                {
                    mem.WriteMemory("Skate.crack.exe+08411500,16C", "float", (rainbowUD.Value*i).ToString());
                    wait(1);
                    if (i == 359)
                        i = 0;
                    if (!rainbowCB.Checked)
                        break;
                }
            else
                mem.WriteMemory("Skate.crack.exe+08411500,16C", "float", off);
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

        private void consoleCB_CheckedChanged(object sender, EventArgs e)
        {
            if (consoleCB.Checked)
                mem.WriteMemory("Skate.crack.exe+08324788,8", "byte", on);
            else
                mem.WriteMemory("Skate.crack.exe+08324788,8", "byte", off);
        }

        private void rainbowUD_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
