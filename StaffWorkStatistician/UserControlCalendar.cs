using System;
using System.Drawing;
using System.Windows.Forms;
using StaffWorkStatisticianCore;
using System.Collections.Generic;

namespace StaffWorkStatistician
{
    public partial class UserControlCalendar : UserControl
    {
        public UserControlCalendar()
        {
            InitializeComponent();
        }

        public void ClearAllItems()
        {
            tableLayoutPanelContent.Controls.Clear();
            tableLayoutPanelContent.RowCount = 1;
        }

        #region 用于设置

        public List<WorkDateRule> TimeRuleList
        {
            get
            {
                List<WorkDateRule> workDateRuleSet = new List<WorkDateRule>();

                foreach (GroupBox groupBox in tableLayoutPanelContent.Controls)
                {
                    WorkDateRule timeRule = new WorkDateRule();
                    timeRule.Date = (DateTime)groupBox.Tag;

                    Button buttonWorkOverTime = groupBox.Controls[0].Controls[0] as Button;

                    if (buttonWorkOverTime.Text == "上班")
                    {
                        timeRule.IsWorkDate = true;
                    }
                    else
                    {
                        timeRule.IsWorkDate = false;
                    }

                    Button buttonOverTimeMultiple = groupBox.Controls[0].Controls[1] as Button;

                    if (buttonOverTimeMultiple.Text == "0.5倍")
                    {
                        timeRule.Multiple = 0.5;
                    }
                    else if (buttonOverTimeMultiple.Text == "1倍")
                    {
                        timeRule.Multiple = 1;
                    }
                    else if (buttonOverTimeMultiple.Text == "2倍")
                    {
                        timeRule.Multiple = 2;
                    }
                    else if (buttonOverTimeMultiple.Text == "3倍")
                    {
                        timeRule.Multiple = 3;
                    }

                    workDateRuleSet.Add(timeRule);
                }
                return workDateRuleSet;
            }
        }

        //根据起始和结束时间更新日历表格
        public void UpdateSettingCalendar(DateTime startTime, DateTime endTime)
        {
            tableLayoutPanelContent.Controls.Clear();
            if (startTime.CompareTo(endTime) < 0)
            {
                startTime = startTime.Date;
                endTime = endTime.Date;

                //中间的间隔天数
                TimeSpan timeSpan = endTime - startTime;
                int daySpan = timeSpan.Days + 1;

                //中间的间隔星期数
                int startDayOfWeek = (int)startTime.DayOfWeek;
                int endDayOfWeek = (int)endTime.DayOfWeek;
                int allDaySpan = daySpan + startDayOfWeek + (6 - endDayOfWeek);
                int weekSpan = allDaySpan / 7;

                //开始填充日历
                tableLayoutPanelContent.RowCount = weekSpan + 1;
                if (weekSpan == 1)   //如果只有一周
                {
                    for (int i = startDayOfWeek; i <= endDayOfWeek; i++)
                    {
                        DateTime time = startTime.AddDays(i - startDayOfWeek);
                        CreateSettingCalendarCell(time, i, 0);
                    }
                }
                else
                {
                    //第一周
                    for (int i = startDayOfWeek; i <= 6; i++)
                    {
                        DateTime time = startTime.AddDays(i - startDayOfWeek);
                        CreateSettingCalendarCell(time, i, 0);
                    }

                    //中间各周
                    for (int i = 1; i < weekSpan - 1; i++)
                    {
                        for (int j = 0; j <= 6; j++)
                        {
                            DateTime time = startTime.AddDays(j - startDayOfWeek + i * 7);
                            CreateSettingCalendarCell(time, j, i);
                        }
                    }

                    //最后一周
                    for (int i = 0; i <= endDayOfWeek; i++)
                    {
                        DateTime time = startTime.AddDays(i - startDayOfWeek + (weekSpan - 1) * 7);
                        CreateSettingCalendarCell(time, i, weekSpan - 1);
                    }
                }
            }
        }

