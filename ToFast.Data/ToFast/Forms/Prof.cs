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
using ToFast.Data;

namespace ToFast
{
    public partial class Prof : Form
    {
        public int SetNum { get; set; } = 0;
        public Prof()
        {
            InitializeComponent();
        }
        //NewThread
        private void Prof_Load(object sender, EventArgs e)
        {
        }
        bool workable = true;
        private void bgwWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            do
            {
                Setting setting = DataRepository.Setting.GetFirst(null);
                if (DataRepository.TimeCount.GetCount(x=>
                                                     (DateTime.Now - x.SetTime).Minutes <= setting.TimeLimit_Key)
                                                      >= SetNum)
                {
                    bgwWorker.ReportProgress(0);
                }
                Thread.Sleep(3000);
            }
            while (workable == false);
            
        }
        //baseThread
        private void CallAlarm()
        {
            Forms.Alarm alarm = new Forms.Alarm();
            Debug.WriteLine("CallAlarm");
            alarm.Show();
        }
        private void bgwWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //TimeCount 테이블 초기화
            DataRepository.TimeCount.DeleteAll();
            //알람폼 호출!
            Forms.Alarm alarm = new Forms.Alarm();
            alarm.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - alarm.Width,
                                       Screen.PrimaryScreen.WorkingArea.Height - alarm.Height);
            alarm.Show();
        }
        //EndThread
        private void bgwWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }

        private void Prof_FormClosing(object sender, FormClosingEventArgs e)
        {
            workable = false;
        }

    }
}
