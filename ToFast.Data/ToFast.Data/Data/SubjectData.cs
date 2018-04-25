using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToFast.Data
{
    public class SubjectData : EntityData<Subject>
    {
        public List<string> GetSubjectAllNames()
        {
            using (ToFastEntities context = new ToFastEntities())
            {
                return context.Subjects.Select(x => x.SubjectName).ToList();
            }
        }
    }
}
