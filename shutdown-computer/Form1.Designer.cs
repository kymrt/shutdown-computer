namespace shutdown_computer
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
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnAbort = new System.Windows.Forms.Button();
            this.rdSetTime = new System.Windows.Forms.RadioButton();
            this.rdRemainingTime = new System.Windows.Forms.RadioButton();
            this.dtpSetTime = new System.Windows.Forms.DateTimePicker();
            this.grpTiming = new System.Windows.Forms.GroupBox();
            this.numRemainingTime = new System.Windows.Forms.NumericUpDown();
            this.lblMinute = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.lblState = new System.Windows.Forms.Label();
            this.grpTiming.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRemainingTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Image = ((System.Drawing.Image)(resources.GetObject("btnSubmit.Image")));
            this.btnSubmit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubmit.Location = new System.Drawing.Point(60, 307);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(150, 51);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnAbort
            // 
            this.btnAbort.Image = ((System.Drawing.Image)(resources.GetObject("btnAbort.Image")));
            this.btnAbort.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbort.Location = new System.Drawing.Point(60, 364);
            this.btnAbort.Name = "btnAbort";
            this.btnAbort.Size = new System.Drawing.Size(150, 51);
            this.btnAbort.TabIndex = 1;
            this.btnAbort.Text = "Abort";
            this.btnAbort.UseVisualStyleBackColor = true;
            this.btnAbort.Click += new System.EventHandler(this.btnAbort_Click);
            // 
            // rdSetTime
            // 
            this.rdSetTime.AutoSize = true;
            this.rdSetTime.Location = new System.Drawing.Point(12, 20);
            this.rdSetTime.Name = "rdSetTime";
            this.rdSetTime.Size = new System.Drawing.Size(70, 17);
            this.rdSetTime.TabIndex = 2;
            this.rdSetTime.TabStop = true;
            this.rdSetTime.Text = "Set Time:";
            this.rdSetTime.UseVisualStyleBackColor = true;
            this.rdSetTime.CheckedChanged += new System.EventHandler(this.rdSetTime_CheckedChanged);
            // 
            // rdRemainingTime
            // 
            this.rdRemainingTime.AutoSize = true;
            this.rdRemainingTime.Location = new System.Drawing.Point(12, 52);
            this.rdRemainingTime.Name = "rdRemainingTime";
            this.rdRemainingTime.Size = new System.Drawing.Size(101, 17);
            this.rdRemainingTime.TabIndex = 3;
            this.rdRemainingTime.TabStop = true;
            this.rdRemainingTime.Text = "RemainingTime:";
            this.rdRemainingTime.UseVisualStyleBackColor = true;
            // 
            // dtpSetTime
            // 
            this.dtpSetTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpSetTime.Location = new System.Drawing.Point(119, 16);
            this.dtpSetTime.Name = "dtpSetTime";
            this.dtpSetTime.Size = new System.Drawing.Size(68, 20);
            this.dtpSetTime.TabIndex = 6;
            // 
            // grpTiming
            // 
            this.grpTiming.Controls.Add(this.numRemainingTime);
            this.grpTiming.Controls.Add(this.lblMinute);
            this.grpTiming.Controls.Add(this.rdSetTime);
            this.grpTiming.Controls.Add(this.dtpSetTime);
            this.grpTiming.Controls.Add(this.rdRemainingTime);
            this.grpTiming.Location = new System.Drawing.Point(23, 186);
            this.grpTiming.Name = "grpTiming";
            this.grpTiming.Size = new System.Drawing.Size(222, 83);
            this.grpTiming.TabIndex = 7;
            this.grpTiming.TabStop = false;
            // 
            // numRemainingTime
            // 
            this.numRemainingTime.Location = new System.Drawing.Point(119, 52);
            this.numRemainingTime.Name = "numRemainingTime";
            this.numRemainingTime.Size = new System.Drawing.Size(68, 20);
            this.numRemainingTime.TabIndex = 8;
            // 
            // lblMinute
            // 
            this.lblMinute.AutoSize = true;
            this.lblMinute.Location = new System.Drawing.Point(193, 54);
            this.lblMinute.Name = "lblMinute";
            this.lblMinute.Size = new System.Drawing.Size(23, 13);
            this.lblMinute.TabIndex = 7;
            this.lblMinute.Text = "min";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(23, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(216, 155);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon.BalloonTipText = "Shutdown Computer";
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Shutdown Computer";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblState.ForeColor = System.Drawing.Color.Maroon;
            this.lblState.Location = new System.Drawing.Point(20, 279);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(37, 13);
            this.lblState.TabIndex = 9;
            this.lblState.Text = "State";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 435);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grpTiming);
            this.Controls.Add(this.btnAbort);
            this.Controls.Add(this.btnSubmit);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shutdown Computer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.grpTiming.ResumeLayout(false);
            this.grpTiming.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRemainingTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnAbort;
        private System.Windows.Forms.RadioButton rdSetTime;
        private System.Windows.Forms.RadioButton rdRemainingTime;
        private System.Windows.Forms.DateTimePicker dtpSetTime;
        private System.Windows.Forms.GroupBox grpTiming;
        private System.Windows.Forms.Label lblMinute;
        private System.Windows.Forms.NumericUpDown numRemainingTime;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.Label lblState;
    }
}

