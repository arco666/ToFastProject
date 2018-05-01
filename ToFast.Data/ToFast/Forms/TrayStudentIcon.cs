using ToFast.Data;

namespace ToFast
{
    public partial class TrayStudentIcon : TrayIcon
    {
        public TrayStudentIcon()
        {
            InitializeComponent();
        }

        public override void TrayIcon_Load()
        {
            if (DesignMode)
                return;
            MainFormShow();
        }

        public override void Worker_DoWork()
        {
        }

        public override void Worker_ProgressChanged()
        {
        }

        public override void MainFormShow()
        {
            if (new Student().OneFormShow() is Student form)
                form.Show();
        }

        /// <summary>
        /// 작성자 : 장기열
        /// 작성 일시 : 2018-04-25 09:03
        /// 작성 내용: 폼이 꺼질때 Student테이블에 Update(Login이 false로 바뀐)
        /// </summary>
        /// <summary>
        /// 작성자 : 대한
        /// 작성 일시 : 2018-05-01 15:31
        /// 작성 내용: 로그인 여부 상의 문제로 Student 폼에서 트레이로 옮김.
        /// </summary>
        private void TrayStudentIcon_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            Data.Student student = DataRepository.User;
            //            Data.Student student = DataRepository.Student.GetFirst(x=>x.StudentId ==11);
            //            student.StudentId = 11;
            student.LogIn = false;
            DataRepository.Student.Update(student);
        }
    }
}