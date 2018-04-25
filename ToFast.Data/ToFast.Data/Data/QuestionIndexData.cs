using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToFast.Data
{
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
                return list.ConvertAll(x=>x.QuestionIndex);
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
    }
}
