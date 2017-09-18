using System;
using System.Windows.Forms;
using StaffWorkStatisticianCore;

namespace StaffWorkStatistician
{
    public partial class FormSetDateRule : Form
    {
        private bool isUserChange, isDateTimeChange;
        private StaffWorkStatistics staffWorkStatistics;

        public FormSetDateRule(StaffWorkStatistics staffWorkStatistics)
        {
            InitializeComponent();

            this.staffWorkStatistics = staffWorkStatistics;

            SetWorkDateRule();

            isUserChange = true;
            isDateTimeChange = false;
        }

        //给每个职员设置上班时间和加班倍数
        private void SetWorkDateRule()
        {
            splitContainerSetting.Visible = true;

            checkedListBoxStaffList.Items.Clear();
            foreach (int id in staffWorkStatistics.Staffs.Keys)
            {
                string itemText = id + "(" + staffWorkStatistics.Staffs[id].Name + ")";
                checkedListBoxStaffList.Items.Add(itemText, true);
            }

            dateTimePickerStartTime.Value = staffWorkStatistics.GetEarlistTime();
            dateTimePickerEndTime.Value = staffWorkStatistics.GetLatestTime();
            userControlCalendar1.UpdateSettingCalendar(dateTimePickerStartTime.Value, dateTimePickerEndTime.Value);
        }

        private void dateTimePickerStartEndTime_CloseUp(object sender, EventArgs e)
        {
            if (isUserChange && isDateTimeChange)
            {
                userControlCalendar1.UpdateSettingCalendar(dateTimePickerStartTime.Value, dateTimePickerEndTime.Value);
                isDateTimeChange = false;
            }
        }

        private void dateTimePickerStartEndTime_ValueChanged(object sender, EventArgs e)
        {
            isDateTimeChange = true;
        }

        //设定完成
        private void buttonSetOK_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBoxStaffList.CheckedItems.Count; i++)
            {
                string itemText = checkedListBoxStaffList.CheckedItems[i].ToString();
                itemText = itemText.Remove(itemText.IndexOf("("));
                int id = int.Parse(itemText);
                staffWorkStatistics.Staffs[id].WorkDateRules = userControlCalendar1.TimeRuleList;
            }

            while (checkedListBoxStaffList.CheckedItems.Count > 0)
            {
                checkedListBoxStaffList.Items.RemoveAt(checkedListBoxStaffList.CheckedIndices[0]);
            }

            if (checkedListBoxStaffList.Items.Count == 0)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

    }
}
