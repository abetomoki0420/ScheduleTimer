using System;
using System.Windows.Forms; 
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ScheduleStopWatch
{
    public class ScheduleStopWatchTimer
    {
        public bool isRun;
        public DateTime targetDate;
        public TimeSpan remainingTimeSpan;
        private Timer countDownTimer;
        private TextBox setTextBox;

        private void timerTick(object sender, EventArgs e)
        {
            this.remainingTimeSpan = remainingTimeSpan.Subtract(new TimeSpan(TimeSpan.TicksPerSecond));
            this.setTextBox.Text = this.getRemainingTotalSecondsText();

        }

        public ScheduleStopWatchTimer(DateTime _targetDate , TextBox _setTextBox )
        {
            this.isRun = false;
            this.targetDate = _targetDate;
            this.setTextBox = _setTextBox;
            this.remainingTimeSpan = this.targetDate.Subtract(DateTime.Now);

            this.countDownTimer = new Timer();
            this.countDownTimer.Tick += new EventHandler(timerTick);
            this.countDownTimer.Interval = 1000;
        }

        public void Start()
        {
            this.isRun = true;
            countDownTimer.Start();
        }

        public long getRemainingTotalSeconds()
        {
            return (long)remainingTimeSpan.TotalSeconds ;
        }

        public String getRemainingTotalSecondsText()
        {
            return ((long)remainingTimeSpan.TotalSeconds).ToString();
        }
    }
}
