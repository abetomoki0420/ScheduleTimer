using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace ScheduleStopWatch
{
    class ScheduleSaveData
    {
        public ScheduleData sData;
        public Point sLocation;
        public ScheduleSaveData( ScheduleData _sData , Point _sLocation ) {
            sData = _sData;
            sLocation = _sLocation;
        }
    }
}
