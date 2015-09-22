using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrettyClick
{
    public partial class HelpForm : Form
    {
        //   Переменные для перетаскивания формы без рамок
        int for_dragging_X = 0, for_dragging_Y = 0;

        // Переменные для таймеров
        int secret_count = 0;
        int seconds = 0;

        public HelpForm()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void btnMainmenu_Click(object sender, EventArgs e)
        {
            MainForm form2 = new MainForm();
            form2.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form3_MouseUp(object sender, MouseEventArgs e)
        {
            tmrDragging.Enabled = false;
        }

        private void Form3_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right || e.Button == MouseButtons.Left)
            {
                tmrDragging.Enabled = true;
                for_dragging_X = MousePosition.X - this.Location.X; for_dragging_Y = MousePosition.Y - this.Location.Y;
            }
        }

        private void tmrDragging_Tick_1(object sender, EventArgs e)
        {

            this.Location = new Point(MousePosition.X - for_dragging_X, MousePosition.Y - for_dragging_Y);
       
        }


        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
