using System;
using System.Collections.Generic;
using System.Threading;
using ToFast.Data;
using ToFast.Forms;

namespace ToFast
{
    public partial class TrayProfIcon : TrayIcon
    {
        public TrayProfIcon()
        {
            InitializeComponent();
        }
        //baseThread
        private void CallAlarm()
        {
            if (Properties.Settings.Default.Mute == false)
            {
                if (new Alarm().OneFormShow() is Alarm alarm)
                    alarm.Show();
            }
        }
        public override void TrayIcon_Load()
        {
            if (DesignMode)
                return;
            MainFormShow();
        }

        public override void MainFormShow()
        {
            if (new Prof().OneFormShow() is Prof form)
                form.Show();
        }

        public override void Worker_DoWork()
        {

            do
            {
                //TimeCount 테이블 전체 쿼리
                List<TimeCount> timecount = DataRepository.TimeCount.GetAll(null);
                //TimeLimit_key 쿼리
                Setting setting = DataRepository.Setting.GetFirst(null);

                int hands = 0;
                //TimeLimit_Key보다 분이 작게 나오면 손든걸로 취급해 카운트
                foreach (var x in timecount)
                {
                    if ((DateTime.Now - x.SetTime).Minutes <= setting.TimeLimit_Key)
                        hands++;
                }
                //카운트한 숫자가 학생 하한보다 크면 하단 실행
                if (hands >= Properties.Settings.Default.StudentLimit)
                {
                    bgwWorker.ReportProgress(0);
                }
                Thread.Sleep(3000);
            }
            while (!bgwWorker.CancellationPending);
        }

        public override void Worker_ProgressChanged()
        {
            //TimeCount 테이블 초기화
            DataRepository.TimeCount.DeleteAll();
            //알람폼 호출!
            CallAlarm();
        }
    }
}
