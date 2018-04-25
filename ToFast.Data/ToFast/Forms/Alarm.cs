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
///<summary>
/// 작성자 :   박진수
/// 작성일 :   04-25 16:26
/// 수정내용 : 신설
///</summary>
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
            this.bgwCallAlarm.RunWorkerAsync();
        }
        private void bgwCallAlarm_DoWork(object sender, DoWorkEventArgs e)
        {
            Thread.Sleep(3000);
        }
        private void bgwCallAlarm_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Close();
        }
    }
}
