namespace NeckHelper
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnMoveHead = new System.Windows.Forms.Button();
            this.timerCountdown = new System.Windows.Forms.Timer(this.components);
            this.timerBlinking = new System.Windows.Forms.Timer(this.components);
            this.txtInterval = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMoveHead
            // 
            this.btnMoveHead.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnMoveHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoveHead.Location = new System.Drawing.Point(0, 37);
            this.btnMoveHead.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMoveHead.Name = "btnMoveHead";
            this.btnMoveHead.Size = new System.Drawing.Size(494, 90);
            this.btnMoveHead.TabIndex = 0;
            this.btnMoveHead.Text = "做完按我：低头、仰头、左转、右转。";
            this.btnMoveHead.UseVisualStyleBackColor = true;
            this.btnMoveHead.Click += new System.EventHandler(this.btnMoveHead_Click);
            // 
            // timerCountdown
            // 
            this.timerCountdown.Enabled = true;
            this.timerCountdown.Interval = 1000;
            this.timerCountdown.Tick += new System.EventHandler(this.timerCountdown_Tick);
            // 
            // timerBlinking
            // 
            this.timerBlinking.Interval = 500;
            this.timerBlinking.Tick += new System.EventHandler(this.timerBlinking_Tick);
            // 
            // txtInterval
            // 
            this.txtInterval.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInterval.Location = new System.Drawing.Point(144, 4);
            this.txtInterval.Name = "txtInterval";
            this.txtInterval.Size = new System.Drawing.Size(146, 26);
            this.txtInterval.TabIndex = 1;
            this.txtInterval.Text = "600";
            this.txtInterval.TextChanged += new System.EventHandler(this.txtInterval_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "提醒间隔(秒):";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 127);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtInterval);
            this.Controls.Add(this.btnMoveHead);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "颈椎保护提醒";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMoveHead;
        private System.Windows.Forms.Timer timerCountdown;
        private System.Windows.Forms.Timer timerBlinking;
        private System.Windows.Forms.TextBox txtInterval;
        private System.Windows.Forms.Label label1;
    }
}

