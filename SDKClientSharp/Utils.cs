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
           return (uint)localTime.ToUniversalTime().Subtract(new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalSeconds;
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
                new Tuple<int, string>(0, strings.FaceType_Normal),
                new Tuple<int, string>(1, strings.FaceType_WhiteName),
                new Tuple<int, string>(2, strings.FaceType_BlackName),
            };

            box.InitComboBox(options);
        }

        public static void InitAsScheduleMode(this ComboBox box)
        {
            var options = new List<Tuple<byte, string>>();

            options.Add(new Tuple<byte, string>(0, strings.NA));

            for (int i = 1; i < 5; i++)
            {
                options.Add(new Tuple<byte, string>(Convert.ToByte(i), string.Format(strings.Rule, i)));
            }

            box.InitComboBox(options.ToArray());
        }


        public static void InitAsValidToMode(this ComboBox box)
        {
            var options = new Tuple<int, string>[]
            {
                new Tuple<int, string>(0, strings.ValidTo_NeverExpire),
                new Tuple<int, string>(1, strings.ValidTo_Expired),
                new Tuple<int, string>(2, strings.ValidTo_Specified),
            };

            box.InitComboBox(options);
        }


        public static void InitAsFaceQueryType(this ComboBox box)
        {
            var options = new Tuple<int, string>[]
            {
                new Tuple<int, string>(0, strings.FaceType_Normal),
                new Tuple<int, string>(1, strings.FaceType_WhiteName),
                new Tuple<int, string>(2, strings.FaceType_BlackName),
                new Tuple<int, string>(-1, strings.FaceType_All),
            };

            box.InitComboBox(options);
        }

        public static void InitAsMathingMode(this ComboBox box)
        {
            var options = new Tuple<short, string>[]
            {
               new Tuple<short, string>(0, strings.MatchingMode_Exactly),
                new Tuple<short, string>(1, strings.MatchingMode_Fuzzy),
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

        public static void EnableAllButtons(this GroupBox box, bool enable)
        {
            foreach (var item in box.Controls.OfType<Button>())
            {
                item.Enabled = enable;
            } 
        }


    }
}
