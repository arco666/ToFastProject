using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToFast
{
    public static class FormHelper
    {
        public static Form OneFormShow(this Form form)
        {
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.Name == form.Name)
                {
                    frm.Activate();
                    return frm;
                }
            }
            return form;
        }
    }
}
