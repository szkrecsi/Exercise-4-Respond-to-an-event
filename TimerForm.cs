using System;
using System.Windows.Forms;

namespace TimerEvents
{
    public partial class TimerForm : Form
    {
        //Timer objects can be used to throw events after a specified number of milliseconds
        System.Windows.Forms.Timer timer;

        public TimerForm()
        {
            InitializeComponent();
        }

        private void Timer_Shown(object sender, EventArgs e)
        {
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }

        void timer_Tick(object sender, EventArgs e)
        {
            progressBar.Value += 10;
            if (progressBar.Value >= 100) timer.Stop();
        }
    }
}