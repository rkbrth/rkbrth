using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace PrettyClick
{
    class AutoKey
    {
        public int process_id;

        public double Interval 
        {
            get 
            {
                return timer.Interval;
            }
            set 
            {
                timer.Interval = value;
            }
        }

        public bool Enabled
        {
            get
            {
                return _enabled;
            }
            set
            {
                _enabled = value;
                if (value)
                    timer.Start();
                else
                    timer.Stop();
            }
        }

        public bool Active;

        private System.Timers.Timer timer;
        private int _scan_code;
        private bool _enabled;

        public AutoKey()
        {
            this.timer = new System.Timers.Timer();
            this.timer.Elapsed += timer_Elapsed;
            this.Active = true;
        }

        public AutoKey(string hotkey, double interval)
        {
            this.timer = new System.Timers.Timer();
            this.timer.Elapsed += timer_Elapsed;
            this.Interval = interval;
            this.setHotkey(hotkey);
            this.Active = true;
        }

        public bool setHotkey(string key)
        {
            return SendKeysCustom.tryParse(key, out _scan_code);
        }

        public bool setHotkey(Keys key)
        {
            _scan_code = (int)key;
            return true;
        }

        void timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            try
            {
                if (Active)
                    SendKeysCustom.Send(this.process_id, this._scan_code);
            }
            catch
            {
            }
        }
    }
}
