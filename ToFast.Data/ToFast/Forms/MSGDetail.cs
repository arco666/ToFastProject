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
            lbName.Text = questionView.Name;
            lbTime.Text = questionView.Time.ToString();
            tbContext.Text = questionView.Content;
            evaluation.SetIndexNumber(questionView.NO);

        }
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("대한아 모르겠어.");
            Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            Close();
        }
        
    }
}
