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
            Student form = new Student();
            form.Show();
        }
    }
}
