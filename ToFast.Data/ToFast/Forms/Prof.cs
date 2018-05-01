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
    /// <inheritdoc />
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
        ///           questionViews - 선생님 기준의 question 테이블
        /// </summary>
        private void Prof_Load(object sender, EventArgs e)
        {
            if (DesignMode)
                return;
            List<QuestionIndex> questionViews = DataRepository.QuestionIndex.GetQuestionViewProfAll();

            StudentRequestDelete(questionViews);
            ExpiresDelete(questionViews);

            NoNameConfig(questionViews);

            dgvProfContents.DataSource = questionViews;
        }

        private void NoNameConfig(List<QuestionIndex> questionViews)
        {
            if (questionViews == null) throw new ArgumentNullException(nameof(questionViews));
            foreach (QuestionIndex questionIndex in questionViews)
            {
                if (questionIndex.Anonymous)
                    questionIndex.Name = "익명";
            }
        }

        private void StudentRequestDelete(List<QuestionIndex> questionViews)
        {
            if (questionViews == null) throw new ArgumentNullException(nameof(questionViews));
            DateTime now = DateTime.Today;
            List<QuestionIndex> delList = questionViews.Where(x => x.Deletable).ToList();
            delList = delList.Where(x => (now.DayOfYear - x.QuestionTime.DayOfYear) >= 1).ToList();
            DataRepository.QuestionIndex.DeleteRange(delList: delList);
        }

        private void ExpiresDelete(List<QuestionIndex> questionViews)
        {
            if (questionViews == null) throw new ArgumentNullException(nameof(questionViews));
            DateTime now = DateTime.Today;
            List<QuestionIndex> delList = questionViews.Where(x => (now.DayOfYear - x.QuestionTime.DayOfYear) > 7).ToList();
            DataRepository.QuestionIndex.DeleteRange(delList: delList);
        }
        

        private void pictureboxSetting_Click(object sender, EventArgs e)
        {
            if (new ProfSetting().OneFormShow() is ProfSetting pSetting)
                pSetting.ShowDialog();
        }


        private void dgvProfContents_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView gridView = (DataGridView) sender;
            if(gridView.Rows[0].Cells[0].Value.ToString() == "0")
                return;
            QuestionView questionView = new QuestionView
            {
                NO = Convert.ToInt32(gridView.Rows[e.RowIndex].Cells["No"].Value),
                Name = gridView.Rows[e.RowIndex].Cells["StudentName"].Value.ToString(),
                Time = DateTime.Parse(gridView.Rows[e.RowIndex].Cells["QuestionTime"].Value.ToString()),
                Content = gridView.Rows[e.RowIndex].Cells["Context"].Value.ToString()
            };
            if (new MSGDetail(questionView).OneFormShow() is MSGDetail msg)
                msg.Show();
        }
    }
}