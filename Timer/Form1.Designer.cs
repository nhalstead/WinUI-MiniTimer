namespace Timer
{
    partial class TimerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimerForm));
            this.buttonStart = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Menu_StartTimer = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_PauseTimer = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_StopTimer = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.TimeMin = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.TimeSec = new System.Windows.Forms.Label();
            this.buttonPause = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.TimeRemaining = new System.Windows.Forms.TextBox();
            this.TimeRemainingLable = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TimeHour = new System.Windows.Forms.NumericUpDown();
            this.TimeMinValue = new System.Windows.Forms.NumericUpDown();
            this.TimeSecValue = new System.Windows.Forms.NumericUpDown();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Total_Time = new System.Windows.Forms.TextBox();
            this.SoundPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TimeHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeMinValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeSecValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SoundPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.ContextMenuStrip = this.contextMenuStrip1;
            this.buttonStart.Location = new System.Drawing.Point(9, 250);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 45);
            this.buttonStart.TabIndex = 4;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_StartTimer,
            this.Menu_PauseTimer,
            this.Menu_StopTimer,
            this.toolStripSeparator1,
            this.toolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(265, 98);
            // 
            // Menu_StartTimer
            // 
            this.Menu_StartTimer.Name = "Menu_StartTimer";
            this.Menu_StartTimer.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.Menu_StartTimer.Size = new System.Drawing.Size(264, 22);
            this.Menu_StartTimer.Text = "Start Timer";
            this.Menu_StartTimer.Click += new System.EventHandler(this.Menu_StartTimer_Click);
            // 
            // Menu_PauseTimer
            // 
            this.Menu_PauseTimer.Name = "Menu_PauseTimer";
            this.Menu_PauseTimer.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.Menu_PauseTimer.Size = new System.Drawing.Size(264, 22);
            this.Menu_PauseTimer.Text = "Pause Timer";
            this.Menu_PauseTimer.Click += new System.EventHandler(this.Menu_PauseTimer_Click);
            // 
            // Menu_StopTimer
            // 
            this.Menu_StopTimer.Name = "Menu_StopTimer";
            this.Menu_StopTimer.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.Menu_StopTimer.Size = new System.Drawing.Size(264, 22);
            this.Menu_StopTimer.Text = "Stop Timer";
            this.Menu_StopTimer.Click += new System.EventHandler(this.Menu_StopTimmer_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(261, 6);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(264, 22);
            this.toolStripMenuItem1.Text = "Program Created By: Noah Halstead";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.ContextMenuStrip = this.contextMenuStrip1;
            this.label1.Location = new System.Drawing.Point(12, 317);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Software Created By: Noah Halstead";
            // 
            // progressBar1
            // 
            this.progressBar1.ContextMenuStrip = this.contextMenuStrip1;
            this.progressBar1.Location = new System.Drawing.Point(9, 187);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(355, 23);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 0;
            // 
            // TimeMin
            // 
            this.TimeMin.AutoSize = true;
            this.TimeMin.ContextMenuStrip = this.contextMenuStrip1;
            this.TimeMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeMin.Location = new System.Drawing.Point(123, 15);
            this.TimeMin.Name = "TimeMin";
            this.TimeMin.Size = new System.Drawing.Size(57, 15);
            this.TimeMin.TabIndex = 0;
            this.TimeMin.Text = "Minutes: ";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TimeSec
            // 
            this.TimeSec.AutoSize = true;
            this.TimeSec.ContextMenuStrip = this.contextMenuStrip1;
            this.TimeSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeSec.Location = new System.Drawing.Point(251, 15);
            this.TimeSec.Name = "TimeSec";
            this.TimeSec.Size = new System.Drawing.Size(61, 15);
            this.TimeSec.TabIndex = 0;
            this.TimeSec.Text = "Seconds: ";
            // 
            // buttonPause
            // 
            this.buttonPause.ContextMenuStrip = this.contextMenuStrip1;
            this.buttonPause.Location = new System.Drawing.Point(90, 250);
            this.buttonPause.Name = "buttonPause";
            this.buttonPause.Size = new System.Drawing.Size(75, 45);
            this.buttonPause.TabIndex = 5;
            this.buttonPause.Text = "Pause";
            this.buttonPause.UseVisualStyleBackColor = true;
            this.buttonPause.Click += new System.EventHandler(this.buttonPause_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.ContextMenuStrip = this.contextMenuStrip1;
            this.buttonStop.Location = new System.Drawing.Point(171, 250);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(75, 45);
            this.buttonStop.TabIndex = 6;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // TimeRemaining
            // 
            this.TimeRemaining.BackColor = System.Drawing.SystemColors.Control;
            this.TimeRemaining.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TimeRemaining.ContextMenuStrip = this.contextMenuStrip1;
            this.TimeRemaining.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeRemaining.Location = new System.Drawing.Point(9, 141);
            this.TimeRemaining.Name = "TimeRemaining";
            this.TimeRemaining.ReadOnly = true;
            this.TimeRemaining.Size = new System.Drawing.Size(355, 13);
            this.TimeRemaining.TabIndex = 9999;
            this.TimeRemaining.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TimeRemainingLable
            // 
            this.TimeRemainingLable.AutoSize = true;
            this.TimeRemainingLable.ContextMenuStrip = this.contextMenuStrip1;
            this.TimeRemainingLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeRemainingLable.Location = new System.Drawing.Point(134, 56);
            this.TimeRemainingLable.Name = "TimeRemainingLable";
            this.TimeRemainingLable.Size = new System.Drawing.Size(102, 15);
            this.TimeRemainingLable.TabIndex = 0;
            this.TimeRemainingLable.Text = "Time Remaining:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ContextMenuStrip = this.contextMenuStrip1;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Hours:";
            // 
            // TimeHour
            // 
            this.TimeHour.ContextMenuStrip = this.contextMenuStrip1;
            this.TimeHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeHour.Location = new System.Drawing.Point(53, 13);
            this.TimeHour.Name = "TimeHour";
            this.TimeHour.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TimeHour.Size = new System.Drawing.Size(58, 23);
            this.TimeHour.TabIndex = 1;
            // 
            // TimeMinValue
            // 
            this.TimeMinValue.ContextMenuStrip = this.contextMenuStrip1;
            this.TimeMinValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeMinValue.Location = new System.Drawing.Point(177, 13);
            this.TimeMinValue.Name = "TimeMinValue";
            this.TimeMinValue.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TimeMinValue.Size = new System.Drawing.Size(58, 23);
            this.TimeMinValue.TabIndex = 2;
            // 
            // TimeSecValue
            // 
            this.TimeSecValue.ContextMenuStrip = this.contextMenuStrip1;
            this.TimeSecValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeSecValue.Location = new System.Drawing.Point(309, 13);
            this.TimeSecValue.Name = "TimeSecValue";
            this.TimeSecValue.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TimeSecValue.Size = new System.Drawing.Size(58, 23);
            this.TimeSecValue.TabIndex = 3;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // button1
            // 
            this.button1.ContextMenuStrip = this.contextMenuStrip1;
            this.button1.Location = new System.Drawing.Point(316, 299);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(61, 36);
            this.button1.TabIndex = 8;
            this.button1.Text = "Define Audio";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.ContextMenuStrip = this.contextMenuStrip1;
            this.button2.Location = new System.Drawing.Point(316, 260);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(61, 35);
            this.button2.TabIndex = 7;
            this.button2.Text = "Default Sounds";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Total_Time
            // 
            this.Total_Time.BackColor = System.Drawing.SystemColors.Control;
            this.Total_Time.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Total_Time.ContextMenuStrip = this.contextMenuStrip1;
            this.Total_Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total_Time.Location = new System.Drawing.Point(9, 74);
            this.Total_Time.Name = "Total_Time";
            this.Total_Time.ReadOnly = true;
            this.Total_Time.Size = new System.Drawing.Size(355, 61);
            this.Total_Time.TabIndex = 9999;
            this.Total_Time.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SoundPlayer
            // 
            this.SoundPlayer.ContextMenuStrip = this.contextMenuStrip1;
            this.SoundPlayer.Enabled = true;
            this.SoundPlayer.Location = new System.Drawing.Point(63, 216);
            this.SoundPlayer.Name = "SoundPlayer";
            this.SoundPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("SoundPlayer.OcxState")));
            this.SoundPlayer.Size = new System.Drawing.Size(237, 34);
            this.SoundPlayer.TabIndex = 0;
            this.SoundPlayer.Visible = false;
            // 
            // TimerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 337);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SoundPlayer);
            this.Controls.Add(this.Total_Time);
            this.Controls.Add(this.TimeSecValue);
            this.Controls.Add(this.TimeMinValue);
            this.Controls.Add(this.TimeHour);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TimeRemainingLable);
            this.Controls.Add(this.TimeRemaining);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonPause);
            this.Controls.Add(this.TimeSec);
            this.Controls.Add(this.TimeMin);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonStart);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(395, 376);
            this.MinimumSize = new System.Drawing.Size(395, 376);
            this.Name = "TimerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Timer";
            this.Load += new System.EventHandler(this.TimerForm_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TimeHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeMinValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeSecValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SoundPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label TimeMin;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label TimeSec;
        private System.Windows.Forms.Button buttonPause;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.TextBox TimeRemaining;
        private System.Windows.Forms.Label TimeRemainingLable;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Menu_StartTimer;
        private System.Windows.Forms.ToolStripMenuItem Menu_PauseTimer;
        private System.Windows.Forms.ToolStripMenuItem Menu_StopTimer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown TimeHour;
        private System.Windows.Forms.NumericUpDown TimeMinValue;
        private System.Windows.Forms.NumericUpDown TimeSecValue;
        private AxWMPLib.AxWindowsMediaPlayer SoundPlayer;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.TextBox Total_Time;
    }
}

