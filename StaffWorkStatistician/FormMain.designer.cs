namespace StaffWorkStatistician
{
    partial class FormMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.toolStripStatistics = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonOpen = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonSetting = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripMenuItemSetDateRule = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSetTimeRule = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSetStaff = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonStatistic = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonHelp = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.dateTimePicker7 = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.treeViewStaffList = new System.Windows.Forms.TreeView();
            this.userControlCalendarShowing = new StaffWorkStatistician.UserControlCalendar();
            this.toolStripStatistics.SuspendLayout();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripStatistics
            // 
            this.toolStripStatistics.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonOpen,
            this.toolStripSeparator1,
            this.toolStripButtonSetting,
            this.toolStripSeparator2,
            this.toolStripButtonStatistic,
            this.toolStripSeparator3,
            this.toolStripButtonHelp,
            this.toolStripSeparator4});
            this.toolStripStatistics.Location = new System.Drawing.Point(0, 0);
            this.toolStripStatistics.Name = "toolStripStatistics";
            this.toolStripStatistics.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStripStatistics.Size = new System.Drawing.Size(994, 27);
            this.toolStripStatistics.TabIndex = 0;
            this.toolStripStatistics.Text = "toolStripStatistic";
            // 
            // toolStripButtonOpen
            // 
            this.toolStripButtonOpen.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStripButtonOpen.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonOpen.Image")));
            this.toolStripButtonOpen.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.toolStripButtonOpen.Name = "toolStripButtonOpen";
            this.toolStripButtonOpen.Size = new System.Drawing.Size(78, 24);
            this.toolStripButtonOpen.Text = "打开(&O)";
            this.toolStripButtonOpen.Click += new System.EventHandler(this.打开OToolStripButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButtonSetting
            // 
            this.toolStripButtonSetting.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemSetDateRule,
            this.toolStripMenuItemSetTimeRule,
            this.toolStripMenuItemSetStaff});
            this.toolStripButtonSetting.Enabled = false;
            this.toolStripButtonSetting.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStripButtonSetting.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSetting.Image")));
            this.toolStripButtonSetting.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSetting.Name = "toolStripButtonSetting";
            this.toolStripButtonSetting.Size = new System.Drawing.Size(84, 24);
            this.toolStripButtonSetting.Text = "设置(&E)";
            // 
            // toolStripMenuItemSetDateRule
            // 
            this.toolStripMenuItemSetDateRule.Name = "toolStripMenuItemSetDateRule";
            this.toolStripMenuItemSetDateRule.Size = new System.Drawing.Size(155, 24);
            this.toolStripMenuItemSetDateRule.Text = "设置日期(&D)";
            this.toolStripMenuItemSetDateRule.Click += new System.EventHandler(this.toolStripMenuItemSetDateRule_Click);
            // 
            // toolStripMenuItemSetTimeRule
            // 
            this.toolStripMenuItemSetTimeRule.Name = "toolStripMenuItemSetTimeRule";
            this.toolStripMenuItemSetTimeRule.Size = new System.Drawing.Size(155, 24);
            this.toolStripMenuItemSetTimeRule.Text = "设置时间(&T)";
            this.toolStripMenuItemSetTimeRule.Click += new System.EventHandler(this.toolStripMenuItemSetTimeRule_Click);
            // 
            // toolStripMenuItemSetStaff
            // 
            this.toolStripMenuItemSetStaff.Name = "toolStripMenuItemSetStaff";
            this.toolStripMenuItemSetStaff.Size = new System.Drawing.Size(155, 24);
            this.toolStripMenuItemSetStaff.Text = "设置职员(&C)";
            this.toolStripMenuItemSetStaff.Click += new System.EventHandler(this.toolStripMenuItemSetStaff_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButtonStatistic
            // 
            this.toolStripButtonStatistic.Enabled = false;
            this.toolStripButtonStatistic.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStripButtonStatistic.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonStatistic.Image")));
            this.toolStripButtonStatistic.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.toolStripButtonStatistic.Name = "toolStripButtonStatistic";
            this.toolStripButtonStatistic.Size = new System.Drawing.Size(75, 24);
            this.toolStripButtonStatistic.Text = "统计(&S)";
            this.toolStripButtonStatistic.Click += new System.EventHandler(this.toolStripButtonStatistic_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButtonHelp
            // 
            this.toolStripButtonHelp.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStripButtonHelp.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonHelp.Image")));
            this.toolStripButtonHelp.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.toolStripButtonHelp.Name = "toolStripButtonHelp";
            this.toolStripButtonHelp.Size = new System.Drawing.Size(77, 24);
            this.toolStripButtonHelp.Text = "关于(&A)";
            this.toolStripButtonHelp.Click += new System.EventHandler(this.toolStripButtonHelp_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 27);
            // 
            // dateTimePicker7
            // 
            this.dateTimePicker7.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker7.Location = new System.Drawing.Point(13, 20);
            this.dateTimePicker7.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.dateTimePicker7.Name = "dateTimePicker7";
            this.dateTimePicker7.ShowUpDown = true;
            this.dateTimePicker7.Size = new System.Drawing.Size(131, 21);
            this.dateTimePicker7.TabIndex = 19;
            this.dateTimePicker7.Value = new System.DateTime(2010, 9, 29, 8, 0, 0, 0);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMain.Location = new System.Drawing.Point(0, 27);
            this.splitContainerMain.Name = "splitContainerMain";
            // 
            // splitContainerMain.Panel1
            // 
            this.splitContainerMain.Panel1.Controls.Add(this.treeViewStaffList);
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.Controls.Add(this.userControlCalendarShowing);
            this.splitContainerMain.Size = new System.Drawing.Size(994, 541);
            this.splitContainerMain.SplitterDistance = 170;
            this.splitContainerMain.TabIndex = 2;
            // 
            // treeViewStaffList
            // 
            this.treeViewStaffList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewStaffList.Location = new System.Drawing.Point(0, 0);
            this.treeViewStaffList.Name = "treeViewStaffList";
            this.treeViewStaffList.Size = new System.Drawing.Size(170, 541);
            this.treeViewStaffList.TabIndex = 0;
            this.treeViewStaffList.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewStaffList_AfterSelect);
            // 
            // userControlCalendarShowing
            // 
            this.userControlCalendarShowing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlCalendarShowing.Location = new System.Drawing.Point(0, 0);
            this.userControlCalendarShowing.Name = "userControlCalendarShowing";
            this.userControlCalendarShowing.Size = new System.Drawing.Size(820, 541);
            this.userControlCalendarShowing.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 568);
            this.Controls.Add(this.splitContainerMain);
            this.Controls.Add(this.toolStripStatistics);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "职员考勤统计软件";
            this.toolStripStatistics.ResumeLayout(false);
            this.toolStripStatistics.PerformLayout();
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel2.ResumeLayout(false);
            this.splitContainerMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripStatistics;
        private System.Windows.Forms.ToolStripButton toolStripButtonOpen;
        private System.Windows.Forms.DateTimePicker dateTimePicker7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.ToolStripButton toolStripButtonStatistic;
        private System.Windows.Forms.ToolStripButton toolStripButtonHelp;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.TreeView treeViewStaffList;
        private UserControlCalendar userControlCalendarShowing;
        private System.Windows.Forms.ToolStripDropDownButton toolStripButtonSetting;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSetDateRule;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSetTimeRule;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSetStaff;
    }
}

