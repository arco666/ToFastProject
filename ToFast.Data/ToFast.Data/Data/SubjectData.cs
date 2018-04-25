using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToFast.Data
{
    public class SubjectData : EntityData<Subject>
    {
		/// <summary>
		/// 작성자: 소재홍
		/// 작성일: 2018-04-25 09:38
		/// 수정: 메서드 작성
		/// </summary>
		/// <param name="teacherId"></param>
		/// <returns></returns>
		public Subject GetByTeacherId(int teacherId)
		{
			using (ToFastEntities context = new ToFastEntities())
			{
				return context
					.Subjects
					.Where(x => x.TeacherId == teacherId)
					.FirstOrDefault();
			}
		}
    }
}
