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
	public class StudentData : EntityData<Student>
    {
        public int GetByName(string name)
        {
            using (ToFastEntities context = new ToFastEntities())
            {
                return context.Subjects.FirstOrDefault(x => x.SubjectName == name).SubjectId;
            }
        }
        // 로그인 할떄 호출된다.
		public Student GetByIdAndPassword(string name, string password)
		{
			using (ToFastEntities context = new ToFastEntities())
			{
				return context
					.Students
					.Where(x => x.Name == name && x.Password == password)
					.FirstOrDefault();
			}
		}

        
    }
}

