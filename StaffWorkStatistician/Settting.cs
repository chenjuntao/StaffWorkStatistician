using System;
using System.Configuration;
using System.Collections.Generic;
using System.Drawing;
using StaffWorkStatisticianCore;

namespace StaffWorkStatistician
{
    internal sealed class Settings : ApplicationSettingsBase
    {
        private static Settings settingInstance = new Settings();

        public static Settings DefaultInstance
        {
            get
            {
                return settingInstance;
            }
        }

        [UserScopedSetting()]
        [DefaultSettingValueAttribute("08:00:00")]
        public TimeSpan AMStartTime1
        {
            get
            {
                return ((TimeSpan)(this["AMStartTime1"]));
            }
            set
            {
                this["AMStartTime1"] = value;
            }
        }

        [UserScopedSetting()]
        [DefaultSettingValueAttribute("12:00:00")]
        public TimeSpan AMEndTime1
        {
            get
            {
                return ((TimeSpan)(this["AMEndTime1"]));
            }
            set
            {
                this["AMEndTime1"] = value;
            }
        }

        [UserScopedSetting()]
        [DefaultSettingValueAttribute("15:00:00")]
        public TimeSpan PMStartTime1
        {
            get
            {
                return ((TimeSpan)(this["PMStartTime1"]));
            }
            set
            {
                this["PMStartTime1"] = value;
            }
        }

        [UserScopedSetting()]
        [DefaultSettingValueAttribute("18:00:00")]
        public TimeSpan PMEndTime1
        {
            get
            {
                return ((TimeSpan)(this["PMEndTime1"]));
            }
            set
            {
                this["PMEndTime1"] = value;
            }
        }

        [UserScopedSetting()]
        [DefaultSettingValueAttribute("00:10:00")]
        public TimeSpan BufferTime1
        {
            get
            {
                return ((TimeSpan)(this["BufferTime1"]));
            }
            set
            {
                this["BufferTime1"] = value;
            }
        }

        [UserScopedSetting()]
        [DefaultSettingValueAttribute("00:10:00")]
        public TimeSpan RepeatRecordTime1
        {
            get
            {
                return ((TimeSpan)(this["RepeatRecordTime1"]));
            }
            set
            {
                this["RepeatRecordTime1"] = value;
            }
        }

        [UserScopedSetting()]
        [DefaultSettingValueAttribute("02:00:00")]
        public TimeSpan WorkOverTime1
        {
            get
            {
                return ((TimeSpan)(this["WorkOverTime1"]));
            }
            set
            {
                this["WorkOverTime1"] = value;
            }
        }

        [UserScopedSetting()]
        [DefaultSettingValueAttribute("08:00:00")]
        public TimeSpan AMStartTime2
        {
            get
            {
                return ((TimeSpan)(this["AMStartTime2"]));
            }
            set
            {
                this["AMStartTime2"] = value;
            }
        }

        [UserScopedSetting()]
        [DefaultSettingValueAttribute("12:00:00")]
        public TimeSpan AMEndTime2
        {
            get
            {
                return ((TimeSpan)(this["AMEndTime2"]));
            }
            set
            {
                this["AMEndTime2"] = value;
            }
        }

        [UserScopedSetting()]
        [DefaultSettingValueAttribute("14:30:00")]
        public TimeSpan PMStartTime2
        {
            get
            {
                return ((TimeSpan)(this["PMStartTime2"]));
            }
            set
            {
                this["PMStartTime2"] = value;
            }
        }

        [UserScopedSetting()]
        [DefaultSettingValueAttribute("17:30:00")]
        public TimeSpan PMEndTime2
        {
            get
            {
                return ((TimeSpan)(this["PMEndTime2"]));
            }
            set
            {
                this["PMEndTime2"] = value;
            }
        }

        [UserScopedSetting()]
        [DefaultSettingValueAttribute("00:10:00")]
        public TimeSpan BufferTime2
        {
            get
            {
                return ((TimeSpan)(this["BufferTime2"]));
            }
            set
            {
                this["BufferTime2"] = value;
            }
        }

        [UserScopedSetting()]
        [DefaultSettingValueAttribute("00:10:00")]
        public TimeSpan RepeatRecordTime2
        {
            get
            {
                return ((TimeSpan)(this["RepeatRecordTime2"]));
            }
            set
            {
                this["RepeatRecordTime2"] = value;
            }
        }

        [UserScopedSetting()]
        [DefaultSettingValueAttribute("02:00:00")]
        public TimeSpan WorkOverTime2
        {
            get
            {
                return ((TimeSpan)(this["WorkOverTime2"]));
            }
            set
            {
                this["WorkOverTime2"] = value;
            }
        }

        [UserScopedSetting()]
        [DefaultSettingValueAttribute("08:30:00")]
        public TimeSpan AMStartTime3
        {
            get
            {
                return ((TimeSpan)(this["AMStartTime3"]));
            }
            set
            {
                this["AMStartTime3"] = value;
            }
        }

        [UserScopedSetting()]
        [DefaultSettingValueAttribute("12:00:00")]
        public TimeSpan AMEndTime3
        {
            get
            {
                return ((TimeSpan)(this["AMEndTime3"]));
            }
            set
            {
                this["AMEndTime3"] = value;
            }
        }

        [UserScopedSetting()]
        [DefaultSettingValueAttribute("15:00:00")]
        public TimeSpan PMStartTime3
        {
            get
            {
                return ((TimeSpan)(this["PMStartTime3"]));
            }
            set
            {
                this["PMStartTime3"] = value;
            }
        }

        [UserScopedSetting()]
        [DefaultSettingValueAttribute("17:30:00")]
        public TimeSpan PMEndTime3
        {
            get
            {
                return ((TimeSpan)(this["PMEndTime3"]));
            }
            set
            {
                this["PMEndTime3"] = value;
            }
        }

        [UserScopedSetting()]
        [DefaultSettingValueAttribute("00:10:00")]
        public TimeSpan BufferTime3
        {
            get
            {
                return ((TimeSpan)(this["BufferTime3"]));
            }
            set
            {
                this["BufferTime3"] = value;
            }
        }

        [UserScopedSetting()]
        [DefaultSettingValueAttribute("00:10:00")]
        public TimeSpan RepeatRecordTime3
        {
            get
            {
                return ((TimeSpan)(this["RepeatRecordTime3"]));
            }
            set
            {
                this["RepeatRecordTime3"] = value;
            }
        }

        [UserScopedSetting()]
        [DefaultSettingValueAttribute("02:00:00")]
        public TimeSpan WorkOverTime3
        {
            get
            {
                return ((TimeSpan)(this["WorkOverTime3"]));
            }
            set
            {
                this["WorkOverTime3"] = value;
            }
        }

        [UserScopedSetting()]
        [DefaultSettingValueAttribute("")]
        public List<Staff> Staffs
        {
            get
            {
                return (List<Staff>)(this["Staffs"]);
            }
            set
            {
                this["Staffs"] = value;
            }
        }

         public Staff IsContainStaffId(int staffId)
         {
             for (int i = 0; i < Staffs.Count; i++)
             {
                 if (staffId == Staffs[i].Id)
                 {
                     return Staffs[i];
                 }
             }
             return null;
         }
    }
}
