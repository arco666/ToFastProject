using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace ToFast
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }
        private readonly Timer _t1 = new Timer();
        private void SplashForm_Load(object sender, EventArgs e)
        {
            Opacity = 0;      //first the opacity is 0

            _t1.Interval = 10;  //we'll increase the opacity every 10ms
            _t1.Tick += FadeIn;  //this calls the function that changes opacity 
            _t1.Start();
        }

        private void FadeIn(object sender, EventArgs e)
        {
            if (Opacity >= 1)
            {
                _t1.Stop();   //this stops the timer if the form is completely displayed
                Thread.Sleep(1000);

                Close();
            }
            else
                Opacity += 0.05;
        }

        private void SplashForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;    //cancel the event so the form won't be closed

            _t1.Tick += FadeOut;  //this calls the fade out function
            _t1.Start();

            if (Opacity == 0)  //if the form is completly transparent
                e.Cancel = false;   //resume the event - the program can be closed

        }

        private void FadeOut(object sender, EventArgs e)
        {
            if (Opacity <= 0)     //check if opacity is 0
            {
                _t1.Stop();    //if it is, we stop the timer
                Close();   //and we try to close the form
            }
            else
                Opacity -= 0.05;
        }

        private void SplashForm_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
