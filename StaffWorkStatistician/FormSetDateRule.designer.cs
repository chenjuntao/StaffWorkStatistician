namespace StaffWorkStatistician
{
    partial class FormSetDateRule
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainerSetting = new System.Windows.Forms.SplitContainer();
            this.groupBoxStaffList = new System.Windows.Forms.GroupBox();
            this.checkedListBoxStaffList = new System.Windows.Forms.CheckedListBox();
            this.panelSetting = new System.Windows.Forms.Panel();
            this.buttonSetDateOK = new System.Windows.Forms.Button();
            this.dateTimePickerEndTime = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerStartTime = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.userControlCalendar1 = new StaffWorkStatistician.UserControlCalendar();
            this.splitContainerSetting.Panel1.SuspendLayout();
            this.splitContainerSetting.Panel2.SuspendLayout();
            this.splitContainerSetting.SuspendLayout();
            this.groupBoxStaffList.SuspendLayout();
            this.panelSetting.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerSetting
            // 
            this.splitContainerSetting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerSetting.Location = new System.Drawing.Point(0, 0);
            this.splitContainerSetting.Name = "splitContainerSetting";
            // 
            // splitContainerSetting.Panel1
            // 
            this.splitContainerSetting.Panel1.Controls.Add(this.groupBoxStaffList);
            // 
            // splitContainerSetting.Panel2
            // 
            this.splitContainerSetting.Panel2.Controls.Add(this.userControlCalendar1);
            this.splitContainerSetting.Panel2.Controls.Add(this.panelSetting);
            this.splitContainerSetting.Size = new System.Drawing.Size(942, 474);
            this.splitContainerSetting.SplitterDistance = 173;
            this.splitContainerSetting.TabIndex = 6;
            this.splitContainerSetting.Visible = false;
            // 
            // groupBoxStaffList
            // 
            this.groupBoxStaffList.Controls.Add(this.checkedListBoxStaffList);
            this.groupBoxStaffList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxStaffList.Location = new System.Drawing.Point(0, 0);
            this.groupBoxStaffList.Name = "groupBoxStaffList";
            this.groupBoxStaffList.Size = new System.Drawing.Size(173, 474);
            this.groupBoxStaffList.TabIndex = 4;
            this.groupBoxStaffList.TabStop = false;
            this.groupBoxStaffList.Text = "职员列表";
            // 
            // checkedListBoxStaffList
            // 
            this.checkedListBoxStaffList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkedListBoxStaffList.FormattingEnabled = true;
            this.checkedListBoxStaffList.Location = new System.Drawing.Point(3, 17);
            this.checkedListBoxStaffList.Name = "checkedListBoxStaffList";
            this.checkedListBoxStaffList.Size = new System.Drawing.Size(167, 452);
            this.checkedListBoxStaffList.TabIndex = 2;
            // 
            // panelSetting
            // 
            this.panelSetting.Controls.Add(this.buttonSetDateOK);
            this.panelSetting.Controls.Add(this.dateTimePickerEndTime);
            this.panelSetting.Controls.Add(this.label2);
            this.panelSetting.Controls.Add(this.dateTimePickerStartTime);
            this.panelSetting.Controls.Add(this.label1);
            this.panelSetting.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelSetting.Location = new System.Drawing.Point(0, 452);
            this.panelSetting.Name = "panelSetting";
            this.panelSetting.Size = new System.Drawing.Size(765, 22);
            this.panelSetting.TabIndex = 1;
            // 
            // buttonSetDateOK
            // 
            this.buttonSetDateOK.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonSetDateOK.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonSetDateOK.Location = new System.Drawing.Point(665, 0);
            this.buttonSetDateOK.Name = "buttonSetDateOK";
            this.buttonSetDateOK.Size = new System.Drawing.Size(100, 22);
            this.buttonSetDateOK.TabIndex = 18;
            this.buttonSetDateOK.Text = "设 定 完 成";
            this.buttonSetDateOK.UseVisualStyleBackColor = true;
            this.buttonSetDateOK.Click += new System.EventHandler(this.buttonSetOK_Click);
            // 
            // dateTimePickerEndTime
            // 
            this.dateTimePickerEndTime.Dock = System.Windows.Forms.DockStyle.Left;
            this.dateTimePickerEndTime.Location = new System.Drawing.Point(290, 0);
            this.dateTimePickerEndTime.Name = "dateTimePickerEndTime";
            this.dateTimePickerEndTime.Size = new System.Drawing.Size(110, 21);
            this.dateTimePickerEndTime.TabIndex = 17;
            this.dateTimePickerEndTime.ValueChanged += new System.EventHandler(this.dateTimePickerStartEndTime_ValueChanged);
            this.dateTimePickerEndTime.CloseUp += new System.EventHandler(this.dateTimePickerStartEndTime_CloseUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(200, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 21);
            this.label2.TabIndex = 20;
            this.label2.Text = "终止时间：";
            // 
            // dateTimePickerStartTime
            // 
            this.dateTimePickerStartTime.Dock = System.Windows.Forms.DockStyle.Left;
            this.dateTimePickerStartTime.Location = new System.Drawing.Point(90, 0);
            this.dateTimePickerStartTime.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.dateTimePickerStartTime.Name = "dateTimePickerStartTime";
            this.dateTimePickerStartTime.Size = new System.Drawing.Size(110, 21);
            this.dateTimePickerStartTime.TabIndex = 16;
            this.dateTimePickerStartTime.ValueChanged += new System.EventHandler(this.dateTimePickerStartEndTime_ValueChanged);
            this.dateTimePickerStartTime.CloseUp += new System.EventHandler(this.dateTimePickerStartEndTime_CloseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 21);
            this.label1.TabIndex = 19;
            this.label1.Text = "起始时间：";
            // 
            // userControlCalendar1
            // 
            this.userControlCalendar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlCalendar1.Location = new System.Drawing.Point(0, 0);
            this.userControlCalendar1.Name = "userControlCalendar1";
            this.userControlCalendar1.Size = new System.Drawing.Size(765, 452);
            this.userControlCalendar1.TabIndex = 10;
            // 
            // FormSetDateRule
            // 
            this.AcceptButton = this.buttonSetDateOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 474);
            this.Controls.Add(this.splitContainerSetting);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FormSetDateRule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSetDateRule";
            this.splitContainerSetting.Panel1.ResumeLayout(false);
            this.splitContainerSetting.Panel2.ResumeLayout(false);
            this.splitContainerSetting.ResumeLayout(false);
            this.groupBoxStaffList.ResumeLayout(false);
            this.panelSetting.ResumeLayout(false);
            this.panelSetting.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainerSetting;
        private System.Windows.Forms.GroupBox groupBoxStaffList;
        private System.Windows.Forms.CheckedListBox checkedListBoxStaffList;
        private UserControlCalendar userControlCalendar1;
        private System.Windows.Forms.Panel panelSetting;
        private System.Windows.Forms.Button buttonSetDateOK;
        private System.Windows.Forms.DateTimePicker dateTimePickerEndTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerStartTime;
        private System.Windows.Forms.Label label1;
    }
}