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
    /// <summary>
    /// 작성자 :   박진수
    /// 작성일 :   04-26 14:33
    /// 수정내용 : bgwWorker_dowork(34라인부터) 조건 do-while문 로직 수정
    /// </summary>
    public partial class Prof : Form
    {
        public int StudentLimit { get; set; } = 0;
        public Prof()
        {
            InitializeComponent();
        }
        //NewThread
        private void Prof_Load(object sender, EventArgs e)
        {
            bgwWorker.RunWorkerAsync();
        }
        bool workable = true;
        private void bgwWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            do
            {
                //TimeCount 테이블 전체 쿼리
                List<TimeCount> timecount = DataRepository.TimeCount.GetAll(null);
                //TimeLimit_key 쿼리
                Setting setting = DataRepository.Setting.GetFirst(null);

                int Hands = 0;
                //TimeLimit_Key보다 분이 작게 나오면 손든걸로 취급해 카운트
                foreach (TimeCount x in timecount)
                {
                    if ((DateTime.Now - x.SetTime).Minutes <= setting.TimeLimit_Key)
                        Hands++;
                }
                //카운트한 숫자가 학생 하한보다 크면 하단 실행
                if (Hands >= StudentLimit)
                {
                    bgwWorker.ReportProgress(0);
                }
                Thread.Sleep(3000);
            }
            while (workable == true);
            
        }
        //baseThread
        private void CallAlarm()
        {
            if (Properties.Settings.Default.Mute == false)
            {
                Forms.Alarm alarm = new Forms.Alarm();
                Debug.WriteLine("CallAlarm");
                alarm.Show();
            }
        }
        private void bgwWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //TimeCount 테이블 초기화
            DataRepository.TimeCount.DeleteAll();
            //알람폼 호출!
            Forms.Alarm alarm = new Forms.Alarm();
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
