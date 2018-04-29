using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using System.Windows.Forms;
using ToFast.Data;

namespace ToFast
{
    public partial class TrayIcon : Form
    {
        public TrayIcon()
        {
            InitializeComponent();
        }

        private void 종료ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bgwWorker.CancelAsync();
            Application.Exit();
        }

        private void TrayIcon_Load(object sender, EventArgs e)
        {
            TrayIcon_Load();
            this.WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = false;
            this.Visible = false;
            this.notifyIcon1.Visible = true;
            notifyIcon1.ContextMenuStrip = contextMenuStrip1;
            bgwWorker.RunWorkerAsync();

        }
        public virtual void TrayIcon_Load()
        {

        }


        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MainFormShow();
        }
        public virtual void MainFormShow()
        {
        }

        private void bgwWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            Worker_DoWork();
        }
        public virtual void Worker_DoWork() { }

        private void bgwWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            Worker_ProgressChanged();
        }
        public virtual void Worker_ProgressChanged() { }
    }
}
