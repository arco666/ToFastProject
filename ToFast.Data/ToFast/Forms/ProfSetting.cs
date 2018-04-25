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
    /// 작성자 : 박진수
    /// 작성일 : 04-24 15:50
    /// 수정내용 : 알람인원 수정시 코드 작성중
    /// </summary>
    public partial class ProfSetting : Form
    {
        public ProfSetting()
        {
            InitializeComponent();
        }
        private Prof _prof;
        public ProfSetting(Prof prof) : this()
        {
            _prof = prof;
        }
        private void tbSetNum_TextChanged(object sender, EventArgs e)
        {
            //새로운 분 카운트 전송 및 TimeCount 테이블 초기화
            _prof.SetNum = Convert.ToInt32(tbSetNum.Text);
            DataRepository.TimeCount.DeleteAll();
        }
    }
}
