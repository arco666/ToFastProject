using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToFast.Data;

namespace ToFast
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// 작성자 :   박진수
        /// 작성일 :   04-25 16:30
        /// 수정내용 : prof 내부코드 조작, profsetting 내부코드 조작, alarm 폼 신설
        /// </summary>
        [STAThread]
        static void Main()
        {
            //push test
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            EntityDataInitializer.ConnectionString = "name=ToFastEntities";
			Application.Run(new Login());
		}
    }
}
