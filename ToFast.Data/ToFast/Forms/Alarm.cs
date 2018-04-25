using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToFast.Forms
{
    public partial class Alarm : Form
    {
        public Alarm()
        {
            InitializeComponent();
            this.Location = new Point(Screen.PrimaryScreen.Bounds.Width - this.Width,
                                      Screen.PrimaryScreen.Bounds.Height - this.Height);
            this.FormBorderStyle = FormBorderStyle.None;
        }
        private void Alarm_Load(object sender, EventArgs e)
        {
            Debug.WriteLine("먀");
            this.bgwCallAlarm.RunWorkerAsync();
        }
        private void bgwCallAlarm_DoWork(object sender, DoWorkEventArgs e)
        {
            Debug.WriteLine("알람 떴니");
            Thread.Sleep(3000);
        }
        private void bgwCallAlarm_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Debug.WriteLine("끈다?");
            Close();
        }
    }
}
