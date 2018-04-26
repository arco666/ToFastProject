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
	/// 작성자: 소재홍
	/// 작성일: 2018-04-25 09:38
	/// 수정: History_Load(object sender, EventArgs e), btnOk_Click(object sender, EventArgs e), btnDelete_Click(object sender, EventArgs e), dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e), EvaluationToString(int evaluation), GetQuestionIndex()
	/// </summary>
	public partial class History : Form
    {
		[Flags]
		enum Evaluation {좋아요 = 1 , 싫어요 = 2, 구려 = 3}

		private List<Data.QuestionIndex> questionIndexs;
		private int index;
		private Data.QuestionIndex questionIndex;

		public History()
        {
            InitializeComponent();
        }
        
		private void History_Load(object sender, EventArgs e)
		{
			GetQuestionIndex();
		}

		private void btnOk_Click(object sender, EventArgs e)
		{
			this.Visible = false;
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("정말 삭제 하시겠습니까?", "YesOrNo", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				if (index < 0 && questionIndex == null)
					return;

				questionIndex.Deletable = true;
				DataRepository.QuestionIndex.Update(questionIndex);

				GetQuestionIndex();

				MessageBox.Show("삭제완료");
			}

			if (questionIndex == null)
			{
				MessageBox.Show("삭제할 질문을 선택해주세요");
				return;
			}
		}

		private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			StringBuilder info = new StringBuilder();

			index = e.RowIndex;

			if (index < 0)
				return;

			questionIndex = questionIndexs[index];

			info.Append($"작성일자: {questionIndex.QuestionTime}\r\n");
			info.Append($"질문내용: {questionIndex.Context}\r\n");
			info.Append($"평가: {EvaluationToString(questionIndex.Evaluation)}\r\n");
			info.Append($"확인여부: {questionIndex.Checkable}");

			tbInfo.Text = info.ToString();
		}

		private string EvaluationToString(int evaluation)
		{
		    if (evaluation == (int) Evaluation.좋아요)
		        return "아주 좋은 질문!";

		    if (evaluation == (int) Evaluation.싫어요)
		        return "예컨데, 네!";

		    if (evaluation == (int) Evaluation.구려)
		        return "모욕감 스튜핏";

			return null;
		}

		private void GetQuestionIndex()
		{
			dataGridView.Rows.Clear();

			questionIndexs = DataRepository.QuestionIndex.GetByStudentId(DataRepository.User.StudentId);

			Data.Subject subject = null;

			foreach (Data.QuestionIndex questionIndex in questionIndexs)
			{
				subject = DataRepository.Subject.GetByTeacherId(questionIndex.TeacherId);
				dataGridView.Rows.Add(questionIndex.QuestionTime, questionIndex.Context, subject.SubjectName, questionIndex.Checkable);
			}
		}

	}
}
