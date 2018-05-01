using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToFast.Data;

namespace ToFast
{
    /// <summary>
    /// 
    /// </summary>
    public partial class MSGDetail : Form
    {
        public MSGDetail()
        {
            InitializeComponent();
        }
        public MSGDetail(QuestionView questionView) : this()
        {
            Checkable(questionView.NO);
            lbName.Text = questionView.Name;
            lbTime.Text = questionView.Time.ToString();
            tbContext.Text = questionView.Content;
            evaluation.SetIndexNumber(questionView.NO);
            evaluation.RadioButtonSelection();

        }

        private void Checkable(int questionId)
        {
            QuestionIndex questionIndex = DataRepository.QuestionIndex.GetByQuestionPK(indexnumber: questionId);
            questionIndex.Checkable = true;
            DataRepository.QuestionIndex.Update(questionIndex);
        }
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
