using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace PrettyClick
{
    public partial class ScreenshotForm : Form
    {
        System.Timers.Timer time;
        public int Duration = 1;
        
        public ScreenshotForm()
        {
            InitializeComponent();
        }

        private void ScreenshotForm_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            time = new System.Timers.Timer(1000.0/60);
            time.Elapsed += (a, b) => 
            {
                this.Invoke(new Action(() => { 
                    this.Opacity -= 1.0 / 60 / Duration; 
                    if (this.Opacity <= 0.3) 
                    { 
                        time.Stop(); 
                        this.Close(); 
                    } 
                }));
            };
            time.Start();
        }

        private void ScreenshotForm_Click(object sender, EventArgs e)
        {
            time.Stop();
            this.Close(); 
        }
    }
}
