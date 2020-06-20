using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace shutdown_computer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string strCmdText= "-s -t ";
            TimeSpan ts = new TimeSpan();

            if (rdSetTime.Checked)
            {
                ts = Convert.ToDateTime(dtpSetTime.Text) - DateTime.Now;
                if(ts.TotalSeconds < 0)
                {
                    MessageBox.Show("You cannot enter a time left behind!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
                ts = TimeSpan.FromMinutes(Convert.ToDouble(numRemainingTime.Value));

            strCmdText += Convert.ToInt32(ts.TotalSeconds).ToString();
            Process.Start("shutdown", strCmdText);
            string info = "Your computer will close in " + Convert.ToInt32(ts.TotalSeconds).ToString() + " seconds.";
            lblState.Text = info;
            lblState.Visible = true;
            notifyIcon.BalloonTipText = info;
            notifyIcon.Visible = true;
            notifyIcon.ShowBalloonTip(30000);
            btnAbort.Enabled = true;
            btnSubmit.Enabled = false;
            grpTiming.Enabled = false;
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rdSetTime.Checked = true;
            dtpSetTime.Focus();
            lblState.Visible = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
            this.Text = "Shutdown Computer";
            notifyIcon.Text = "Shutdown Computer";
            notifyIcon.BalloonTipTitle = "Shutdown Computer";
            dtpSetTime.Format = DateTimePickerFormat.Time;
            dtpSetTime.Value.AddMinutes(1);
            dtpSetTime.ShowUpDown = true;
            btnAbort.Enabled = false;
        }

        private void rdSetTime_CheckedChanged(object sender, EventArgs e)
        {
            numRemainingTime.Enabled = rdRemainingTime.Checked;
            dtpSetTime.Enabled = rdSetTime.Checked;
        }

        private void btnAbort_Click(object sender, EventArgs e)
        {
            Process.Start("shutdown", "/a");
            notifyIcon.BalloonTipText = "Closing your computer is aborted.";
            notifyIcon.Visible = true;
            notifyIcon.ShowBalloonTip(30000);
            lblState.Visible = false;
            btnSubmit.Enabled = true;
            btnAbort.Enabled = false;
            grpTiming.Enabled = true;
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                notifyIcon.BalloonTipText = "Program is running. If you want to open, please double-click the program icon.";
                notifyIcon.Visible = true;
                notifyIcon.ShowBalloonTip(30000);
                this.Hide();
            }              
            this.WindowState = FormWindowState.Normal;
        }
    }
}
