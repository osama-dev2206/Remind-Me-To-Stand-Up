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

namespace Remind_Me_To_Stand_Up
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Core Timer = new Core(); 

                       // Utilities 
        private void pbInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This App Was Made To To Help Every One To Stand Up After Specific Mins You Have Sat\n" +
                "Setting For Long Time Without Standing up Is Very Bad!","Info",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void UpdateTimeLabel()
        {
            this.labMin.Text = Timer.Min.ToString().PadLeft(2,'0');
            this.labSec.Text = Timer.Sec.ToString().PadLeft(2, '0');
        }


                    // Notifications 
        private void ShowStandUpNotification()
        {
            notifyIconStandUp.Visible= true;
            notifyIconStandUp.Icon = SystemIcons.Application;
            notifyIconStandUp.BalloonTipIcon = ToolTipIcon.Warning;
            notifyIconStandUp.BalloonTipTitle = "Stand Up !"; // the title of notification 
            notifyIconStandUp.BalloonTipText = $"\nYou Have Sat For {UDMin.Value.ToString().PadLeft(2,'0')}M"; //the content of notification
            notifyIconStandUp.ShowBalloonTip(15000); // the notification will apear for 15sec 
        }

        private void ShowAppAgianNotification()
        {
            notifyIconBackToApp.Visible = true;
            notifyIconBackToApp.Icon = SystemIcons.Application;
            notifyIconBackToApp.BalloonTipIcon = ToolTipIcon.None ;
            notifyIconBackToApp.BalloonTipTitle = "App Has Minimized"; // the title of notification 
            notifyIconBackToApp.BalloonTipText = $"\nTap On Notification To Show App Again"; //the content of notification
            notifyIconBackToApp.ShowBalloonTip(1000); // the notification will apear for 1sec 
        }

        
            /// Timer Management 

        void RestTimer()
        {
            Timer.RestMin();
            Timer.RestSec();

            UpdateTimeLabel();
        }

        // Update Min ==> 1 m has passed 
        private void timerMin_Tick(object sender, EventArgs e)// After the time user has specified finished then the timer will start be restted  
        {
            if (TheEndTime > 1) // if the required time isn't finished yet  
            {
                Timer.UpdateMin();
                UpdateTimeLabel();
                TheEndTime--; 
            }
            else
            {
                ShowStandUpNotification(); // show notification 
                RestTimer();
                TheEndTime = Convert.ToInt32(UDMin.Value);

            }
        }
        // Sec Update 
        private void timerSec_Tick(object sender, EventArgs e)
        {
            Timer.UpdateSec();
            UpdateTimeLabel();
        }

        private int TheEndTime = 0;  // represting the time in min to remind user (MIN)
        private void UDMin_ValueChanged(object sender, EventArgs e)
        {
            TheEndTime = Convert.ToInt32(UDMin.Value); 
        }


             // Buttons // 
        private void btnStart_Click(object sender, EventArgs e)
        {
            this.UDMin.Enabled = false;
            this.timerMin.Enabled = true;
            this.timerSec.Enabled = true;
            btnStart.Enabled = false;
            btnRest.Enabled = true;
        }
        private void btnRest_Click(object sender, EventArgs e)
        {
           this.UDMin.Enabled = true;
           
            UDMin.Value = 1; 
            this.timerMin.Enabled = false;
            this.timerSec.Enabled = false;
            RestTimer();
            btnStart.Enabled = true;
            btnRest.Enabled = false;
        }


                                                   // Form Minimize ..... 

        // Minmize The Form 
        private void Form1_Minimized(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide(); // hide form  
                ShowAppAgianNotification();
            }
        }

        // If User Clicked On Ballon 
        private void notifyIconBackToApp_BalloonTipClicked(object sender, EventArgs e)
        {
            this.Show(); // show app icon 
            this.WindowState = FormWindowState.Normal;
        }

     // If User Clicked On App Notification Icon in Taskbar
        private void notifyIconBackToApp_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Show(); // show app icon 
                this.WindowState = FormWindowState.Normal;
                this.Activate();

            }
        }

  
    }
}
