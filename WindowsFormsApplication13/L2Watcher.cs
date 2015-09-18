using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Collections;
using System.Collections.Specialized;

namespace WindowsFormsApplication13
{
    public class L2Watcher
    {
        public event WatcherHandler Add;
        public event WatcherHandler Remove;
        public delegate void WatcherHandler(object sender, int updated_item);

        public OrderedDictionary processes;

        ManagementEventWatcher startWatch;
        ManagementEventWatcher stopWatch;
        string process_name;

        public L2Watcher(string process_name)
        {
            this.process_name = process_name;

            this.processes = new OrderedDictionary();
            Process[] processlist = Process.GetProcessesByName(process_name).OrderBy(process => process.StartTime).ToArray();
            foreach (Process process in processlist)
            {
                this.processes.Add(process.Id, process);
            }

            startWatch = new ManagementEventWatcher(
              new WqlEventQuery("SELECT * FROM Win32_ProcessStartTrace"));
            startWatch.EventArrived
                                += new EventArrivedEventHandler(startWatch_EventArrived);
            startWatch.Start();

            stopWatch = new ManagementEventWatcher(
              new WqlEventQuery("SELECT * FROM Win32_ProcessStopTrace"));
            stopWatch.EventArrived
                                += new EventArrivedEventHandler(stopWatch_EventArrived);
            stopWatch.Start();
        }

        void stopWatch_EventArrived(object sender, EventArrivedEventArgs e) 
        {
            if (e.NewEvent.Properties["ProcessName"].Value.ToString() == this.process_name)
            {
                int key = Int32.Parse(e.NewEvent.Properties["ProcessID"].Value.ToString());
                if (this.processes.Contains(key))
                {
                    this.processes.Remove(key);
                    if (Remove != null)
                    {
                        Remove(this, key);
                    }
                }
            }
        }

        void startWatch_EventArrived(object sender, EventArrivedEventArgs e) 
        {
            if (e.NewEvent.Properties["ProcessName"].Value.ToString() == this.process_name)
            {
                int key = Int32.Parse(e.NewEvent.Properties["ProcessID"].Value.ToString());
                this.processes.Add(key, Process.GetProcessById(key));
                if (Add != null)
                {
                    Add(this, key);
                }
            }
        }

        public void Stop()
        {
            stopWatch.Stop();
            startWatch.Stop();
        }

    }
}
