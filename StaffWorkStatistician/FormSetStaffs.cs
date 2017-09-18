using System;
using System.Windows.Forms;
using StaffWorkStatisticianCore;

namespace StaffWorkStatistician
{
    public partial class FormSetStaffs : Form
    {
        private StaffWorkStatistics staffWorkStatistics;

        public FormSetStaffs(StaffWorkStatistics staffWorkStatistics)
        {
            InitializeComponent();

            this.staffWorkStatistics = staffWorkStatistics;
            foreach (int staffId in staffWorkStatistics.Staffs.Keys)
            {
                Staff staff = Settings.DefaultInstance.IsContainStaffId(staffId);
                if (staff != null)
                {
                    dataGridViewStaffs.Rows.Add(staffId, staff.Name);
                }
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridViewStaffs.Rows.Count; i++)
            {
                int staffId = (int) dataGridViewStaffs[0, i].Value;
                Staff staff = Settings.DefaultInstance.IsContainStaffId(staffId);
                if (staff != null)
                {
                    staff.Name = dataGridViewStaffs[1, i].Value.ToString();
                    staffWorkStatistics.Staffs[staffId].Name = staff.Name;
                }
            }

            Settings.DefaultInstance.Save();
            this.DialogResult = DialogResult.OK;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
