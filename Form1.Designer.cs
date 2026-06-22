namespace Remind_Me_To_Stand_Up
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timerMin = new System.Windows.Forms.Timer(this.components);
            this.labMin = new System.Windows.Forms.Label();
            this.labSec = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pbInfo = new System.Windows.Forms.PictureBox();
            this.notifyIconStandUp = new System.Windows.Forms.NotifyIcon(this.components);
            this.btnStart = new System.Windows.Forms.Button();
            this.UDMin = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.timerSec = new System.Windows.Forms.Timer(this.components);
            this.btnRest = new System.Windows.Forms.Button();
            this.notifyIconBackToApp = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UDMin)).BeginInit();
            this.SuspendLayout();
            // 
            // timerMin
            // 
            this.timerMin.Interval = 60000;
            this.timerMin.Tick += new System.EventHandler(this.timerMin_Tick);
            // 
            // labMin
            // 
            this.labMin.AutoSize = true;
            this.labMin.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labMin.Location = new System.Drawing.Point(95, 73);
            this.labMin.Name = "labMin";
            this.labMin.Size = new System.Drawing.Size(205, 159);
            this.labMin.TabIndex = 0;
            this.labMin.Text = "00";
            // 
            // labSec
            // 
            this.labSec.AutoSize = true;
            this.labSec.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSec.Location = new System.Drawing.Point(345, 73);
            this.labSec.Name = "labSec";
            this.labSec.Size = new System.Drawing.Size(205, 159);
            this.labSec.TabIndex = 1;
            this.labSec.Text = "00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(270, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 159);
            this.label2.TabIndex = 2;
            this.label2.Text = ":";
            // 
            // pbInfo
            // 
            this.pbInfo.Image = global::Remind_Me_To_Stand_Up.Properties.Resources.information;
            this.pbInfo.Location = new System.Drawing.Point(12, 12);
            this.pbInfo.Name = "pbInfo";
            this.pbInfo.Size = new System.Drawing.Size(49, 44);
            this.pbInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbInfo.TabIndex = 3;
            this.pbInfo.TabStop = false;
            this.pbInfo.Click += new System.EventHandler(this.pbInfo_Click);
            // 
            // notifyIconStandUp
            // 
            this.notifyIconStandUp.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIconStandUp.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIconStandUp.Icon")));
            this.notifyIconStandUp.Visible = true;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(26, 326);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(298, 49);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // UDMin
            // 
            this.UDMin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UDMin.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.UDMin.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UDMin.Location = new System.Drawing.Point(207, 255);
            this.UDMin.Maximum = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.UDMin.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.UDMin.Name = "UDMin";
            this.UDMin.Size = new System.Drawing.Size(262, 27);
            this.UDMin.TabIndex = 6;
            this.UDMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.UDMin.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.UDMin.ValueChanged += new System.EventHandler(this.UDMin_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "Remind Me Every";
            // 
            // timerSec
            // 
            this.timerSec.Interval = 1000;
            this.timerSec.Tick += new System.EventHandler(this.timerSec_Tick);
            // 
            // btnRest
            // 
            this.btnRest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnRest.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnRest.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnRest.Enabled = false;
            this.btnRest.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnRest.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnRest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRest.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRest.Location = new System.Drawing.Point(350, 326);
            this.btnRest.Name = "btnRest";
            this.btnRest.Size = new System.Drawing.Size(298, 49);
            this.btnRest.TabIndex = 8;
            this.btnRest.Text = "Rest";
            this.btnRest.UseVisualStyleBackColor = false;
            this.btnRest.Click += new System.EventHandler(this.btnRest_Click);
            // 
            // notifyIconBackToApp
            // 
            this.notifyIconBackToApp.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIconBackToApp.Icon")));
            this.notifyIconBackToApp.Visible = true;
            this.notifyIconBackToApp.BalloonTipClicked += new System.EventHandler(this.notifyIconBackToApp_BalloonTipClicked);
            this.notifyIconBackToApp.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIconBackToApp_MouseDoubleClick);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnStart;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CancelButton = this.btnRest;
            this.ClientSize = new System.Drawing.Size(660, 387);
            this.Controls.Add(this.btnRest);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UDMin);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.pbInfo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labSec);
            this.Controls.Add(this.labMin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Remind Me To Stand-Up";
            this.Resize += new System.EventHandler(this.Form1_Minimized);
            ((System.ComponentModel.ISupportInitialize)(this.pbInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UDMin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timerMin;
        private System.Windows.Forms.Label labMin;
        private System.Windows.Forms.Label labSec;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbInfo;
        private System.Windows.Forms.NotifyIcon notifyIconStandUp;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.NumericUpDown UDMin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timerSec;
        private System.Windows.Forms.Button btnRest;
        private System.Windows.Forms.NotifyIcon notifyIconBackToApp;
    }
}

