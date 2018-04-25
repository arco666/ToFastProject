using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToFast.Data
{
    public class StudentData : EntityData<Student>
    {
        public int GetByName(string name)
        {
            using (ToFastEntities context = new ToFastEntities())
            {
                return context.Subjects.FirstOrDefault(x => x.SubjectName == name).SubjectId;
            }
        }
    }
}

