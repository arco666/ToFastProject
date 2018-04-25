using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using ToFast.Data;

namespace ToFast.Controls
{
    public partial class Evaluation : UserControl
    {
        public Evaluation()
        {
            InitializeComponent();
        }

        private int _indexnumber;

        public void SetIndexNumber(int indexnumber)
        {
            _indexnumber = indexnumber;
        }

        private RadioButton CurRadioButton { get; set; }

        private void Evaluation_Load(object sender, EventArgs e)
        {
            CurRadioButton = btnNomal;
            QuestionIndex questionIndex = DataRepository.QuestionIndex.GetFirst(x => x.QuestionId == _indexnumber);
            if (questionIndex.Evaluation == 1)
                btnGood.Checked = true;
            else if (questionIndex.Evaluation == 2)
                btnNomal.Checked = true;
            else                                 
                btnBad.Checked = true;
        }
        

        private void Evaluation_Click(object sender, EventArgs e)
        {
            if (!(sender is RadioButton))
                return;
            if (CurRadioButton != (RadioButton) sender)
            {
                CurRadioButton = (RadioButton)sender;
                QuestionIndex questionIndex = DataRepository.QuestionIndex.GetFirst(x => x.QuestionId == _indexnumber);
                if (CurRadioButton == btnGood)
                    questionIndex.Evaluation = 1;
                else if (CurRadioButton == btnNomal)
                    questionIndex.Evaluation = 2;
                else
                    questionIndex.Evaluation = 3;
                DataRepository.QuestionIndex.Update(questionIndex);
            }
        }
    }
}