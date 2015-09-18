using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication13
{
    public partial class Form4 : Form
    {
        //   Переменные для перетаскивания формы без рамок
        int for_dragging_X = 0, for_dragging_Y = 0;

        public Form4()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void Form4_MouseUp(object sender, MouseEventArgs e)
        {
            tmrDragging.Enabled = false;

        }

        private void Form4_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right || e.Button == MouseButtons.Left)
            {
                tmrDragging.Enabled = true;
                for_dragging_X = MousePosition.X - this.Location.X; for_dragging_Y = MousePosition.Y - this.Location.Y;
            }
        }

        private void tmrDragging_Tick(object sender, EventArgs e)
        {
            this.Location = new Point(MousePosition.X - for_dragging_X, MousePosition.Y - for_dragging_Y);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
