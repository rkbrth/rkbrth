using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Diagnostics;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PrettyClick.Properties;
using Utilities;
using PrettyClick;

namespace PrettyClick
{
    public partial class ProcessControl : UserControl
    {
        public L2Watcher watcher
        {
            set 
            {
                value.Add += new L2Watcher.WatcherHandler(onProcessesAdd);
                value.Remove += new L2Watcher.WatcherHandler(onProcessesRemove);
                updateContextMenu(value);
            }
        }
        public bool Active
        {
            get
            {
                return _enabled;
            }
            set
            {
                this._enabled = value;
                foreach (AutoKey key in keys)
                {
                    key.Enabled = value;
                }
            }
        }

        AutoKey[] keys = new AutoKey[4];
        bool _enabled = false;
        int process_id = 0;
        globalKeyboardHook gkh;

        public ProcessControl()
        {
            InitializeComponent();

            keys[0] = new AutoKey(labelHotkey1.Text, (double)numericInterval1.Value);
            keys[1] = new AutoKey(labelHotkey2.Text, (double)numericInterval2.Value);
            keys[2] = new AutoKey(labelHotkey3.Text, (double)numericInterval3.Value);
            keys[3] = new AutoKey(labelHotkey4.Text, (double)numericInterval4.Value);

            gkh = new globalKeyboardHook();
            this.Disposed += ProcessControl_Disposed;

            gkh.HookedKeys.Add(Keys.End);
            gkh.KeyDown += new KeyEventHandler(gkh_KeyDown);

            this.btnHelp.Visible = false;
            // CHANGE
            // gkh.HookedKeys.Clear();
            // gkh.HookedKeys.Add(e.KeyCode);
        }

        void ProcessControl_Disposed(object sender, EventArgs e)
        {
            gkh.HookedKeys.Clear();
        }

        void gkh_KeyDown(object sender, KeyEventArgs e)
        {
            btnToggle.PerformClick();
        }

        public void trackLocation()
        {
            System.Timers.Timer t = new System.Timers.Timer(1000);
            t.Elapsed += (a, b) => 
            {
                
                Process p;
                try
                {
                    p = Process.GetProcessById(this.process_id);
                }
                catch { return; }

                ScreenCapture sc = new ScreenCapture();
                var position = sc.getWindowRect(p.MainWindowHandle);
                var form = this.Parent;
                form.Invoke(new Action(() => { form.Location = new Point(position.Left + position.Width - form.Width, position.Top); }));
            };
            t.Start();
        }

        public void onProcessesAdd(object sender, int updated_item)
        {
            updateContextMenu(sender as L2Watcher);
        }

        public void onProcessesRemove(object sender, int updated_item)
        {
            updateContextMenu(sender as L2Watcher);
            if (this.process_id == updated_item)
            {
                labelProcessName.ForeColor = Color.Red;
                this.process_id = 0;
                this.Invoke(new Action(() =>
                {
                    this.btnHelp.Visible = false;
                }));
                
            }
        }

        public void updateContextMenu(L2Watcher watcher)
        {
            this.Invoke(new Action(() =>
            {
                contextProcessSelector.Items.Clear();
            }));
            if (watcher.processes.Count > 0)
            {
                foreach (Process process in watcher.processes.Values)
                {
                    this.Invoke(new Action(() =>
                    {
                        ToolStripItem item = contextProcessSelector.Items.Add(process.StartTime.ToLongTimeString(), PrettyClick.Properties.Resources.Lineage_II, new EventHandler(onContextClicked));
                        item.Tag = process.Id;
                    }));
                }
            }
            else
            {
                this.Invoke(new Action(() =>
                {
                    ToolStripItem item = contextProcessSelector.Items.Add("Запущенных процессов не найдено");
                    item.Enabled = false;
                }));
            }
        }

        private void onContextClicked(object sender, EventArgs e)
        {
            ToolStripItem item = sender as ToolStripItem;
            this.process_id = (int)item.Tag;
            try
            {
                Process p = Process.GetProcessById(this.process_id);
            }
            catch
            {
                return;
            }
            foreach (AutoKey key in keys)
            {
                key.process_id = this.process_id;
            }
            labelProcessName.Text = item.Text;
            labelProcessName.ForeColor = Color.Black;
            btnHelp.Visible = true;
            trackLocation();
        }

        private void ProcessControl_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(250, 250, 250);
        }

        private void btnToggle_Click(object sender, EventArgs e)
        {
            this.Active = !this.Active;
            this.btnToggle.BackgroundImage = this.Active ? Resources.pause_circle__1_ : this.btnToggle.BackgroundImage = Resources.play_circle_outline;
        }

        private void picture1_Click(object sender, EventArgs e)
        {
            keys[0].Active = !keys[0].Active;
            //this.picture1.BackgroundImage = keys[0].Active ? Resources.HP : Resources.HP_off;
            this.picture1.Image = keys[0].Active ? null : Resources.stroke;
        }

        private void picture2_Click(object sender, EventArgs e)
        {
            keys[1].Active = !keys[1].Active;
            this.picture2.BackgroundImage = keys[1].Active ?  Resources.MP : Resources.MPoff;
        }

        private void picture3_Click(object sender, EventArgs e)
        {
            keys[2].Active = !keys[2].Active;
            this.picture3.BackgroundImage = keys[2].Active ? Resources.CP : Resources.CP_off;
        }

        private void picture4_Click(object sender, EventArgs e)
        {
            keys[3].Active = !keys[3].Active;
            this.picture4.BackgroundImage = keys[3].Active ? Resources.CP1 : Resources.CP1_off;
        }

        private void numericInterval_ValueChanged(object sender, EventArgs e)
        {
            int index;
            Int32.TryParse((sender as NumericUpDown).Tag.ToString(), out index);
            keys[index].Interval = (double)(sender as NumericUpDown).Value;
        }

        private void setHotkey(object sender, EventArgs e)
        {
            (sender as TextBox).BackColor = Color.White;
            string hotkey = (sender as TextBox).Text;
            int index;
            Int32.TryParse((sender as TextBox).Tag.ToString(), out index);
            if (!keys[index].setHotkey(hotkey))
            {
                (sender as TextBox).BackColor = Color.MistyRose;
            }
        }

        private void labelHotkey_Click(object sender, EventArgs e)
        {
            PrettyClick.KeySelect form = new PrettyClick.KeySelect();
            form.onKeyPress += (code) => 
            {
                int index;
                Int32.TryParse((sender as Label).Tag.ToString(), out index);
                (sender as Label).Text = code.ToString();
                if (!keys[index].setHotkey(code))
                {
                    (sender as Label).BackColor = Color.MistyRose;
                }
            };
            form.FormClosed += (a, b) => { this.Focus(); };
            form.TopMost = true;
            form.ShowDialog();
            form.Focus();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            Process p;
            try
            {
                p = Process.GetProcessById(this.process_id);
            }
            catch
            {
                return;
            }
            PrettyClick.ScreenCapture capture = new PrettyClick.ScreenCapture();
            PrettyClick.ScreenshotForm form = new PrettyClick.ScreenshotForm();
            Image screen = capture.CaptureWindow(p.MainWindowHandle);
            form.BackgroundImage = screen;
            form.Size = screen.Size;
            form.Duration = 2;
            form.StartPosition = FormStartPosition.Manual;
            form.Location = new Point(0, 0);
            form.ShowDialog();
        }
    }
}
