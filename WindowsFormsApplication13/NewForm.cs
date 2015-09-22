using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Specialized;
using PrettyClick;

namespace PrettyClick
{
    public partial class NewForm : Form
    {
        public OrderedDictionary forms = new OrderedDictionary();
        public L2Watcher watcher;
        public NewForm()
        {
            InitializeComponent();
        }

        private void NewForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            watcher.Stop();
            if (notifyIcon1 != null)
            {
                notifyIcon1.Visible = false;
                notifyIcon1.Icon = null;
                notifyIcon1.Dispose();
            }
        }

        private void NewForm_Load(object sender, EventArgs e)
        {
            watcher = new L2Watcher("L2.bin");
            watcher.Add += watcher_Add;
            watcher.Remove += watcher_Remove;
        }

        void watcher_Remove(object sender, int updated_item)
        {

        }

        void watcher_Add(object sender, int updated_item)
        {
            //MainForm m = 
            //forms.Add
        }

        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
