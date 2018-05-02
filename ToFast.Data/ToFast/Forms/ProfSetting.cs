using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToFast.Data;

namespace ToFast
{
    /// <summary>
    /// 작성자 :   박진수
    /// 작성일 :   04-24 15:50
    /// 수정내용 : 로그인 및 총인원, 체크박스 저장 및 이를 위한 settings 조작, 시간 수정을 텍스트에서 숫자로 변경,
    ///           폼 종료시 조작내용 저장
    /// </summary>
    /// <summary>
    /// 작성자   : 정재원
    /// 작성일   : 18-04-24 15:49
    /// 수정내용 : 로고 변경?
    /// </summary>
    public partial class ProfSetting : Form
    {
        public ProfSetting()
        {
            InitializeComponent();
        }
        private void ProfSetting_Shown(object sender, EventArgs e)
        {
            //로그인 및 총인원 카운트
            int LoginStudent = 0;
            int TotalStudent = 0;
            LoginStudent = DataRepository.Student.GetCount(x => x.LogIn == true);
            TotalStudent = DataRepository.Student.GetCount(x => x.StudentId > 0);
            //로그인 및 총인원 표시
            lbCurAndTotal.Text = LoginStudent.ToString() + "(총 " + TotalStudent.ToString() + ")";
            Setting setting = DataRepository.Setting.GetFirst(null);
            numTime.Text = setting.TimeLimit_Key.ToString();
            //현재 설정된 인원 하한수 표시
            tbStudentLimit.Text = Properties.Settings.Default.StudentLimit.ToString();
            //체크박스 로딩
            if (Properties.Settings.Default.AlarmOn == true)
                cbAlarm.Checked = true;
            else
                cbAlarm.Checked = false;
            if (Properties.Settings.Default.Mute == true)
                cbMute.Checked = true;
            else
                cbMute.Checked = false;
        }

        private Prof _prof;

        public ProfSetting(Prof prof) : this()
        {
            _prof = prof;
        }

        private void btnLocReset_Click(object sender, EventArgs e)
        {
            //TODO:로케이션 각각의 위치 쿼리 및 초기화
        }

        private void ProfSetting_FormClosing(object sender, FormClosingEventArgs e)
        {
            Setting setting = DataRepository.Setting.GetFirst(null);
            if (setting == null)
                MessageBox.Show(@"빈 값을 저장할 수 없습니다");
            //알람 학생수 불리오기
            tbStudentLimit.Text = Properties.Settings.Default.StudentLimit.ToString();
            //체크박스 저장
            if (cbAlarm.Checked)
                Properties.Settings.Default.AlarmOn = true;
            else
                Properties.Settings.Default.AlarmOn = false;
            if (cbMute.Checked)
                Properties.Settings.Default.Mute = true;
            else
                Properties.Settings.Default.Mute = false;
            Properties.Settings.Default.Save();
        }

        private void numTime_ValueChanged(object sender, EventArgs e)
        {
            if (_noNumTimeChange)
            {
                Setting setting = DataRepository.Setting.GetFirst(null);
                setting.TimeLimit_Key = Convert.ToInt32(((NumericUpDown)sender).Value);
                DataRepository.Setting.Update(setting);
                DataRepository.TimeCount.DeleteAll();
                _noNumTimeChange = false;
            }
        }

        private void tbStudentLimit_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.StudentLimit = Convert.ToInt32(tbStudentLimit.Text);
        }

        private bool _noNumTimeChange = false;

        private void numTime_Enter(object sender, EventArgs e)
        {
            _noNumTimeChange = true;
        }
    }
}