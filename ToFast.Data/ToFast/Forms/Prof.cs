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
    /// 작성일 :   04-24 15:50
    /// 수정내용 : 백그라운드 신설(bgwWorker), 백그라운드 내에서 알람조건 검사
    /// </summary>
    public partial class Prof : Form
    {
        public Prof()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 작성자 :   대한
        /// 작성일 :   04-27 10:18
        /// 수정내용 : StudentRequestDelete() - 학생 요청이 온 QuestionIndex를 하루가 지나면 삭제 시킨다.
        ///           ExpiresDelete() - 7일이 지나간 QuestionIndex를 무조건 삭제 시킨다.
        ///           RunWorkerAsync - 알람을 폴링 해주는 백그라운드 워커가 동작된다.
        /// </summary>
        private void Prof_Load(object sender, EventArgs e)
        {
            if (DesignMode)
                return;
            // 데이터 그리드 뷰를 채운다.
            List<QuestionIndex> questionViews = DataRepository.QuestionIndex.GetQuestionViewProfAll();

            StudentRequestDelete(questionViews);
            ExpiresDelete(questionViews);

            dgvProfContents.DataSource = questionViews;
            bgwWorker.RunWorkerAsync();
        }

        private void StudentRequestDelete(List<QuestionIndex> questionViews)
        {
            DateTime now = DateTime.Today;
            List<QuestionIndex> delList = questionViews.Where(x => x.Deletable).ToList();
            delList = delList.Where(x => (now.DayOfYear - x.QuestionTime.DayOfYear) >= 1).ToList();
            DataRepository.QuestionIndex.DeleteRange(delList: delList);
        }

        private void ExpiresDelete(List<QuestionIndex> questionViews)
        {
            DateTime now = DateTime.Today;
            List<QuestionIndex> delList = questionViews.Where(x => (now.DayOfYear - x.QuestionTime.DayOfYear) > 7).ToList();
            DataRepository.QuestionIndex.DeleteRange(delList: delList);
        }

        /// <summary>
        /// 작성자 :   대한
        /// 작성일 :   04-27 10:18
        /// 수정내용 : CancelAsync - 폼이 종료되면 백그라운드 워커를 종료 시킨다.
        /// </summary>
        private void Prof_FormClosed(object sender, FormClosedEventArgs e)
        {
            bgwWorker.CancelAsync();
        }

        private void pictureboxSetting_Click(object sender, EventArgs e)
        {
            ProfSetting pSetting = new ProfSetting();
            pSetting.Show();
        }


        private void dgvProfContents_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView gridView = (DataGridView) sender;
            if(gridView.Rows[0].Cells[0].Value.ToString() == "0")
                return;
            QuestionView questionView = new QuestionView
            {
                NO = (int) gridView.Rows[e.RowIndex].Cells[0].Value,
                Name = gridView.Rows[e.RowIndex].Cells[1].Value.ToString(),
                Time = DateTime.Parse(gridView.Rows[e.RowIndex].Cells[2].Value.ToString()),
                Content = gridView.Rows[e.RowIndex].Cells[3].Value.ToString()
            };
            MSGDetail msg = new MSGDetail(questionView);
            msg.Show();
        }

        private void bgwWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            Debug.WriteLine("bgwWorker_DoWork");
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
                if (Hands >= Properties.Settings.Default.StudentLimit)
                {
                    bgwWorker.ReportProgress(0);
                }
                Thread.Sleep(3000);
            }
            while (!bgwWorker.CancellationPending);
        }

        //baseThread
        private void CallAlarm()
        {
            if (Properties.Settings.Default.Mute == false)
            {
                Forms.Alarm alarm = new Forms.Alarm();
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
//        private void bgwWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
//        {
//        }
    }
}