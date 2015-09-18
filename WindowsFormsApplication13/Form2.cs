using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
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
        int handle;
        L2Watcher watcher;
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
            watcher = new L2Watcher("L2.bin");
            watcher.Add += new L2Watcher.WatcherHandler(onProcessesAdd);
            watcher.Remove += new L2Watcher.WatcherHandler(onProcessesRemove);
            
        }

        private void Form2_Shown(object sender, EventArgs e)
        {
            updateContextMenu();
        }

        public void onProcessesAdd(object sender, int updated_item)
        {
            updateContextMenu();
        }

        public void onProcessesRemove(object sender, int updated_item)
        {
            updateContextMenu();
            if (this.handle == updated_item)
            {
                labelProcessName.ForeColor = Color.Red;
            }
        }

        public void updateContextMenu()
        {
            this.Invoke(new Action(() => { 
                contextMenuStrip1.Items.Clear(); 
            }));
            if (watcher.processes.Count > 0)
            {
                foreach (Process process in watcher.processes.Values)
                {
                    this.Invoke(new Action(() => { 
                        ToolStripItem item = contextMenuStrip1.Items.Add(process.StartTime.ToString(), Properties.Resources.Lineage_II, new EventHandler(onContextClicked));
                        item.Tag = process.Id;
                    }));
                }
            }
            else
            {
                this.Invoke(new Action(() => {
                    ToolStripItem item = contextMenuStrip1.Items.Add("Запущенных процессов не найдено");
                    item.Enabled = false;
                }));
            }
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
            Tick(textBox5.Text);
        }

        private void MP_Tick(object sender, EventArgs e)
        {
            Tick(textBox6.Text);
        }

        private void GCP_Tick(object sender, EventArgs e)
        {
            Tick(textBox7.Text);
        }

        private void CP_Tick(object sender, EventArgs e)
        {
            Tick(textBox8.Text);
        }

        private void Tick(string key)
        {
            if (key[0] == 'F')
            {
                if (key.Length == 2)
                {
                    if (key[1] == '1') this.SendKey("F1");
                    if (key[1] == '2') this.SendKey("F2");
                    if (key[1] == '3') this.SendKey("F3");
                    if (key[1] == '4') this.SendKey("F4");
                    if (key[1] == '5') this.SendKey("F5");
                    if (key[1] == '6') this.SendKey("F6");
                    if (key[1] == '7') this.SendKey("F7");
                    if (key[1] == '8') this.SendKey("F8");
                    if (key[1] == '9') this.SendKey("F9");
                }
                if (key.Length == 3)
                {
                    if (key[2] == '0') this.SendKey("F10");
                    if (key[2] == '1') this.SendKey("F11");
                    if (key[2] == '2') this.SendKey("F12");
                }
            }
            c = int.TryParse(key, out forTry);
            if (c)
            {
                if (key.Length == 1)
                {
                    if (key[0] == '1') this.SendKey("1");
                    if (key[0] == '2') this.SendKey("2");
                    if (key[0] == '3') this.SendKey("3");
                    if (key[0] == '4') this.SendKey("4");
                    if (key[0] == '5') this.SendKey("5");
                    if (key[0] == '6') this.SendKey("6");
                    if (key[0] == '7') this.SendKey("7");
                    if (key[0] == '8') this.SendKey("8");
                    if (key[0] == '9') this.SendKey("9");
                }
                if (textBox8.Text.Length == 2)
                {
                    if (key[1] == '0') this.SendKey("0");
                    if (key[1] == '1') this.SendKey("-");
                    if (key[1] == '2') this.SendKey("=");
                }
            }
        }

        private void SendKey(string key)
        {
            try
            {
                SendKeysCustom.Send(this.handle, key);
            }
            catch
            {
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

        private void onContextClicked(object sender, EventArgs e)
        {
            ToolStripItem item = sender as ToolStripItem;
            this.handle = (int)item.Tag;
            labelProcessName.Text = item.Text;
            labelProcessName.ForeColor = Color.Black;
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            watcher.Stop();
        }
    }
}