        private void CreateSettingCalendarCell(DateTime dateTime, int column, int row)
        {
            GroupBox gropuBox = new GroupBox();
            gropuBox.Dock = DockStyle.Fill;
            gropuBox.Height = 45;
            gropuBox.Text = dateTime.ToLongDateString();
            gropuBox.Tag = dateTime;
            tableLayoutPanelContent.Controls.Add(gropuBox);
            tableLayoutPanelContent.SetRow(gropuBox, row);
            tableLayoutPanelContent.SetColumn(gropuBox, column);

            TableLayoutPanel tableLayoutPanel = new TableLayoutPanel();
            tableLayoutPanel.ColumnCount = 2;
            tableLayoutPanel.RowCount = 1;
            tableLayoutPanel.AutoSize = true;
            tableLayoutPanel.Dock = DockStyle.Fill;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));
            gropuBox.Controls.Add(tableLayoutPanel);

            Button buttonWorkOverTime = new Button();
            buttonWorkOverTime.TextAlign = ContentAlignment.MiddleCenter;
            buttonWorkOverTime.Dock = DockStyle.Fill;
            if (dateTime.DayOfWeek == DayOfWeek.Sunday || dateTime.DayOfWeek == DayOfWeek.Saturday)
            {
                buttonWorkOverTime.Text = "休息";
                buttonWorkOverTime.ForeColor = Color.Red;
            }
            else
            {
                buttonWorkOverTime.Text = "上班";
            }
            buttonWorkOverTime.Click += buttonWorkOverTime_Click;
            tableLayoutPanel.Controls.Add(buttonWorkOverTime, 0, 0);

