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
        public int StudentLimit { get; set; } = 0;
        public Prof()
        {
            InitializeComponent();
        }
        bool workable = true;
        private void bgwWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            do
            {
                Setting setting = DataRepository.Setting.GetFirst(null);
                if (DataRepository.TimeCount.GetCount(x=>(DateTime.Now - x.SetTime).Minutes
                                                      <= setting.TimeLimit_Key)
                                                      >= StudentLimit)
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


        private void Prof_Load(object sender, EventArgs e)
        {
            if(DesignMode)
                return;
            // 데이터 그리드 뷰를 채운다.
            List<QuestionIndex> questionViews = DataRepository.QuestionIndex.GetQuestionViewProfAll();
            dgvProfContents.DataSource = questionViews;
        }

        private void pictureboxSetting_Click(object sender, EventArgs e)
        {
            ProfSetting pSetting = new ProfSetting();
            pSetting.Show();
        }
        

        private void dgvProfContents_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView gridView = (DataGridView)sender;
            QuestionView questionView = new QuestionView();
            Debug.WriteLine(gridView.Rows[e.RowIndex]);
            questionView.NO = (int) gridView.Rows[e.RowIndex].Cells[0].Value;
            questionView.Name = gridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            questionView.Time = DateTime.Parse(gridView.Rows[e.RowIndex].Cells[2].Value.ToString());
            questionView.Content = gridView.Rows[e.RowIndex].Cells[3].Value.ToString();
            MSGDetail msg = new MSGDetail(questionView);
            msg.Show();
        }
    }
}
