using System;

namespace StaffWorkStatisticianCore
{
    /// <summary>
    /// 定义工作时间以及其他规则
    /// </summary>
    public class WorkTimeRule
    {
        /// <summary>
        /// 上午上班时间
        /// </summary>
        public TimeSpan AMStartTime;
        /// <summary>
        /// 下午下班时间
        /// </summary>
        public TimeSpan AMEndTime;

        /// <summary>
        /// 下午上班时间
        /// </summary>
        public TimeSpan PMStartTime;
        /// <summary>
        /// 下午下班时间
        /// </summary>
        public TimeSpan PMEndTime;

        /// <summary>
        /// 上下班的缓冲时间，比预先规定的时间晚到或者早走在这个时间范围内就不算迟到或者早退
        /// </summary>
        public TimeSpan BufferTime;

        /// <summary>
        /// 多次刷卡算一次的时间间隔
        /// </summary>
        public TimeSpan RepeatRecordTime;

        /// <summary>
        /// 最短加班时长
        /// </summary>
        public TimeSpan WorkOverTime;
    }
}