            Button buttonOverTimeMultiple = new Button();
            buttonOverTimeMultiple.TextAlign = ContentAlignment.MiddleCenter;
            if (dateTime.DayOfWeek == DayOfWeek.Sunday || dateTime.DayOfWeek == DayOfWeek.Saturday)
            {
                buttonOverTimeMultiple.Text = "2倍";
                buttonOverTimeMultiple.ForeColor = Color.Green;
            }
            else
            {
                buttonOverTimeMultiple.Text = "0.5倍";
            }
            buttonOverTimeMultiple.Dock = DockStyle.Fill;
            buttonOverTimeMultiple.Click += buttonOverTimeMultiple_Click;
            tableLayoutPanel.Controls.Add(buttonOverTimeMultiple, 1, 0);
        }

        private void buttonWorkOverTime_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button.Text == "上班")
            {
                button.Text = "休息";
                button.ForeColor = Color.Red;
            }
            else
            {
                button.Text = "上班";
                button.ForeColor = Color.Black;
            }
        }

        private void buttonOverTimeMultiple_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button.Text == "3倍")
            {
                button.Text = "0.5倍";
                button.ForeColor = Color.Black;
            }
            else if (button.Text == "0.5倍")
            {
                button.Text = "1倍";
                button.ForeColor = Color.Blue;
            }
            else if (button.Text == "1倍")
            {
                button.Text = "2倍";
                button.ForeColor = Color.Green;
            }
            else if (button.Text == "2倍")
            {
                button.Text = "3倍";
                button.ForeColor = Color.Red;
            }
        }

        #endregion

        private List<DateTime> GetRecordsBetween(DateTime startTime, DateTime endTime, List<DateTime> records)
        {
            List<DateTime> resultTime = new List<DateTime>();
            for (int i = 0; i < records.Count; i++)
            {
                if (startTime.Date == records[i].Date)
                {
                    if (startTime.CompareTo(records[i]) <= 0 && endTime.CompareTo(records[i]) >= 0)
                    {
                        resultTime.Add(records[i]);
                    }
                }
            }

            return resultTime;
        }

        #region

        //根据打卡记录更新日历表格
        public void UpdateShowingCalendar(DateTime startDate, DateTime endDate, List<DateTime> allRecords, List<DateTime> records)
        {
            List<DateTime> allDateTimeSet, dataTimeSet;
            DateTime startTime, endTime;
            tableLayoutPanelContent.Controls.Clear();
            if (startDate.CompareTo(endDate) < 0)
            {
                startDate = startDate.Date;
                endDate = endDate.Date;

                //中间的间隔天数
                TimeSpan timeSpan = endDate - startDate;
                int daySpan = timeSpan.Days + 1;

                //中间的间隔星期数
                int startDayOfWeek = (int)startDate.DayOfWeek;
                int endDayOfWeek = (int)endDate.DayOfWeek;
                int allDaySpan = daySpan + startDayOfWeek + (6 - endDayOfWeek);
                int weekSpan = allDaySpan / 7;

                //开始填充日历
                tableLayoutPanelContent.RowCount = weekSpan + 1;
                if (weekSpan == 1)   //如果只有一周
                {
                    for (int i = startDayOfWeek; i <= endDayOfWeek; i++)
                    {
                        startTime = startDate.AddDays(i - startDayOfWeek);
                        endTime = startTime.AddDays(1);
                        allDateTimeSet = GetRecordsBetween(startTime, endTime, allRecords);
                        dataTimeSet = GetRecordsBetween(startTime, endTime, records);
                        CreateShowingCalendarCell(startTime, allDateTimeSet, dataTimeSet, i, 0);
                    }
                }
                else
                {
                    //第一周
                    for (int i = startDayOfWeek; i <= 6; i++)
                    {
                        startTime = startDate.AddDays(i - startDayOfWeek);
                        endTime = startTime.AddDays(1);
                        allDateTimeSet = GetRecordsBetween(startTime, endTime, allRecords);
                        dataTimeSet = GetRecordsBetween(startTime, endTime, records);
                        CreateShowingCalendarCell(startTime, allDateTimeSet, dataTimeSet, i, 0);
                    }

                    //中间各周
                    for (int i = 1; i < weekSpan - 1; i++)
                    {
                        for (int j = 0; j <= 6; j++)
                        {
                            startTime = startDate.AddDays(j - startDayOfWeek + i * 7);
                            endTime = startTime.AddDays(1);
                            allDateTimeSet = GetRecordsBetween(startTime, endTime, allRecords);
                            dataTimeSet = GetRecordsBetween(startTime, endTime, records);
                            CreateShowingCalendarCell(startTime, allDateTimeSet, dataTimeSet, j, i);
                        }
                    }

                    //最后一周
                    for (int i = 0; i <= endDayOfWeek; i++)
                    {
                        startTime = startDate.AddDays(i - startDayOfWeek + (weekSpan - 1) * 7);
                        endTime = startTime.AddDays(1);
                        allDateTimeSet = GetRecordsBetween(startTime, endTime, allRecords);
                        dataTimeSet = GetRecordsBetween(startTime, endTime, records);
                        CreateShowingCalendarCell(startTime, allDateTimeSet, dataTimeSet, i, weekSpan - 1);
                    }
                }
            }
        }

        private void CreateShowingCalendarCell(DateTime date, List<DateTime> allDateTime, List<DateTime> datetime, int column, int row)
        {
            GroupBox gropuBox = new GroupBox();
            gropuBox.Height = 20 + allDateTime.Count * 12;
            gropuBox.Dock = DockStyle.Fill;
            gropuBox.Text = date.ToLongDateString();
            gropuBox.Tag = allDateTime;
            tableLayoutPanelContent.Controls.Add(gropuBox);
            tableLayoutPanelContent.SetRow(gropuBox, row);
            tableLayoutPanelContent.SetColumn(gropuBox, column);

            //旷工
            for (int i = 0; i < datetime.Count; i++)
            {
                if (!allDateTime.Contains(datetime[i]))
                {
                    gropuBox.ForeColor = Color.Red;
                    break;
                }
            }

            //双倍或者多倍加班
            for (int i = 0; i < datetime.Count; i++)
            {
                
            }

            if (allDateTime.Count > 0)
            {
                TableLayoutPanel tableLayoutPanel = new TableLayoutPanel();
                tableLayoutPanel.ColumnCount = 1;
                tableLayoutPanel.AutoSize = true;
                tableLayoutPanel.Dock = DockStyle.Fill;
                gropuBox.Controls.Add(tableLayoutPanel);

                for (int i = 0; i < allDateTime.Count; i++)
                {
                    tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 12));
                    Label label = new Label();
                    label.Text = allDateTime[i].ToLongTimeString();
                    label.TextAlign = ContentAlignment.MiddleCenter;
                    label.Dock = DockStyle.Fill;
                    tableLayoutPanel.Controls.Add(label, 0, i);
                    if (datetime.Contains(allDateTime[i]))
                    {
                        label.ForeColor = Color.Red;
                    }
                    else
                    {
                        label.ForeColor = Color.Black;
                    }
                }

                tableLayoutPanel.RowCount++;
                tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            }
        }

        #endregion
    }
}
