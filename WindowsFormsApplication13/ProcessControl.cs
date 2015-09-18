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
using WindowsFormsApplication13.Properties;
using Utilities;

namespace WindowsFormsApplication13
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
        int process_id;
        globalKeyboardHook gkh;

        public ProcessControl()
        {
            InitializeComponent();

            keys[0] = new AutoKey(textHotkey1.Text, (double)numericInterval1.Value);
            keys[1] = new AutoKey(textHotkey2.Text, (double)numericInterval2.Value);
            keys[2] = new AutoKey(textHotkey3.Text, (double)numericInterval3.Value);
            keys[3] = new AutoKey(textHotkey4.Text, (double)numericInterval4.Value);

            gkh = new globalKeyboardHook();
            this.Disposed += ProcessControl_Disposed;

            gkh.HookedKeys.Add(Keys.End);
            gkh.KeyDown += new KeyEventHandler(gkh_KeyDown);

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
                        ToolStripItem item = contextProcessSelector.Items.Add(process.StartTime.ToString(), Properties.Resources.Lineage_II, new EventHandler(onContextClicked));
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
            foreach (AutoKey key in keys)
            {
                key.process_id = this.process_id;
            }
            labelProcessName.Text = item.Text;
            labelProcessName.ForeColor = Color.Black;
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
            this.picture1.BackgroundImage = keys[0].Active ? Resources.HP : Resources.HP_off;
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
    }
}
