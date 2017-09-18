using System;
using System.Collections.Generic;

namespace StaffWorkStatisticianCore
{
    public class StaffWorkStatistics
    {
        /// <summary>
        /// 职员集合
        /// </summary>
        private Dictionary<int, Staff> staffs = new Dictionary<int, Staff>();
        public Dictionary<int, Staff> Staffs
        {
            get { return staffs; }
            set { staffs = value; }
        }

        /// <summary>
        /// 定义工作时间以及其他规则
        /// </summary>
        private WorkTimeRule workTimeRule = new WorkTimeRule();
        public WorkTimeRule WorkTimeRule
        {
            get { return workTimeRule; }
            set { workTimeRule = value; }
        }

        /// <summary>
        /// 获取所有职员刷卡记录中最早的记录
        /// </summary>
        private DateTime earlistTime = DateTime.MaxValue;
        public DateTime GetEarlistTime()
        {
            if(earlistTime == DateTime.MaxValue)
            {
                foreach (int id in staffs.Keys)
                {
                    foreach (DateTime time in staffs[id].Records)
                    {
                        if (earlistTime.CompareTo(time) > 0)
                        {
                            earlistTime = time;
                        }
                    }
                }
            }

            return earlistTime;
        }

        /// <summary>
        /// 获取所有职员刷卡记录中最晚的记录
        /// </summary>
        private DateTime latestTime = DateTime.MinValue;
        public DateTime GetLatestTime()
        {
            if (latestTime == DateTime.MinValue)
            {
                foreach (int id in staffs.Keys)
                {
                    foreach (DateTime time in staffs[id].Records)
                    {
                        if (latestTime.CompareTo(time) < 0)
                        {
                            latestTime = time;
                        }
                    }
                }
            }

            return latestTime;
        }

