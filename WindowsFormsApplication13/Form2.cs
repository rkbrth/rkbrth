using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilities;

namespace WindowsFormsApplication13
{
    public partial class Form2 : Form
    {
        // Флаг с состоянием записи и состоянием TopMost
        bool is_writing = false;
        bool is_topmost = true;

        bool isHPactive = true;
        bool isMPactive = true;
        bool isGCPactive = true;
        bool isCPactive = true;
        //   Переменные для перетаскивания формы без рамок
        int for_dragging_X = 0, for_dragging_Y = 0;
        Form4 f4 = new Form4();

        globalKeyboardHook gkh;

        public Form2()
        {
            
            InitializeComponent();
            gkh = new globalKeyboardHook();
            this.ControlBox = false;
            TopMost = true;
            //this.FormBorderStyle = FormBorderStyle.None;
            textBox1.Text = "11000";
            textBox2.Text = "7000";
            textBox3.Text = "2000";
            textBox4.Text = "500";
        }
       
        private void btnTray_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            
                this.ShowInTaskbar = false;
                notifyIcon1.Visible = true;
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
            notifyIcon1.Visible = false; 
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form2_MouseUp(object sender, MouseEventArgs e)
        {
            tmrDragging.Enabled = false;
           
        }

        private void tmrDragging_Tick(object sender, EventArgs e)
        {
           this.Location = new Point(MousePosition.X-for_dragging_X,MousePosition.Y-for_dragging_Y);
        }

        private void btnMosttop_Click(object sender, EventArgs e)
        {
            if (is_topmost)
            {
                TopMost = false;
                is_topmost = false;
                this.btnMosttop.BackgroundImage = global::WindowsFormsApplication13.Properties.Resources.pin_off;
            }
            else
            {
                TopMost = true;
                this.btnMosttop.BackgroundImage = global::WindowsFormsApplication13.Properties.Resources.pin;
            }
        }

