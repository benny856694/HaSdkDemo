using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SDKClientSharp
{
    static class DateTimeExtension
    {
        public static uint ToUtcSecondsFromEpochTime(this DateTime localTime) 
        {
           return (uint)localTime.Subtract(new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalSeconds;
        }
    }


    static class Utils
    {
        public static void InitComboBox<T>(this ComboBox box, Tuple<T, string>[] options)
        {
            box.DataSource = options;
            box.ValueMember = "Item1";
            box.DisplayMember = "Item2";
        }

        public static void InitAsFaceType(this ComboBox box)
        {
            var options = new Tuple<int, string>[]
            {
                new Tuple<int, string>(0, "普通"),
                new Tuple<int, string>(1, "白名单"),
                new Tuple<int, string>(2, "黑名单"),
            };

            box.InitComboBox(options);
        }

        public static void InitAsScheduleMode(this ComboBox box)
        {
            var options = new Tuple<byte, string>[]
            {
                new Tuple<byte, string>(0, "未使用"),
                new Tuple<byte, string>(1, "调度规则1"),
                new Tuple<byte, string>(2, "调度规则2"),
                new Tuple<byte, string>(3, "调度规则3"),
                new Tuple<byte, string>(4, "调度规则4"),
                new Tuple<byte, string>(5, "调度规则5"),
            };

            box.InitComboBox(options);
        }


        public static void InitAsValidToMode(this ComboBox box)
        {
            //永不过期
            //永久失效
            //给定时间
            var options = new Tuple<int, string>[]
            {
                new Tuple<int, string>(0, "永不过期"),
                new Tuple<int, string>(1, "永久失效"),
                new Tuple<int, string>(2, "给定时间"),
            };

            box.InitComboBox(options);
        }

        public static uint GetUtcSecondsBasedOnValidToType(int validToType, DateTime localTime)
        {
            switch (validToType)
            {
                case 0: //never expire
                    return uint.MaxValue;
                case 1: //always expired
                    return 0;
                case 2:
                    return localTime.ToUtcSecondsFromEpochTime();
                default:
                    throw new InvalidOperationException();
            }
        }

    }
}
