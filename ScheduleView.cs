using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ScheduleStopWatch
{
    public partial class ScheduleView : UserControl
    {
        public  ScheduleData sdata;
        private ScheduleStopWatchTimer stimer;
        public static int ViewHeight = 100; 

        public ScheduleView( ScheduleData _sdata)
        {
            InitializeComponent();
            sdata = _sdata;
            DateTime scheduleDate = new DateTime(_sdata.Year, _sdata.Month, _sdata.Day);
            stimer = new ScheduleStopWatchTimer( scheduleDate , this.timeUpLimitBox );

            this.TimerNameLabel.Text = _sdata.Name;
            this.TimerLimitLabel.Text = string.Format($"{_sdata.Year}年{_sdata.Month}月{_sdata.Day}日");
        }

        public void Start() {
            this.stimer.Start();
        }
    }
}