        private void Form2_MouseDown_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right || e.Button == MouseButtons.Left)
            {
                tmrDragging.Enabled = true;
                for_dragging_X = MousePosition.X - this.Location.X; for_dragging_Y = MousePosition.Y - this.Location.Y;
            }
        }
        bool isWorking = false;
        private void btnToggle_Click(object sender, EventArgs e)
        {
            if (isWorking)
            {
                HP.Stop();
                MP.Stop();
                GCP.Stop();
                CP.Stop();
                isWorking = false;
                this.btnToggle.BackgroundImage = global::WindowsFormsApplication13.Properties.Resources.play_circle_outline;
            }
            else
            {
                if (isHPactive)
                {
                    HP.Start();
                }
                if (isMPactive)
                {
                    MP.Start();
                }
                if (isGCPactive)
                {
                    GCP.Start();
                }
                if (isCPactive)
                {
                    CP.Start();
                }
                
                isWorking = true;
                this.btnToggle.BackgroundImage = global::WindowsFormsApplication13.Properties.Resources.pause_circle__1_;

            }
        }

        bool b = false;
        int forTry;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            b = int.TryParse(textBox1.Text, out forTry);
            if (b)
            {
                HP.Interval = int.Parse(textBox1.Text);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            b = int.TryParse(textBox2.Text, out forTry);
            if (b)
            {
                MP.Interval = int.Parse(textBox2.Text);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            b = int.TryParse(textBox3.Text, out forTry);
            if (b)
            {
                GCP.Interval = int.Parse(textBox3.Text);
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            b = int.TryParse(textBox4.Text, out forTry);
            if (b)
            {
                CP.Interval = int.Parse(textBox4.Text);
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            HP.Interval = 11000;
            textBox1.Text = "11000";
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            MP.Interval = 7000;
            textBox2.Text = "7000";
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            GCP.Interval = 2000;
            textBox3.Text = "2000";
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            CP.Interval = 500;
            textBox4.Text = "500";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (isHPactive)
            {
                isHPactive = false;
                HP.Stop();
                this.pictureBox1.BackgroundImage = global::WindowsFormsApplication13.Properties.Resources.HP_off;
            }
            else
            {
                isHPactive = true;
                this.pictureBox1.BackgroundImage = global::WindowsFormsApplication13.Properties.Resources.HP;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (isMPactive)
            {
                isMPactive = false;
                MP.Stop();
                this.pictureBox2.BackgroundImage = global::WindowsFormsApplication13.Properties.Resources.MPoff;
            }
            else
            {
                isMPactive = true;
                this.pictureBox2.BackgroundImage = global::WindowsFormsApplication13.Properties.Resources.MP;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (isGCPactive)
            {
                isGCPactive = false;
                GCP.Stop();
                this.pictureBox3.BackgroundImage = global::WindowsFormsApplication13.Properties.Resources.CP_off;
            }
            else
            {
                isGCPactive = true;
                this.pictureBox3.BackgroundImage = global::WindowsFormsApplication13.Properties.Resources.CP;
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (isCPactive)
            {
                isCPactive = false;
                CP.Stop();
                this.pictureBox4.BackgroundImage = global::WindowsFormsApplication13.Properties.Resources.CP1_off;
            }
            else
            {
                isCPactive = true;
                this.pictureBox4.BackgroundImage = global::WindowsFormsApplication13.Properties.Resources.CP1;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //f4.Show();
            textBox5.Focus();

        }
        bool c;
        private void HP_Tick(object sender, EventArgs e)
        {
            if (textBox5.Text[0] == 'F')
            {
                if (textBox5.Text.Length == 2)
                {
                    if (textBox5.Text[1] == '1') SendKeys.Send("{F1}");
                    if (textBox5.Text[1] == '2') SendKeys.Send("{F2}");
                    if (textBox5.Text[1] == '3') SendKeys.Send("{F3}");
                    if (textBox5.Text[1] == '4') SendKeys.Send("{F4}");
                    if (textBox5.Text[1] == '5') SendKeys.Send("{F5}");
                    if (textBox5.Text[1] == '6') SendKeys.Send("{F6}");
                    if (textBox5.Text[1] == '7') SendKeys.Send("{F7}");
                    if (textBox5.Text[1] == '8') SendKeys.Send("{F8}");
                    if (textBox5.Text[1] == '9') SendKeys.Send("{F9}");
                }
                if (textBox5.Text.Length == 3)
                {
                    if (textBox5.Text[2] == '0') SendKeys.Send("{F10}");
                    if (textBox5.Text[2] == '1') SendKeys.Send("{F11}");
                    if (textBox5.Text[2] == '2') SendKeys.Send("{F12}");
                }
            }
            c = int.TryParse(textBox5.Text, out forTry);
            if (c)
            {
                if (textBox5.Text.Length == 1)
                {
                    if (textBox5.Text[0] == '1') SendKeys.Send("{1}");
                    if (textBox5.Text[0] == '2') SendKeys.Send("{2}");
                    if (textBox5.Text[0] == '3') SendKeys.Send("{3}");
                    if (textBox5.Text[0] == '4') SendKeys.Send("{4}");
                    if (textBox5.Text[0] == '5') SendKeys.Send("{5}");
                    if (textBox5.Text[0] == '6') SendKeys.Send("{6}");
                    if (textBox5.Text[0] == '7') SendKeys.Send("{7}");
                    if (textBox5.Text[0] == '8') SendKeys.Send("{8}");
                    if (textBox5.Text[0] == '9') SendKeys.Send("{9}");
                }
                if (textBox5.Text.Length == 2)
                {
                    if (textBox5.Text[1] == '0') SendKeys.Send("{0}");
                    if (textBox5.Text[1] == '1') SendKeys.Send("{-}");
                    if (textBox5.Text[1] == '2') SendKeys.Send("{=}");
                }
            }
            
        }

        private void MP_Tick(object sender, EventArgs e)
        {
            if (textBox6.Text[0] == 'F')
            {
                if (textBox6.Text.Length == 2)
                {
                    if (textBox6.Text[1] == '1') SendKeys.Send("{F1}");
                    if (textBox6.Text[1] == '2') SendKeys.Send("{F2}");
                    if (textBox6.Text[1] == '3') SendKeys.Send("{F3}");
                    if (textBox6.Text[1] == '4') SendKeys.Send("{F4}");
                    if (textBox6.Text[1] == '5') SendKeys.Send("{F5}");
                    if (textBox6.Text[1] == '6') SendKeys.Send("{F6}");
                    if (textBox6.Text[1] == '7') SendKeys.Send("{F7}");
                    if (textBox6.Text[1] == '8') SendKeys.Send("{F8}");
                    if (textBox6.Text[1] == '9') SendKeys.Send("{F9}");
                }
                if (textBox6.Text.Length == 3)
                {
                    if (textBox6.Text[2] == '0') SendKeys.Send("{F10}");
                    if (textBox6.Text[2] == '1') SendKeys.Send("{F11}");
                    if (textBox6.Text[2] == '2') SendKeys.Send("{F12}");
                }
            }
            c = int.TryParse(textBox6.Text, out forTry);
            if (c)
            {
                if (textBox6.Text.Length == 1)
                {
                    if (textBox6.Text[0] == '1') SendKeys.Send("{1}");
                    if (textBox6.Text[0] == '2') SendKeys.Send("{2}");
                    if (textBox6.Text[0] == '3') SendKeys.Send("{3}");
                    if (textBox6.Text[0] == '4') SendKeys.Send("{4}");
                    if (textBox6.Text[0] == '5') SendKeys.Send("{5}");
                    if (textBox6.Text[0] == '6') SendKeys.Send("{6}");
                    if (textBox6.Text[0] == '7') SendKeys.Send("{7}");
                    if (textBox6.Text[0] == '8') SendKeys.Send("{8}");
                    if (textBox6.Text[0] == '9') SendKeys.Send("{9}");
                }
                if (textBox6.Text.Length == 2)
                {
                    if (textBox6.Text[1] == '0') SendKeys.Send("{0}");
                    if (textBox6.Text[1] == '1') SendKeys.Send("{-}");
                    if (textBox6.Text[1] == '2') SendKeys.Send("{=}");
                }
            }
        }

        private void GCP_Tick(object sender, EventArgs e)
        {
            if (textBox7.Text[0] == 'F')
            {
                if (textBox7.Text.Length == 2)
                {
                    if (textBox7.Text[1] == '1') SendKeys.Send("{F1}");
                    if (textBox7.Text[1] == '2') SendKeys.Send("{F2}");
                    if (textBox7.Text[1] == '3') SendKeys.Send("{F3}");
                    if (textBox7.Text[1] == '4') SendKeys.Send("{F4}");
                    if (textBox7.Text[1] == '5') SendKeys.Send("{F5}");
                    if (textBox7.Text[1] == '6') SendKeys.Send("{F6}");
                    if (textBox7.Text[1] == '7') SendKeys.Send("{F7}");
                    if (textBox7.Text[1] == '8') SendKeys.Send("{F8}");
                    if (textBox7.Text[1] == '9') SendKeys.Send("{F9}");
                }
                if (textBox7.Text.Length == 3)
                {
                    if (textBox7.Text[2] == '0') SendKeys.Send("{F10}");
                    if (textBox7.Text[2] == '1') SendKeys.Send("{F11}");
                    if (textBox7.Text[2] == '2') SendKeys.Send("{F12}");
                }
            }
            c = int.TryParse(textBox7.Text, out forTry);
            if (c)
            {
                if (textBox7.Text.Length == 1)
                {
                    if (textBox7.Text[0] == '1') SendKeys.Send("{1}");
                    if (textBox7.Text[0] == '2') SendKeys.Send("{2}");
                    if (textBox7.Text[0] == '3') SendKeys.Send("{3}");
                    if (textBox7.Text[0] == '4') SendKeys.Send("{4}");
                    if (textBox7.Text[0] == '5') SendKeys.Send("{5}");
                    if (textBox7.Text[0] == '6') SendKeys.Send("{6}");
                    if (textBox7.Text[0] == '7') SendKeys.Send("{7}");
                    if (textBox7.Text[0] == '8') SendKeys.Send("{8}");
                    if (textBox7.Text[0] == '9') SendKeys.Send("{9}");
                }
                if (textBox7.Text.Length == 2)
                {
                    if (textBox7.Text[1] == '0') SendKeys.Send("{0}");
                    if (textBox7.Text[1] == '1') SendKeys.Send("{-}");
                    if (textBox7.Text[1] == '2') SendKeys.Send("{=}");
                }
            }
        }

        private void CP_Tick(object sender, EventArgs e)
        {
            if (textBox8.Text[0] == 'F')
            {
                if (textBox8.Text.Length == 2)
                {
                    if (textBox8.Text[1] == '1') SendKeys.Send("{F1}");
                    if (textBox8.Text[1] == '2') SendKeys.Send("{F2}");
                    if (textBox8.Text[1] == '3') SendKeys.Send("{F3}");
                    if (textBox8.Text[1] == '4') SendKeys.Send("{F4}");
                    if (textBox8.Text[1] == '5') SendKeys.Send("{F5}");
                    if (textBox8.Text[1] == '6') SendKeys.Send("{F6}");
                    if (textBox8.Text[1] == '7') SendKeys.Send("{F7}");
                    if (textBox8.Text[1] == '8') SendKeys.Send("{F8}");
                    if (textBox8.Text[1] == '9') SendKeys.Send("{F9}");
                }
                if (textBox5.Text.Length == 3)
                {
                    if (textBox8.Text[2] == '0') SendKeys.Send("{F10}");
                    if (textBox8.Text[2] == '1') SendKeys.Send("{F11}");
                    if (textBox8.Text[2] == '2') SendKeys.Send("{F12}");
                }
            }
            c = int.TryParse(textBox8.Text, out forTry);
            if (c)
            {
                if (textBox8.Text.Length == 1)
                {
                    if (textBox8.Text[0] == '1') SendKeys.Send("{1}");
                    if (textBox8.Text[0] == '2') SendKeys.Send("{2}");
                    if (textBox8.Text[0] == '3') SendKeys.Send("{3}");
                    if (textBox8.Text[0] == '4') SendKeys.Send("{4}");
                    if (textBox8.Text[0] == '5') SendKeys.Send("{5}");
                    if (textBox8.Text[0] == '6') SendKeys.Send("{6}");
                    if (textBox8.Text[0] == '7') SendKeys.Send("{7}");
                    if (textBox8.Text[0] == '8') SendKeys.Send("{8}");
                    if (textBox8.Text[0] == '9') SendKeys.Send("{9}");
                }
                if (textBox8.Text.Length == 2)
                {
                    if (textBox8.Text[1] == '0') SendKeys.Send("{0}");
                    if (textBox8.Text[1] == '1') SendKeys.Send("{-}");
                    if (textBox8.Text[1] == '2') SendKeys.Send("{=}");
                }
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            gkh.HookedKeys.Add(Keys.End);
            gkh.KeyDown += new KeyEventHandler(gkh_KeyDown);
        }

        void gkh_KeyDown(object sender, KeyEventArgs e)
        {
            btnToggle.PerformClick();
            e.Handled = true;
        }

        private void textBox5_KeyDown(object sender, KeyEventArgs e)
        {
            textBox5.Text = e.KeyCode.ToString();
            gkh.HookedKeys.Clear();
            gkh.HookedKeys.Add(e.KeyCode);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (!isWorking)
            {
                pictureBox10.Location = new Point(-10, -30);
                button6.Focus();
            } 
        }

        private void button6_KeyDown(object sender, KeyEventArgs e)
        {
            if (!isWorking)
            {
                gkh.HookedKeys.Clear();
                gkh.HookedKeys.Add(e.KeyCode);
                label4.Text = "Hotkey: " + e.KeyCode.ToString();
                pictureBox10.Location = new Point(1000, 3000);
                label4.Focus();
            }
            
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            gkh.HookedKeys.Clear();
            gkh.HookedKeys.Add(Keys.End);
            label4.Text = "Hotkey: End";
            label4.Focus();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        } 
    }
}
