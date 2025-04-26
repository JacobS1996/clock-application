using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clock
{
    public partial class clockUserControl : UserControl
    {
        private static System.Timers.Timer timer = new System.Timers.Timer(1000);


        private string currentTime = DateTime.Now.ToString("hh:mm:ss tt");


        public clockUserControl()
        {
            InitializeComponent();
            clockLabel.Text = currentTime;
            RunClock();

        }

        private void RunClock()
        {
            timer.Elapsed += Timer_Elapsed;
            timer.AutoReset = true;
            timer.Enabled = true;
        }

        private void Timer_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
        {
            currentTime = DateTime.Now.ToString("hh:mm:ss tt");
            if(clockLabel.InvokeRequired)
            {
                Action cleanUpdate = delegate { UpdateClockLabel(currentTime); };
                clockLabel.Invoke(cleanUpdate);
            }
            else
            {
                UpdateClockLabel(currentTime);
            }
        }

        private void UpdateClockLabel(string newTime)
        {
            clockLabel.Text = newTime;
            Refresh();
        }

    }
}
