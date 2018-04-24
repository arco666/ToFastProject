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
	/// 수정 : GetByIdAndPassword(string name, string password) 작성
	/// </summary>
	public class TeacherData : EntityData<Teacher>
    {
		public Teacher GetByIdAndPassword(string name, string password)
		{
			using (ToFastEntities context = new ToFastEntities())
			{
				return context
					.Teachers
					.Where(x => x.Name == name && x.Password == password)
					.FirstOrDefault();
			}
		}

	}
}
