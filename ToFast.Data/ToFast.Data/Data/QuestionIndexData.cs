using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToFast.Data
{
	/// <summary>
	/// 작성자: 소재홍
	/// 작성일: 2018-04-24 17:00
	/// 수정 : GetByStudentId(int id) 작성
	/// </summary>
	public class QuestionIndexData : EntityData<QuestionIndex>
    {
		public List<QuestionIndex> GetByStudentId(int studentId)
		{
			using (ToFastEntities context = new ToFastEntities())
			{
				return context
					.QuestionIndexes
					.Where(x => x.StudentId == studentId && x.Deletable == false)
					.ToList();
			}

		}
    }
}
