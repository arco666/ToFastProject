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
        public List<QuestionIndex> GetQuestionViewProfAll()
        {
            using (ToFastEntities context = new ToFastEntities())
            {
//                int profId = DataRepository.ProfessorUser.TeacherId;
                var query = from x in context.QuestionIndexes
                    where x.TeacherId == 1
                    select new
                    {
                        QuestionIndex = x,
                        x.Student.Name
                    };
                var list = query.ToList();
                foreach (var x in list)
                {
                    x.QuestionIndex.Name = x.Name;
                }

                return list.ConvertAll(x => x.QuestionIndex);
//                var query = from x in context.QuestionIndexes
//                    where x.TeacherId == 1
//                    select new QuestionView()
//                    {
//                        Name = x.Name,
//                        Content = x.Context,
//                        NO = x.QuestionId,
//                        Time = x.QuestionTime
//                    };
//                return query.ToList();
            }
        }
        //선생님 기준의 목록
        public List<QuestionIndex> GetByStudentPK(int studentId)
        {
            using (ToFastEntities context = new ToFastEntities())
            {
                var quary = from x in context.QuestionIndexes
                    where x.StudentId == studentId
                    select x;
                return quary.ToList();
            }
        }
        //학생 기준의 목록
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

        public QuestionIndex GetByQuestionPK(int indexnumber)
        {
            using (ToFastEntities context = new ToFastEntities())
            {
                return (from x in context.QuestionIndexes
                        where x.QuestionId == indexnumber
                         select x)
                    .ToList()
                    .FirstOrDefault();
            }
        }

        public void DeleteRange(List<QuestionIndex> delList)
        {
            using (ToFastEntities context = new ToFastEntities())
            {
                context.QuestionIndexes.RemoveRange(delList);
                context.SaveChanges();
            }
        }
    }
}
