using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;

namespace ScheduleStopWatch
{
    public partial class AppForm : Form
    {
        private int viewCount;
        private String saveFilePath = Directory.GetCurrentDirectory() + "\\saveData.json";
        public AppForm()
        {
            InitializeComponent();

            viewCount = 0;
            this.scheduleInputForm.ScheduleName.Text = "スケジュール名";
            this.scheduleInputForm.ScheduleLimitYear.Text = DateTime.Now.Year.ToString();
            this.scheduleInputForm.ScheduleLimitMonth.Text = DateTime.Now.Month.ToString();
            this.scheduleInputForm.ScheduleLimitDay.Text = DateTime.Now.Day.ToString();

            //LOAD SAVE DATA
            if (File.Exists(saveFilePath))
            {
                string json = File.ReadAllText(saveFilePath);

                try
                {
                    List<ScheduleSaveData> saveDataList = JsonConvert.DeserializeObject<List<ScheduleSaveData>>(json);
                    foreach (ScheduleSaveData saveData in saveDataList)
                    {
                        ScheduleView sv = createScheduleView(saveData.sData, saveData.sLocation);
                        this.Controls.Add(sv);
                        sv.Start();
                        viewCount++;
                        this.Height += sv.Height;
                    }

                }
                catch (JsonReaderException)
                {
                    File.Delete(saveFilePath);
                }

            }

        }


        private void AppForm_Load(object sender, EventArgs e)
        {
            scheduleInputForm.plusButton.Click += new EventHandler(addScheduleView);
        }

        private void addScheduleView(object sender, EventArgs e)
        {
            String scheduleName = scheduleInputForm.ScheduleName.Text;
            int scheduleYear = 0;
            int scheduleMonth = 0;
            int scheduleDay = 0;
            try
            {
                scheduleYear = int.Parse(scheduleInputForm.ScheduleLimitYear.Text);
                scheduleMonth = int.Parse(scheduleInputForm.ScheduleLimitMonth.Text);
                scheduleDay = int.Parse(scheduleInputForm.ScheduleLimitDay.Text);
            }
            catch (FormatException)
            {
                scheduleInputForm.ScheduleName.Text = "Error!";
                return;
            }

            if (scheduleYear < 0)
            {
                return;
            }

            if (scheduleMonth < 1 || 12 < scheduleMonth)
            {
                return;
            }
            int daysInMonth = DateTime.DaysInMonth(scheduleYear, scheduleMonth);
            if (scheduleDay < 1 || daysInMonth < scheduleDay)
            {
                return;
            }

            var sdata = new ScheduleData(scheduleName, scheduleYear, scheduleMonth, scheduleDay);
            var viewY = scheduleInputForm.Size.Height + scheduleInputForm.Location.Y + (ScheduleView.ViewHeight * viewCount);
            var addLocation = new Point(scheduleInputForm.Location.X, viewY);

            ScheduleView sview = createScheduleView(sdata, addLocation);

            this.Controls.Add(sview);
            sview.Start();
            this.Height += sview.Height;
            viewCount++;

        }

        private ScheduleView createScheduleView(ScheduleData sData, Point sLocation)
        {
            ScheduleView sview = new ScheduleView(sData);
            sview.Location = sLocation;

            sview.minusButton.Click += (o, se) =>
            {
                int index = this.Controls.IndexOf(sview);
                this.Controls.RemoveAt(index);
                this.alignScheduleViews(index);
                this.Height -= sview.Height;
                viewCount--;
            };

            return sview;
        }

        private void alignScheduleViews(int removeIndex)
        {
            foreach (Control control in this.Controls)
            {
                ScheduleView sv = control as ScheduleView;
                if (sv != null)
                {
                    int viewIndex = this.Controls.IndexOf(sv);
                    if (removeIndex <= viewIndex)
                    {
                        sv.Location = new Point(sv.Location.X, sv.Location.Y - sv.Height);
                    }
                }
            }
        }

        private void saveScheduleDatas(object sender, FormClosingEventArgs e)
        {
            List<ScheduleSaveData> saveDataList = new List<ScheduleSaveData>();
            foreach (Control control in this.Controls)
            {
                ScheduleView sv = control as ScheduleView;
                if (sv != null)
                {
                    ScheduleSaveData sdata = new ScheduleSaveData(sv.sdata, sv.Location);
                    saveDataList.Add(sdata);
                }
            }
            var json = JsonConvert.SerializeObject(saveDataList);
            File.WriteAllText(saveFilePath, json);
        }
    }
}
