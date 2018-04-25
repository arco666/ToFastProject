using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToFast.Data
{
    public class QuestionIndexData : EntityData<QuestionIndex>
    {
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
    }
}
