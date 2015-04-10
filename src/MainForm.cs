using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NeckHelper
{
    public partial class MainForm : Form
    {
        bool BrightScreen = false;
        int BlinkInterval;  // seconds
        int Countdown;

        public MainForm()
        {
            InitializeComponent();
        }
        
        private void MainForm_Load(object sender, EventArgs e)
        {
            BlinkInterval = Convert.ToInt32(txtInterval.Text);
            ResetCountdown();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SetScreenNormal();
        }

        private void btnMoveHead_Click(object sender, EventArgs e)
        {
            ResetCountdown();
        }

        private void timerCountdown_Tick(object sender, EventArgs e)
        {
            Countdown--;
            this.Text = "倒计时: " + Countdown + "秒";
            if (Countdown <= 0)
            {
                StartBlinkingTimer();
            }
        }

        private void timerBlinking_Tick(object sender, EventArgs e)
        {
            Blink();
        }
        

        private void StartBlinkingTimer()
        {
            Countdown = BlinkInterval;
            timerCountdown.Stop();
            timerBlinking.Start();
        }

        private void Blink()
        {
            this.Text = "Blinking: " + DateTime.Now.ToLongTimeString();
            BrightScreen = !BrightScreen;
            if (BrightScreen)
            {
                SetScreenBright();
            }
            else
            {
                SetScreenNormal();
            }
        }


        private void ResetCountdown()
        {
            timerBlinking.Stop();
            SetScreenNormal();
            Countdown = BlinkInterval;
            timerCountdown.Start();
        }

        private void SetScreenBright()
        {
            BrightnessController.SetGamma(255);
        }

        private void SetScreenNormal()
        {
            BrightnessController.SetGamma(128);
        }

        private void txtInterval_TextChanged(object sender, EventArgs e)
        {
            try
            {
                BlinkInterval = Convert.ToInt32(txtInterval.Text);
            }
            catch 
            {
                MessageBox.Show("请输入正确的数字");
            }
        }
        
    }
}
