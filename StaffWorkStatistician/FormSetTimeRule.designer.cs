namespace StaffWorkStatistician
{
    partial class FormSetTimeRule
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dateTimePickerRepeatRecordTime = new System.Windows.Forms.DateTimePicker();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.radioButtonSummer = new System.Windows.Forms.RadioButton();
            this.radioButtonWinter = new System.Windows.Forms.RadioButton();
            this.radioButtonHoliday = new System.Windows.Forms.RadioButton();
            this.groupBoxTimeSetting = new System.Windows.Forms.GroupBox();
            this.dateTimePickerAMStartTime = new System.Windows.Forms.DateTimePicker();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dateTimePickerBufferTime = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePickerPMStartTime = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dateTimePickerAMEndTime = new System.Windows.Forms.DateTimePicker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dateTimePickerPMEndTime = new System.Windows.Forms.DateTimePicker();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.dateTimePickerWorkOverTime = new System.Windows.Forms.DateTimePicker();
            this.buttonSetTimeRuleOK = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBoxTimeSetting.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 146F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox5, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.groupBox7, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBoxTimeSetting, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox3, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox6, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.buttonSetTimeRuleOK, 2, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(14, 14);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(526, 237);
            this.tableLayoutPanel1.TabIndex = 30;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dateTimePickerRepeatRecordTime);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Location = new System.Drawing.Point(5, 185);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(180, 47);
            this.groupBox5.TabIndex = 38;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "多次刷卡算作一次的时间间隔";
            // 
            // dateTimePickerRepeatRecordTime
            // 
            this.dateTimePickerRepeatRecordTime.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerRepeatRecordTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerRepeatRecordTime.Location = new System.Drawing.Point(13, 20);
            this.dateTimePickerRepeatRecordTime.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.dateTimePickerRepeatRecordTime.Name = "dateTimePickerRepeatRecordTime";
            this.dateTimePickerRepeatRecordTime.ShowUpDown = true;
            this.dateTimePickerRepeatRecordTime.Size = new System.Drawing.Size(161, 21);
            this.dateTimePickerRepeatRecordTime.TabIndex = 19;
            this.dateTimePickerRepeatRecordTime.Value = new System.DateTime(2010, 9, 29, 8, 0, 0, 0);
            // 
            // groupBox7
            // 
            this.groupBox7.AutoSize = true;
            this.groupBox7.Controls.Add(this.tableLayoutPanel2);
            this.groupBox7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox7.Location = new System.Drawing.Point(383, 3);
            this.groupBox7.Name = "groupBox7";
            this.tableLayoutPanel1.SetRowSpan(this.groupBox7, 3);
            this.groupBox7.Size = new System.Drawing.Size(140, 174);
            this.groupBox7.TabIndex = 28;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "设定选择";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.radioButtonSummer, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.radioButtonWinter, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.radioButtonHoliday, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 17);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(134, 154);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // radioButtonSummer
            // 
            this.radioButtonSummer.AutoSize = true;
            this.radioButtonSummer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButtonSummer.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButtonSummer.ForeColor = System.Drawing.Color.Black;
            this.radioButtonSummer.Location = new System.Drawing.Point(5, 5);
            this.radioButtonSummer.Margin = new System.Windows.Forms.Padding(5);
            this.radioButtonSummer.Name = "radioButtonSummer";
            this.radioButtonSummer.Size = new System.Drawing.Size(124, 41);
            this.radioButtonSummer.TabIndex = 0;
            this.radioButtonSummer.TabStop = true;
            this.radioButtonSummer.Text = "夏季作息时间";
            this.radioButtonSummer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonSummer.UseVisualStyleBackColor = true;
            this.radioButtonSummer.CheckedChanged += new System.EventHandler(this.radioButtonTimeRule_CheckedChanged);
            // 
            // radioButtonWinter
            // 
            this.radioButtonWinter.AutoSize = true;
            this.radioButtonWinter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButtonWinter.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButtonWinter.ForeColor = System.Drawing.Color.Black;
            this.radioButtonWinter.Location = new System.Drawing.Point(5, 56);
            this.radioButtonWinter.Margin = new System.Windows.Forms.Padding(5);
            this.radioButtonWinter.Name = "radioButtonWinter";
            this.radioButtonWinter.Size = new System.Drawing.Size(124, 41);
            this.radioButtonWinter.TabIndex = 1;
            this.radioButtonWinter.TabStop = true;
            this.radioButtonWinter.Text = "冬季作息时间";
            this.radioButtonWinter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonWinter.UseVisualStyleBackColor = true;
            this.radioButtonWinter.CheckedChanged += new System.EventHandler(this.radioButtonTimeRule_CheckedChanged);
            // 
            // radioButtonHoliday
            // 
            this.radioButtonHoliday.AutoSize = true;
            this.radioButtonHoliday.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButtonHoliday.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButtonHoliday.ForeColor = System.Drawing.Color.Black;
            this.radioButtonHoliday.Location = new System.Drawing.Point(5, 107);
            this.radioButtonHoliday.Margin = new System.Windows.Forms.Padding(5);
            this.radioButtonHoliday.Name = "radioButtonHoliday";
            this.radioButtonHoliday.Size = new System.Drawing.Size(124, 42);
            this.radioButtonHoliday.TabIndex = 2;
            this.radioButtonHoliday.TabStop = true;
            this.radioButtonHoliday.Text = "假期作息时间";
            this.radioButtonHoliday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonHoliday.UseVisualStyleBackColor = true;
            this.radioButtonHoliday.CheckedChanged += new System.EventHandler(this.radioButtonTimeRule_CheckedChanged);
            // 
            // groupBoxTimeSetting
            // 
            this.groupBoxTimeSetting.Controls.Add(this.dateTimePickerAMStartTime);
            this.groupBoxTimeSetting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxTimeSetting.Location = new System.Drawing.Point(5, 5);
            this.groupBoxTimeSetting.Margin = new System.Windows.Forms.Padding(5);
            this.groupBoxTimeSetting.Name = "groupBoxTimeSetting";
            this.groupBoxTimeSetting.Size = new System.Drawing.Size(180, 47);
            this.groupBoxTimeSetting.TabIndex = 33;
            this.groupBoxTimeSetting.TabStop = false;
            this.groupBoxTimeSetting.Text = "上午上班时间";
            // 
            // dateTimePickerAMStartTime
            // 
            this.dateTimePickerAMStartTime.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerAMStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerAMStartTime.Location = new System.Drawing.Point(13, 20);
            this.dateTimePickerAMStartTime.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.dateTimePickerAMStartTime.Name = "dateTimePickerAMStartTime";
            this.dateTimePickerAMStartTime.ShowUpDown = true;
            this.dateTimePickerAMStartTime.Size = new System.Drawing.Size(161, 21);
            this.dateTimePickerAMStartTime.TabIndex = 19;
            this.dateTimePickerAMStartTime.Value = new System.DateTime(2010, 9, 29, 8, 0, 0, 0);
            // 
            // groupBox4
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.groupBox4, 2);
            this.groupBox4.Controls.Add(this.dateTimePickerBufferTime);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(5, 119);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(370, 56);
            this.groupBox4.TabIndex = 37;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "上下班的缓冲时间，比上班规定的时间晚到或者比下班规定的时间早走只要限制在这个时间范围内就不算迟到或者早退";
            // 
            // dateTimePickerBufferTime
            // 
            this.dateTimePickerBufferTime.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerBufferTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerBufferTime.Location = new System.Drawing.Point(13, 29);
            this.dateTimePickerBufferTime.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.dateTimePickerBufferTime.Name = "dateTimePickerBufferTime";
            this.dateTimePickerBufferTime.ShowUpDown = true;
            this.dateTimePickerBufferTime.Size = new System.Drawing.Size(350, 21);
            this.dateTimePickerBufferTime.TabIndex = 19;
            this.dateTimePickerBufferTime.Value = new System.DateTime(2010, 9, 29, 8, 0, 0, 0);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePickerPMStartTime);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(5, 62);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(180, 47);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "下午上班时间";
            // 
            // dateTimePickerPMStartTime
            // 
            this.dateTimePickerPMStartTime.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerPMStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerPMStartTime.Location = new System.Drawing.Point(13, 20);
            this.dateTimePickerPMStartTime.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.dateTimePickerPMStartTime.Name = "dateTimePickerPMStartTime";
            this.dateTimePickerPMStartTime.ShowUpDown = true;
            this.dateTimePickerPMStartTime.Size = new System.Drawing.Size(161, 21);
            this.dateTimePickerPMStartTime.TabIndex = 19;
            this.dateTimePickerPMStartTime.Value = new System.DateTime(2010, 9, 29, 8, 0, 0, 0);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dateTimePickerAMEndTime);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(195, 5);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(180, 47);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "上午下班时间";
            // 
            // dateTimePickerAMEndTime
            // 
            this.dateTimePickerAMEndTime.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerAMEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerAMEndTime.Location = new System.Drawing.Point(13, 20);
            this.dateTimePickerAMEndTime.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.dateTimePickerAMEndTime.Name = "dateTimePickerAMEndTime";
            this.dateTimePickerAMEndTime.ShowUpDown = true;
            this.dateTimePickerAMEndTime.Size = new System.Drawing.Size(161, 21);
            this.dateTimePickerAMEndTime.TabIndex = 19;
            this.dateTimePickerAMEndTime.Value = new System.DateTime(2010, 9, 29, 8, 0, 0, 0);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dateTimePickerPMEndTime);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(195, 62);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(180, 47);
            this.groupBox3.TabIndex = 36;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "下午下班时间";
            // 
            // dateTimePickerPMEndTime
            // 
            this.dateTimePickerPMEndTime.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerPMEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerPMEndTime.Location = new System.Drawing.Point(13, 20);
            this.dateTimePickerPMEndTime.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.dateTimePickerPMEndTime.Name = "dateTimePickerPMEndTime";
            this.dateTimePickerPMEndTime.ShowUpDown = true;
            this.dateTimePickerPMEndTime.Size = new System.Drawing.Size(161, 21);
            this.dateTimePickerPMEndTime.TabIndex = 19;
            this.dateTimePickerPMEndTime.Value = new System.DateTime(2010, 9, 29, 8, 0, 0, 0);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.dateTimePickerWorkOverTime);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox6.Location = new System.Drawing.Point(195, 185);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(180, 47);
            this.groupBox6.TabIndex = 39;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "最短加班时长";
            // 
            // dateTimePickerWorkOverTime
            // 
            this.dateTimePickerWorkOverTime.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerWorkOverTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerWorkOverTime.Location = new System.Drawing.Point(13, 20);
            this.dateTimePickerWorkOverTime.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.dateTimePickerWorkOverTime.Name = "dateTimePickerWorkOverTime";
            this.dateTimePickerWorkOverTime.ShowUpDown = true;
            this.dateTimePickerWorkOverTime.Size = new System.Drawing.Size(161, 21);
            this.dateTimePickerWorkOverTime.TabIndex = 19;
            this.dateTimePickerWorkOverTime.Value = new System.DateTime(2010, 9, 29, 8, 0, 0, 0);
            // 
            // buttonSetTimeRuleOK
            // 
            this.buttonSetTimeRuleOK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSetTimeRuleOK.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonSetTimeRuleOK.Location = new System.Drawing.Point(385, 185);
            this.buttonSetTimeRuleOK.Margin = new System.Windows.Forms.Padding(5);
            this.buttonSetTimeRuleOK.Name = "buttonSetTimeRuleOK";
            this.buttonSetTimeRuleOK.Size = new System.Drawing.Size(136, 47);
            this.buttonSetTimeRuleOK.TabIndex = 41;
            this.buttonSetTimeRuleOK.Text = "设 定 完 成";
            this.buttonSetTimeRuleOK.UseVisualStyleBackColor = true;
            this.buttonSetTimeRuleOK.Click += new System.EventHandler(this.buttonSetTimeRuleOK_Click);
            // 
            // FormSetTimeRule
            // 
            this.AcceptButton = this.buttonSetTimeRuleOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 265);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormSetTimeRule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "设置时间规则";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.groupBoxTimeSetting.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DateTimePicker dateTimePickerRepeatRecordTime;
        private System.Windows.Forms.GroupBox groupBoxTimeSetting;
        private System.Windows.Forms.DateTimePicker dateTimePickerAMStartTime;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DateTimePicker dateTimePickerBufferTime;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePickerPMStartTime;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dateTimePickerAMEndTime;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker dateTimePickerPMEndTime;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.DateTimePicker dateTimePickerWorkOverTime;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.RadioButton radioButtonSummer;
        private System.Windows.Forms.RadioButton radioButtonWinter;
        private System.Windows.Forms.RadioButton radioButtonHoliday;
        private System.Windows.Forms.Button buttonSetTimeRuleOK;
    }
}