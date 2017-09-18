using System;
using System.Collections.Generic;

namespace StaffWorkStatisticianCore
{
    public class Staff
    {
        /// <summary>
        /// 职员ID
        /// </summary>
        private int id;
        public int Id
        {
            get{return id;}
            set{id = value;}
        }

        /// <summary>
        /// 姓名
        /// </summary>
        private string name = "";
        public string Name
        {
            get{return name;}
            set{name = value;}
        }

        /// <summary>
        /// 打卡记录
        /// </summary>
        private List<DateTime> records = new List<DateTime>();
        public List<DateTime> Records
        {
            get{return records;}
            set{records = value;}
        }

        /// <summary>
        /// 加班时间规则
        /// </summary>
        private List<WorkDateRule> workDateRules = new List<WorkDateRule>();
        public List<WorkDateRule> WorkDateRules
        {
            get{return workDateRules;}
            set{workDateRules = value;}
        }

        /// <summary>
        /// 加班记录对象
        /// </summary>
        private List<WorkOverTime> workOverTimeRecords = new List<WorkOverTime>();
        public List<WorkOverTime> WorkOverTimeRecords
        {
            get{return workOverTimeRecords;}
            set{workOverTimeRecords = value;}
        }

        /// <summary>
        /// 迟到记录对象
        /// </summary>
        private List<DateTime> workComeLateRecords = new List<DateTime>();
        public List<DateTime> WorkComeLateRecords
        {
            get{return workComeLateRecords;}
            set{workComeLateRecords = value;}
        }

        /// <summary>
        /// 早退记录对象
        /// </summary>
        private List<DateTime> workGoEarlyRecords = new List<DateTime>();
        public List<DateTime> WorkGoEarlyRecords
        {
            get{return workGoEarlyRecords;}
            set{workGoEarlyRecords = value;}
        }

        /// <summary>
        /// 来未打卡记录对象
        /// </summary>
        private List<DateTime> workComeNoRecords = new List<DateTime>();
        public List<DateTime> WorkComeNoRecords
        {
            get{return workComeNoRecords;}
            set{workComeNoRecords = value;}
        }

        /// <summary>
        /// 走未打卡记录对象
        /// </summary>
        private List<DateTime> workGoNoRecords = new List<DateTime>();
        public List<DateTime> WorkGoNoRecords
        {
            get { return workGoNoRecords; }
            set { workGoNoRecords = value; }
        }

        /// <summary>
        /// 旷工记录对象
        /// </summary>
        private List<DateTime> workNoRecords = new List<DateTime>();
        public List<DateTime> WorkNoRecords
        {
            get{return workNoRecords;}
            set{workNoRecords = value;}
        }

        /// <summary>
        /// 异常刷卡记录对象
        /// </summary>
        private List<DateTime> workExceptionRecords = new List<DateTime>();
        public List<DateTime> WorkExceptionRecords
        {
            get{return workExceptionRecords;}
            set{workExceptionRecords = value;}
        }

        public List<DateTime> GetRecordsBetween(DateTime startTime, DateTime endTime)
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

        public void ClearAllRecords()
        {
            workComeLateRecords.Clear();
            workComeNoRecords.Clear();
            workExceptionRecords.Clear();
            workGoEarlyRecords.Clear();
            workGoNoRecords.Clear();
            workNoRecords.Clear();
            workOverTimeRecords.Clear();
        }
    }
}