        /// <summary>
        /// 开始统计
        /// </summary>
        public void Statistic()
        {
            foreach (Staff staff in Staffs.Values)
            {
                staff.ClearAllRecords();
                foreach (WorkDateRule staffWorkDateRule in staff.WorkDateRules)
                {
                    if (staffWorkDateRule.IsWorkDate) //正常上班
                    {
                        #region 早上

                        //早上上班
                        DateTime amStartStartTime = staffWorkDateRule.Date;
                        DateTime amStartEndTime = staffWorkDateRule.Date.Add(workTimeRule.AMStartTime + workTimeRule.BufferTime);
                        List<DateTime> amStartRecords = staff.GetRecordsBetween(amStartStartTime, amStartEndTime);

                        //早上下班
                        DateTime amEndStartTime = staffWorkDateRule.Date.Add(workTimeRule.AMEndTime - workTimeRule.BufferTime);
                        DateTime amEndEndTime = staffWorkDateRule.Date.Add(new TimeSpan(13, 0, 0));
                        List<DateTime> amEndRecords = staff.GetRecordsBetween(amEndStartTime, amEndEndTime);

                        List<DateTime> amMiddleRecords = staff.GetRecordsBetween(amStartEndTime, amEndStartTime);

                        if (amStartRecords.Count > 0)
                        {
                            if (amEndRecords.Count > 0)
                            {
                                if (amMiddleRecords.Count > 0)
                                {
                                    //异常刷卡++
                                    for (int i = 0; i < amMiddleRecords.Count; i++)
                                    {
                                        staff.WorkExceptionRecords.Add(amMiddleRecords[i]);
                                    }
                                }
                            }
                            else
                            {
                                if (amMiddleRecords.Count > 0)
                                {
                                    //早退++
                                    staff.WorkGoEarlyRecords.Add(amMiddleRecords[amMiddleRecords.Count - 1]);
                                }
                                else
                                {
                                    //走忘记打卡++
                                    staff.WorkGoNoRecords.Add(amStartRecords[0]);
                                }
                            }
                        }
                        else
                        {
                            if (amEndRecords.Count > 0)
                            {
                                if (amMiddleRecords.Count > 0)
                                {
                                    //迟到++
                                    staff.WorkComeLateRecords.Add(amMiddleRecords[0]);
                                }
                                else
                                {
                                    //来忘记打卡++
                                    staff.WorkComeNoRecords.Add(amEndRecords[0]);
                                }
                            }
                            else
                            {
                                if (amMiddleRecords.Count > 0)
                                {
                                    //异常刷卡++
                                    for (int i = 0; i < amMiddleRecords.Count; i++)
                                    {
                                        staff.WorkExceptionRecords.Add(amMiddleRecords[i]);
                                    }
                                }
                                else
                                {
                                    //旷工++
                                    staff.WorkNoRecords.Add(staffWorkDateRule.Date.Add(workTimeRule.AMStartTime));
                                }
                            }
                        }

                        #endregion

                        #region 下午

                        //下午上班
                        DateTime pmStartStartTime = staffWorkDateRule.Date.Add(new TimeSpan(13, 0, 0));
                        DateTime pmStartEndTime = staffWorkDateRule.Date.Add(workTimeRule.PMStartTime + workTimeRule.BufferTime);
                        List<DateTime> pmStartRecords = staff.GetRecordsBetween(pmStartStartTime, pmStartEndTime);

                        //下午下班
                        DateTime pmEndStartTime = staffWorkDateRule.Date.Add(workTimeRule.PMEndTime - workTimeRule.BufferTime);
                        DateTime pmEndEndTime = staffWorkDateRule.Date.AddDays(1);
                        List<DateTime> pmEndRecords = staff.GetRecordsBetween(pmEndStartTime, pmEndEndTime);

                        List<DateTime> pmMiddleRecords = staff.GetRecordsBetween(pmStartEndTime, pmEndStartTime);

                        if (pmStartRecords.Count > 0)
                        {
                            if (pmEndRecords.Count > 0)
                            {
                                if (pmMiddleRecords.Count > 0)
                                {
                                    //异常刷卡++
                                    for (int i = 0; i < pmMiddleRecords.Count; i++)
                                    {
                                        staff.WorkExceptionRecords.Add(pmMiddleRecords[i]);
                                    }
                                }
                            }
                            else
                            {
                                if (pmMiddleRecords.Count > 0)
                                {
                                    //早退++
                                    staff.WorkGoEarlyRecords.Add(pmMiddleRecords[pmMiddleRecords.Count - 1]);
                                }
                                else
                                {
                                    //走忘记打卡++
                                    staff.WorkGoNoRecords.Add(pmStartRecords[0]);
                                }
                            }
                        }
                        else
                        {
                            if (pmEndRecords.Count > 0)
                            {
                                if (pmMiddleRecords.Count > 0)
                                {
                                    //迟到++
                                    staff.WorkComeLateRecords.Add(pmMiddleRecords[0]);
                                }
                                else
                                {
                                    //来忘记打卡++
                                    staff.WorkComeNoRecords.Add(pmEndRecords[0]);
                                }
                            }
                            else
                            {
                                if (pmMiddleRecords.Count > 0)
                                {
                                    //异常刷卡++
                                    for (int i = 0; i < pmMiddleRecords.Count; i++)
                                    {
                                        staff.WorkExceptionRecords.Add(pmMiddleRecords[i]);
                                    }
                                }
                                else
                                {
                                    //旷工++
                                    staff.WorkNoRecords.Add(staffWorkDateRule.Date.Add(workTimeRule.PMStartTime));
                                }
                            }
                        }

                        #endregion

                        #region 晚上

                        DateTime nighStartTime = staffWorkDateRule.Date.Add(workTimeRule.PMEndTime);
                        DateTime nightEndime = staffWorkDateRule.Date.AddDays(1);
                        List<DateTime> nightRecords = staff.GetRecordsBetween(nighStartTime, nightEndime);
                        StatisticWorkOvertime(staff, nightRecords, staffWorkDateRule.Multiple,true);

                        #endregion
                    }
                    else //不用上班，休息日
                    {
                        DateTime restDayStartTime = staffWorkDateRule.Date;
                        DateTime restDayEndime = staffWorkDateRule.Date.AddDays(1);
                        List<DateTime> restDayRecords = staff.GetRecordsBetween(restDayStartTime, restDayEndime);
                        StatisticWorkOvertime(staff, restDayRecords, staffWorkDateRule.Multiple,false);
                    }
                }
            }
        }

