using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToFast.Data
{
    //public class TimeCountData : EntityData<Teacher> 로 되어있었음
    public class TimeCountData : EntityData<TimeCount>
    {
        public void DeleteAll()
        {
            using (ToFastEntities context = new ToFastEntities())
            {
                context.TimeCounts.RemoveRange(context.TimeCounts);
                context.SaveChanges();
            }
        }
    }
}
