using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
    /// 작성자 : 장기열
    /// 작성 일시 : 2018-04-25 09:03
    /// 작성 내용:ToFast버튼 로고 변경
    ///           ComboBox(과목) ReadOnly로 변경   
    /// </summary>
    public partial class Student : Form
    {
        public Student()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 작성자 : 장기열
        /// 작성 일시 : 2018-04-25 09:03
        /// 작성 내용:폼 실행시 Setting에서 제한시간을 가져옴
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Student_Load(object sender, EventArgs e)
        {
            _setting = DataRepository.Setting.GetFirst(null);
            ComboAdd();
        }

        private Setting _setting;

        /// <summary>
        /// 작성자 : 장기열
        /// 작성 일시 : 2018-04-25 09:03
        /// 작성 내용:ComboBox(과목)에 과목이름 추가
        ///          GetSubjectAllNames 생성
        /// </summary>
        /// <summary>
        /// 작성자 : 대한
        /// 작성 일시 : 2018-04-26 13:01
        /// 작성 내용:첫번째 콤보가 자동 선택된다.
        /// </summary>
        private void ComboAdd()
        {
            var subjects = DataRepository.Subject.GetSubjectAllNames();
            foreach (string nameSubject in subjects)
            {
                cbbSubject_Select.Items.Add(nameSubject);
            }

            cbbSubject_Select.Text = cbbSubject_Select.Items[0].ToString();
        }

        /// <summary>
        /// 작성자 : 장기열
        /// 작성 일시 : 2018-04-25 09:03
        /// 작성 내용:ToFast버튼 클릭시 설정시간 만큼 카운트다운
        ///          시간이 남아있으면 클릭 불가
        ///          TimeCount 테이블에 클릭시간 Insert
        /// </summary>
        private bool _timerCheck = false;

        /// <summary>
        /// 작성자 : 장기열
        /// 작성 일시 : 2018-04-25 09:03
        /// 작성 내용: History버튼(기록보기) 클릭시 History Form 오픈
        ///           GetByStudentPK 생성
        ///            Histort Form 에서  setGridView 작성필요
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btHistrory_Click(object sender, EventArgs e)
        {
            if (new History().OneFormShow() is History historyform)
                historyform.ShowDialog();
        }

        /// <summary>
        /// 작성자 : 장기열
        /// 작성 일시 : 2018-04-25 09:03
        /// 작성 내용:Send_Question 버튼 클릭시 QuestionIndex 테이블에 Insert
        ///          내용이 없으면 Insert 불가
        ///          textBox 리셋
        ///          GetByName 생성
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btSend_Question_Click(object sender, EventArgs e)
        {
            QuestionIndex questionIndex = new QuestionIndex();
            questionIndex.StudentId = DataRepository.User.StudentId;
//            questionIndex.StudentId = 11;
            questionIndex.Evaluation = 2;
            questionIndex.Anonymous = _anonymous;
            questionIndex.Deletable = false;
            questionIndex.Checkable = false;
            questionIndex.QuestionTime = DateTime.Now;
            int teacherId
                = DataRepository.Student.GetByName(cbbSubject_Select.Text);
            questionIndex.TeacherId = teacherId;
            questionIndex.Context = txtQuestion.Text;
            if (txtQuestion.Text == "")
                MessageBox.Show("메세지를 입력해주세요", "");
            else
                DataRepository.QuestionIndex.Insert(questionIndex);

            txtQuestion.ResetText();
        }

        /// <summary>
        /// 작성자 : 장기열
        /// 작성 일시 : 2018-04-25 09:03
        /// 작성 내용: Anonymous_CheckedChanged(익명체크) 클릭 될때마다 True,False바뀜(기본값false)
        /// </summary>
        private bool _anonymous = false;

        private void ckbAnonymous_CheckedChanged(object sender, EventArgs e)
        {
            if (!(sender is CheckBox cb))
                return;
            _anonymous = cb.Checked;
        }

        /// <summary>
        /// 작성자 : 장기열
        /// 작성 일시 : 2018-04-25 09:03
        /// 작성 내용: lbTimer에 1초가 지날때마다 1씩 감소
        ///           lbTimer에 값이 0이 되면 tmrTimer가 멈춘다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tmrTimer_Tick(object sender, EventArgs e)
        {
            if ((Convert.ToInt32(lbTimer.Text)) > 0)
                lbTimer.Text = (Convert.ToInt32(lbTimer.Text) - 1).ToString();
            else
            {
                tmrTimer.Stop();
                _timerCheck = !_timerCheck;
            }
        }
        

        private void btnToFast_Click(object sender, EventArgs e)
        {
            if (_setting == null)
                return;

            if (_timerCheck)
            {
                return;
            }

            _timerCheck = !_timerCheck;
            lbTimer.Text = (_setting.TimeLimit_Key * 60).ToString();
            tmrTimer.Start();

            TimeCount timeCount = new TimeCount();
            timeCount.StudentId = DataRepository.User.StudentId;
            //            timeCount.StudentId =11;
            timeCount.SetTime = DateTime.Now;
            DataRepository.TimeCount.Insert(timeCount);
        }
    }
}