        //统计晚上或者周末节假日的加班情况
        private void StatisticWorkOvertime(Staff staff, List<DateTime> records, double multiple, bool isNightOrHoliday)
        {
            List<List<DateTime>> recordSets = new List<List<DateTime>>();

            //将重复刷卡归一
            for (int i = 0; i < records.Count; i++)
            {
                if (recordSets.Count == 0)
                {
                    recordSets.Add(new List<DateTime>());
                    recordSets[0].Add(records[0]);
                }
                else
                {
                    List<DateTime> lastRecortSet = recordSets[recordSets.Count - 1];
                    DateTime lastRecord = lastRecortSet[lastRecortSet.Count - 1];
                    TimeSpan timesSpan = records[i] - lastRecord;
                    if (timesSpan.CompareTo(workTimeRule.RepeatRecordTime) > 0)
                    {
                        List<DateTime> newLastRecordSet = new List<DateTime>();
                        newLastRecordSet.Add(records[i]);
                        recordSets.Add(newLastRecordSet);
                    }
                    else
                    {
                        lastRecortSet.Add(records[i]);
                    }
                }
            }

            if (isNightOrHoliday)  //如果是平时晚上的情况
            {
                if (recordSets.Count > 1)
                {
                    for (int i = recordSets.Count - 1; i >= 0; i--)
                    {
                        DateTime startTime = recordSets[i][0];
                        DateTime endTime = recordSets[recordSets.Count - 1][recordSets[recordSets.Count - 1].Count - 1];
                        TimeSpan timeSpan = endTime - startTime;
                        if (timeSpan.CompareTo(workTimeRule.WorkOverTime) >= 0)
                        {
                            //加班++
                            WorkOverTime workOvertime = new WorkOverTime();
                            workOvertime.starTime = startTime;
                            workOvertime.endTime = endTime;
                            workOvertime.Multiple = multiple;
                            staff.WorkOverTimeRecords.Add(workOvertime);
                            break;
                        }
                    }
                }
            }
            else //如果是周末节假日不上班的情况
            {
                if (recordSets.Count == 1)
                {
                    //异常打卡++
                    List<DateTime> lastRecordList = recordSets[recordSets.Count - 1];
                    for (int j = 0; j < lastRecordList.Count; j++)
                    {
                        staff.WorkExceptionRecords.Add(lastRecordList[j]);
                    }
                }
                else
                {
                    for (int i = 0; i < recordSets.Count - 1; i += 2)
                    {
                        DateTime startTime = recordSets[i][0];
                        DateTime endTime = recordSets[i + 1][recordSets[i + 1].Count - 1];
                        TimeSpan timeSpan = endTime - startTime;
                        if (timeSpan.CompareTo(workTimeRule.WorkOverTime) >= 0)
                        {
                            //加班++
                            WorkOverTime workOvertime = new WorkOverTime();
                            workOvertime.starTime = startTime;
                            workOvertime.endTime = endTime;
                            workOvertime.Multiple = multiple;
                            staff.WorkOverTimeRecords.Add(workOvertime);

                            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                            #region 老师加班制度，周末节假日一天最多只能算一次
                            return;
                            #endregion
                            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                        }
                        else
                        {
                            //异常打卡++
                            List<DateTime> lastRecordList = recordSets[recordSets.Count - 1];
                            for (int j = 0; j < lastRecordList.Count; j++)
                            {
                                staff.WorkExceptionRecords.Add(lastRecordList[j]);
                            }
                        }
                    }
                }
            }
        }
    }
}
