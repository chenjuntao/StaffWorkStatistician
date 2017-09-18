using System;
using System.Collections.Generic;
using System.Text;

namespace StaffWorkStatisticianCore
{
    /// <summary>
    /// 指示哪天是正常上班还是算加班以及加班的倍数
    /// </summary>
    public struct WorkDateRule
    {
        /// <summary>
        /// 指示该天是否是正常上班
        /// </summary>
        public bool IsWorkDate;

        /// <summary>
        /// 指示该天加班的倍数
        /// </summary>
        public double Multiple;

        /// <summary>
        /// 表示该规则的适用日期
        /// </summary>
        public DateTime Date;
    }
}
