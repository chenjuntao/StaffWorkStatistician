using System;
using System.Drawing;
using System.Windows.Forms;
using StaffWorkStatisticianCore;

namespace StaffWorkStatistician
{
    public partial class FormSetTimeRule : Form
    {
        private StaffWorkStatistics staffWorkStatistics;

        public FormSetTimeRule(StaffWorkStatistics staffWorkStatistics)
        {
            InitializeComponent();

            this.staffWorkStatistics = staffWorkStatistics;

            int month = staffWorkStatistics.GetEarlistTime().Month;
            if (month > 4 && month < 10)
            {
                radioButtonSummer.Checked = true;
            }
            else
            {
                radioButtonWinter.Checked = true;
            }
        }

        //作息时间切换
        private void radioButtonTimeRule_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonSummer.Checked)
            {
                dateTimePickerAMStartTime.Value = DateTime.Today.Add(Settings.DefaultInstance.AMStartTime1);
                dateTimePickerAMEndTime.Value = DateTime.Today.Add(Settings.DefaultInstance.AMEndTime1);
                dateTimePickerPMStartTime.Value = DateTime.Today.Add(Settings.DefaultInstance.PMStartTime1);
                dateTimePickerPMEndTime.Value = DateTime.Today.Add(Settings.DefaultInstance.PMEndTime1);
                dateTimePickerBufferTime.Value = DateTime.Today.Add(Settings.DefaultInstance.BufferTime1);
                dateTimePickerRepeatRecordTime.Value = DateTime.Today.Add(Settings.DefaultInstance.RepeatRecordTime1);
                dateTimePickerWorkOverTime.Value = DateTime.Today.Add(Settings.DefaultInstance.WorkOverTime1);

                radioButtonHoliday.BackColor = SystemColors.Control;
                radioButtonSummer.BackColor = Color.LightCoral;
                radioButtonWinter.BackColor = SystemColors.Control;
            }
            else if (radioButtonWinter.Checked)
            {
                dateTimePickerAMStartTime.Value = DateTime.Today.Add(Settings.DefaultInstance.AMStartTime2);
                dateTimePickerAMEndTime.Value = DateTime.Today.Add(Settings.DefaultInstance.AMEndTime2);
                dateTimePickerPMStartTime.Value = DateTime.Today.Add(Settings.DefaultInstance.PMStartTime2);
                dateTimePickerPMEndTime.Value = DateTime.Today.Add(Settings.DefaultInstance.PMEndTime2);
                dateTimePickerBufferTime.Value = DateTime.Today.Add(Settings.DefaultInstance.BufferTime2);
                dateTimePickerRepeatRecordTime.Value = DateTime.Today.Add(Settings.DefaultInstance.RepeatRecordTime2);
                dateTimePickerWorkOverTime.Value = DateTime.Today.Add(Settings.DefaultInstance.WorkOverTime2);

                radioButtonHoliday.BackColor = SystemColors.Control;
                radioButtonSummer.BackColor = SystemColors.Control;
                radioButtonWinter.BackColor = Color.LightBlue;
            }
            else if (radioButtonHoliday.Checked)
            {
                dateTimePickerAMStartTime.Value = DateTime.Today.Add(Settings.DefaultInstance.AMStartTime3);
                dateTimePickerAMEndTime.Value = DateTime.Today.Add(Settings.DefaultInstance.AMEndTime3);
                dateTimePickerPMStartTime.Value = DateTime.Today.Add(Settings.DefaultInstance.PMStartTime3);
                dateTimePickerPMEndTime.Value = DateTime.Today.Add(Settings.DefaultInstance.PMEndTime3);
                dateTimePickerBufferTime.Value = DateTime.Today.Add(Settings.DefaultInstance.BufferTime3);
                dateTimePickerRepeatRecordTime.Value = DateTime.Today.Add(Settings.DefaultInstance.RepeatRecordTime3);
                dateTimePickerWorkOverTime.Value = DateTime.Today.Add(Settings.DefaultInstance.WorkOverTime3);

                radioButtonHoliday.BackColor = Color.LightYellow;
                radioButtonSummer.BackColor = SystemColors.Control;
                radioButtonWinter.BackColor = SystemColors.Control;
            }
        }

        //设定完成
        private void buttonSetTimeRuleOK_Click(object sender, EventArgs e)
        {
            if (radioButtonSummer.Checked)
            {
                Settings.DefaultInstance.AMStartTime1 = dateTimePickerAMStartTime.Value - dateTimePickerAMStartTime.Value.Date;
                Settings.DefaultInstance.AMEndTime1 = dateTimePickerAMEndTime.Value - dateTimePickerAMEndTime.Value.Date;
                Settings.DefaultInstance.PMStartTime1 = dateTimePickerPMStartTime.Value - dateTimePickerPMStartTime.Value.Date;
                Settings.DefaultInstance.PMEndTime1 = dateTimePickerPMEndTime.Value - dateTimePickerPMEndTime.Value.Date;
                Settings.DefaultInstance.BufferTime1 = dateTimePickerBufferTime.Value - dateTimePickerBufferTime.Value.Date;
                Settings.DefaultInstance.RepeatRecordTime1 = dateTimePickerRepeatRecordTime.Value - dateTimePickerRepeatRecordTime.Value.Date;
                Settings.DefaultInstance.WorkOverTime1 = dateTimePickerWorkOverTime.Value - dateTimePickerWorkOverTime.Value.Date;

                staffWorkStatistics.WorkTimeRule.AMStartTime = Settings.DefaultInstance.AMStartTime1;
                staffWorkStatistics.WorkTimeRule.AMEndTime = Settings.DefaultInstance.AMEndTime1;
                staffWorkStatistics.WorkTimeRule.PMStartTime = Settings.DefaultInstance.PMStartTime1;
                staffWorkStatistics.WorkTimeRule.PMEndTime = Settings.DefaultInstance.PMEndTime1;
                staffWorkStatistics.WorkTimeRule.BufferTime = Settings.DefaultInstance.BufferTime1;
                staffWorkStatistics.WorkTimeRule.RepeatRecordTime = Settings.DefaultInstance.RepeatRecordTime1;
                staffWorkStatistics.WorkTimeRule.WorkOverTime = Settings.DefaultInstance.WorkOverTime1;
            }
            else if (radioButtonWinter.Checked)
            {
                Settings.DefaultInstance.AMStartTime2 = dateTimePickerAMStartTime.Value - dateTimePickerAMStartTime.Value.Date;
                Settings.DefaultInstance.AMEndTime2 = dateTimePickerAMEndTime.Value - dateTimePickerAMEndTime.Value.Date;
                Settings.DefaultInstance.PMStartTime2 = dateTimePickerPMStartTime.Value - dateTimePickerPMStartTime.Value.Date;
                Settings.DefaultInstance.PMEndTime2 = dateTimePickerPMEndTime.Value - dateTimePickerPMEndTime.Value.Date;
                Settings.DefaultInstance.BufferTime2 = dateTimePickerBufferTime.Value - dateTimePickerBufferTime.Value.Date;
                Settings.DefaultInstance.RepeatRecordTime2 = dateTimePickerRepeatRecordTime.Value - dateTimePickerRepeatRecordTime.Value.Date;
                Settings.DefaultInstance.WorkOverTime2 = dateTimePickerWorkOverTime.Value - dateTimePickerWorkOverTime.Value.Date;

                staffWorkStatistics.WorkTimeRule.AMStartTime = Settings.DefaultInstance.AMStartTime2;
                staffWorkStatistics.WorkTimeRule.AMEndTime = Settings.DefaultInstance.AMEndTime2;
                staffWorkStatistics.WorkTimeRule.PMStartTime = Settings.DefaultInstance.PMStartTime2;
                staffWorkStatistics.WorkTimeRule.PMEndTime = Settings.DefaultInstance.PMEndTime2;
                staffWorkStatistics.WorkTimeRule.BufferTime = Settings.DefaultInstance.BufferTime2;
                staffWorkStatistics.WorkTimeRule.RepeatRecordTime = Settings.DefaultInstance.RepeatRecordTime2;
                staffWorkStatistics.WorkTimeRule.WorkOverTime = Settings.DefaultInstance.WorkOverTime2;
            }
            else if (radioButtonHoliday.Checked)
            {
                Settings.DefaultInstance.AMStartTime3 = dateTimePickerAMStartTime.Value - dateTimePickerAMStartTime.Value.Date;
                Settings.DefaultInstance.AMEndTime3 = dateTimePickerAMEndTime.Value - dateTimePickerAMEndTime.Value.Date;
                Settings.DefaultInstance.PMStartTime3 = dateTimePickerPMStartTime.Value - dateTimePickerPMStartTime.Value.Date;
                Settings.DefaultInstance.PMEndTime3 = dateTimePickerPMEndTime.Value - dateTimePickerPMEndTime.Value.Date;
                Settings.DefaultInstance.BufferTime3 = dateTimePickerBufferTime.Value - dateTimePickerBufferTime.Value.Date;
                Settings.DefaultInstance.RepeatRecordTime3 = dateTimePickerRepeatRecordTime.Value - dateTimePickerRepeatRecordTime.Value.Date;
                Settings.DefaultInstance.WorkOverTime3 = dateTimePickerWorkOverTime.Value - dateTimePickerWorkOverTime.Value.Date;

                staffWorkStatistics.WorkTimeRule.AMStartTime = Settings.DefaultInstance.AMStartTime2;
                staffWorkStatistics.WorkTimeRule.AMEndTime = Settings.DefaultInstance.AMEndTime2;
                staffWorkStatistics.WorkTimeRule.PMStartTime = Settings.DefaultInstance.PMStartTime2;
                staffWorkStatistics.WorkTimeRule.PMEndTime = Settings.DefaultInstance.PMEndTime2;
                staffWorkStatistics.WorkTimeRule.BufferTime = Settings.DefaultInstance.BufferTime2;
                staffWorkStatistics.WorkTimeRule.RepeatRecordTime = Settings.DefaultInstance.RepeatRecordTime2;
                staffWorkStatistics.WorkTimeRule.WorkOverTime = Settings.DefaultInstance.WorkOverTime2;
            }

            Settings.DefaultInstance.Save();

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
