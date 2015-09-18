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

        //   Переменные для перетаскивания формы без рамок
        int for_dragging_X = 0, for_dragging_Y = 0;
        public L2Watcher watcher;
        Form4 f4 = new Form4();

        public Form2()
        {
            
            InitializeComponent();
            this.ControlBox = false;
            TopMost = true;
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

        private void Form2_Load(object sender, EventArgs e)
        {
            watcher = new L2Watcher("L2.bin");
            this.processControl1.watcher = watcher;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //if (!isWorking)
            //{
            //    pictureBox10.Location = new Point(-10, -30);
            //    button6.Focus();
            //} 
        }

        private void button6_KeyDown(object sender, KeyEventArgs e)
        {
            //if (!isWorking)
            //{
            //    gkh.HookedKeys.Clear();
            //    gkh.HookedKeys.Add(e.KeyCode);
            //    label4.Text = "Hotkey: " + e.KeyCode.ToString();
            //    pictureBox10.Location = new Point(1000, 3000);
            //    label4.Focus();
            //}
            
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            //gkh.HookedKeys.Clear();
            //gkh.HookedKeys.Add(Keys.End);
            //label4.Text = "Hotkey: End";
            //label4.Focus();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            watcher.Stop();
        }
    }
}
