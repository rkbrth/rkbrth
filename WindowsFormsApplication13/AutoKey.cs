using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Timers;

namespace WindowsFormsApplication13
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

        private Timer timer;
        private int _scan_code;
        private string _hotkey;
        private bool _enabled;

        public AutoKey()
        {
            this.timer = new System.Timers.Timer();
            this.timer.Elapsed += timer_Elapsed;
            this.Active = true;
        }

        public AutoKey(string hotkey, double interval)
        {
            this.timer = new Timer();
            this.timer.Elapsed += timer_Elapsed;
            this.Interval = interval;
            this.setHotkey(hotkey);
            this.Active = true;
        }

        public bool setHotkey(string key)
        {
            this._hotkey = key;
            return SendKeysCustom.tryParse(key, out _scan_code);
        }

        void timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            if (Active)
                SendKeysCustom.Send(this.process_id, this._scan_code);
        }
    }
}
