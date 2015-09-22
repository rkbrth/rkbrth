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
    public partial class KeySelect : Form
    {
        public event ClickHandler onKeyPress;
        public delegate void ClickHandler(Keys charCode);

        public KeySelect()
        {
            InitializeComponent();
        }

        private void KeySelect_KeyDown(object sender, KeyEventArgs e)
        {
            if (onKeyPress != null)
            {
                onKeyPress(e.KeyCode);
            }
            this.Close();
        }
    }
}
