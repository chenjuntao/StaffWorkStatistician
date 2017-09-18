using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using StaffWorkStatisticianCore;

namespace StaffWorkStatistician
{
    public partial class FormMain : Form
    {
        private StaffWorkStatistics staffWorkStatistics;

        public FormMain()
        {
            InitializeComponent();
        }

        private void 打开OToolStripButton_Click(object sender, EventArgs e)
        {
            staffWorkStatistics = new StaffWorkStatistics();
            OpenFileDialog openFileDlg = new OpenFileDialog();
            openFileDlg.Filter = "csv|*.csv";
            openFileDlg.Multiselect = false;
            if (openFileDlg.ShowDialog() == DialogResult.OK)
            {
                toolStripButtonSetting.Enabled = false;
                toolStripButtonStatistic.Enabled = false;
                userControlCalendarShowing.ClearAllItems();

                using (StreamReader sr = new StreamReader(openFileDlg.FileName))
                {
                    try
                    {
                        string line = sr.ReadLine();
                        while (line != null)
                        {
                            string[] strList = line.Split(',');
                            int id = int.Parse(strList[0]);
                            DateTime dateTime = DateTime.Parse(strList[1]);
                            if (!staffWorkStatistics.Staffs.ContainsKey(id))
                            {
                                Staff staff = new Staff();
                                staff.Id = id;
                                staff.Records.Add(dateTime);
                                staffWorkStatistics.Staffs.Add(id, staff);
                            }
                            else
                            {
                                staffWorkStatistics.Staffs[id].Records.Add(dateTime);
                            }
                            line = sr.ReadLine();
                        }

                        //从配置文件中给每个职员命名（如果是新的则将其加入配置文件中，如果不是新的则从配置文件中根据其ID检索其姓名）
                        foreach (int staffId in staffWorkStatistics.Staffs.Keys)
                        {
                            Staff staff = Settings.DefaultInstance.IsContainStaffId(staffId);
                            if (staff != null)
                            {
                                staffWorkStatistics.Staffs[staffId].Name = staff.Name;
                            }
                            else
                            {
                                Settings.DefaultInstance.Staffs.Add(staffWorkStatistics.Staffs[staffId]);
                            }
                        }

                        FormSetDateRule formSetDateRule = new FormSetDateRule(staffWorkStatistics);
                        if (formSetDateRule.ShowDialog() == DialogResult.OK)
                        {
                            FormSetTimeRule formSetTimeRule = new FormSetTimeRule(staffWorkStatistics);
                            if (formSetTimeRule.ShowDialog() == DialogResult.OK)
                            {
                                toolStripButtonSetting.Enabled = true;
                                toolStripButtonStatistic.Enabled = true;
                                Text = "职员考勤统计软件 - " + openFileDlg.FileName;

                                treeViewStaffList.Nodes.Clear();
                                foreach (Staff staff in staffWorkStatistics.Staffs.Values)
                                {
                                    TreeNode staffNode = new TreeNode(staff.Id + "(" + staff.Name + ")打卡" + staff.Records.Count + "次");
                                    staffNode.Tag = staff.Id;
                                    treeViewStaffList.Nodes.Add(staffNode);
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        staffWorkStatistics.Staffs.Clear();
                    }
                }
            }
        }

        //设置日期规则
        private void toolStripMenuItemSetDateRule_Click(object sender, EventArgs e)
        {
            FormSetDateRule formSetDateRule = new FormSetDateRule(staffWorkStatistics);
            if (formSetDateRule.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i < treeViewStaffList.Nodes.Count; i++)
                {
                    treeViewStaffList.Nodes[i].Nodes.Clear();
                } 
                userControlCalendarShowing.ClearAllItems();
            }
        }

        //设置时间规则
        private void toolStripMenuItemSetTimeRule_Click(object sender, EventArgs e)
        {
            FormSetTimeRule formSetTimeRule = new FormSetTimeRule(staffWorkStatistics);
            if (formSetTimeRule.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i < treeViewStaffList.Nodes.Count; i++)
                {
                    treeViewStaffList.Nodes[i].Nodes.Clear(); 
                }
                userControlCalendarShowing.ClearAllItems();
            }
        }

        //设置职员
        private void toolStripMenuItemSetStaff_Click(object sender, EventArgs e)
        {
            FormSetStaffs formSetStaffs = new FormSetStaffs(staffWorkStatistics);
            if (formSetStaffs.ShowDialog() == DialogResult.OK)
            {
                treeViewStaffList.Nodes.Clear();
                foreach (Staff staff in staffWorkStatistics.Staffs.Values)
                {
                    TreeNode staffNode = new TreeNode(staff.Id + "(" + staff.Name + ")打卡" + staff.Records.Count + "次");
                    staffNode.Tag = staff.Id;
                    treeViewStaffList.Nodes.Add(staffNode);
                }
            }
        }

        //统计
        private void toolStripButtonStatistic_Click(object sender, EventArgs e)
        {
            staffWorkStatistics.Statistic();
            treeViewStaffList.Nodes.Clear();
            foreach (Staff staff in staffWorkStatistics.Staffs.Values)
            {
                TreeNode staffNode = new TreeNode(staff.Id + "(" + staff.Name + ")打卡" + staff.Records.Count + "次");
                staffNode.Tag = staff.Id;
                treeViewStaffList.Nodes.Add(staffNode);

                double workOvertimeRecordsTimes = 0;
                for (int i = 0; i < staff.WorkOverTimeRecords.Count; i++)
                {
                    workOvertimeRecordsTimes += staff.WorkOverTimeRecords[i].Multiple;
                }
                TreeNode workOvertimeNode = new TreeNode("加班" + workOvertimeRecordsTimes + "次");
                staffNode.Nodes.Add(workOvertimeNode);

                TreeNode workComeLateNode = new TreeNode("迟到" + staff.WorkComeLateRecords.Count + "次");
                staffNode.Nodes.Add(workComeLateNode);

                TreeNode workGoEarlyNode = new TreeNode("早退" + staff.WorkGoEarlyRecords.Count + "次");
                staffNode.Nodes.Add(workGoEarlyNode);

                TreeNode workComeNoRecordsNode = new TreeNode("来未打卡" + staff.WorkComeNoRecords.Count + "次");
                staffNode.Nodes.Add(workComeNoRecordsNode);

                TreeNode workGoNoRecordsNode = new TreeNode("走未打卡" + staff.WorkGoNoRecords.Count + "次");
                staffNode.Nodes.Add(workGoNoRecordsNode);

                TreeNode workNoRecordsNode = new TreeNode("旷工" + staff.WorkNoRecords.Count + "次");
                staffNode.Nodes.Add(workNoRecordsNode);

                TreeNode workExceptionRecordsNode = new TreeNode("异常打卡" + staff.WorkExceptionRecords.Count + "次");
                staffNode.Nodes.Add(workExceptionRecordsNode);
            }
            treeViewStaffList.ExpandAll();
        }

        //选中节点之后
        private void treeViewStaffList_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (staffWorkStatistics.Staffs.Count > 0)
            {
                if (e.Node.Text.StartsWith("加班"))
                {
                    Staff staff = staffWorkStatistics.Staffs[(int) e.Node.Parent.Tag];
                    List<DateTime> workOvertimeRecords = new List<DateTime>();
                    for (int i = 0; i < staff.WorkOverTimeRecords.Count; i++)
                    {
                        workOvertimeRecords.Add(staff.WorkOverTimeRecords[i].starTime);
                        workOvertimeRecords.Add(staff.WorkOverTimeRecords[i].endTime);
                        if (staff.WorkOverTimeRecords[i].Multiple > 1)
                        {
                            workOvertimeRecords.Add(staff.WorkOverTimeRecords[i].starTime);
                            workOvertimeRecords.Add(staff.WorkOverTimeRecords[i].endTime);
                        }
                        if (staff.WorkOverTimeRecords[i].Multiple > 2)
                        {
                            workOvertimeRecords.Add(staff.WorkOverTimeRecords[i].starTime);
                            workOvertimeRecords.Add(staff.WorkOverTimeRecords[i].endTime);
                        }
                    }
                    userControlCalendarShowing.UpdateShowingCalendar(staffWorkStatistics.GetEarlistTime(),
                                                                     staffWorkStatistics.GetLatestTime(), staff.Records,
                                                                     workOvertimeRecords);
                }
                else if (e.Node.Text.StartsWith("迟到"))
                {
                    Staff staff = staffWorkStatistics.Staffs[(int) e.Node.Parent.Tag];
                    userControlCalendarShowing.UpdateShowingCalendar(staffWorkStatistics.GetEarlistTime(),
                                                                     staffWorkStatistics.GetLatestTime(), staff.Records,
                                                                     staff.WorkComeLateRecords);
                }
                else if (e.Node.Text.StartsWith("早退"))
                {
                    Staff staff = staffWorkStatistics.Staffs[(int) e.Node.Parent.Tag];
                    userControlCalendarShowing.UpdateShowingCalendar(staffWorkStatistics.GetEarlistTime(),
                                                                     staffWorkStatistics.GetLatestTime(), staff.Records,
                                                                     staff.WorkGoEarlyRecords);
                }
                else if (e.Node.Text.StartsWith("来未打卡"))
                {
                    Staff staff = staffWorkStatistics.Staffs[(int) e.Node.Parent.Tag];
                    userControlCalendarShowing.UpdateShowingCalendar(staffWorkStatistics.GetEarlistTime(),
                                                                     staffWorkStatistics.GetLatestTime(), staff.Records,
                                                                     staff.WorkComeNoRecords);
                }
                else if (e.Node.Text.StartsWith("走未打卡"))
                {
                    Staff staff = staffWorkStatistics.Staffs[(int) e.Node.Parent.Tag];
                    userControlCalendarShowing.UpdateShowingCalendar(staffWorkStatistics.GetEarlistTime(),
                                                                     staffWorkStatistics.GetLatestTime(), staff.Records,
                                                                     staff.WorkGoNoRecords);
                }
                else if (e.Node.Text.StartsWith("旷工"))
                {
                    Staff staff = staffWorkStatistics.Staffs[(int) e.Node.Parent.Tag];
                    userControlCalendarShowing.UpdateShowingCalendar(staffWorkStatistics.GetEarlistTime(),
                                                                     staffWorkStatistics.GetLatestTime(), staff.Records,
                                                                     staff.WorkNoRecords);
                }
                else if (e.Node.Text.StartsWith("异常打卡"))
                {
                    Staff staff = staffWorkStatistics.Staffs[(int) e.Node.Parent.Tag];
                    userControlCalendarShowing.UpdateShowingCalendar(staffWorkStatistics.GetEarlistTime(),
                                                                     staffWorkStatistics.GetLatestTime(), staff.Records,
                                                                     staff.WorkExceptionRecords);
                }
                else
                {
                    Staff staff = staffWorkStatistics.Staffs[(int) e.Node.Tag];
                    userControlCalendarShowing.UpdateShowingCalendar(staffWorkStatistics.GetEarlistTime(),
                                                                     staffWorkStatistics.GetLatestTime(), staff.Records,
                                                                     new List<DateTime>());
                }
            }
        }

        //帮助
        private void toolStripButtonHelp_Click(object sender, EventArgs e)
        {
            AboutBox aboutBox = new AboutBox();
            aboutBox.ShowDialog();
        }
    }
}