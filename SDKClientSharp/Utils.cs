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
        public static void InitComboBox<T>(this ComboBox box, MyTuple<T, string>[] options)
        {
            box.DataSource = options;
            box.ValueMember = "Item1";
            box.DisplayMember = "Item2";
        }

        public static void InitAsFaceType(this ComboBox box)
        {
            var options = new MyTuple<int, string>[]
            {
                new MyTuple<int, string>(0, strings.FaceType_Normal),
                new MyTuple<int, string>(1, strings.FaceType_WhiteName),
                new MyTuple<int, string>(2, strings.FaceType_BlackName),
            };

            box.InitComboBox(options);
        }

        public static void InitAsScheduleMode(this ComboBox box)
        {
            var options = new List<MyTuple<byte, string>>();

            options.Add(new MyTuple<byte, string>(0, strings.NA));

            for (int i = 1; i < 5; i++)
            {
                options.Add(new MyTuple<byte, string>(Convert.ToByte(i), string.Format(strings.Rule, i)));
            }

            box.InitComboBox(options.ToArray());
        }


        public static void InitAsValidToMode(this ComboBox box)
        {
            var options = new MyTuple<int, string>[]
            {
                new MyTuple<int, string>(0, strings.ValidTo_NeverExpire),
                new MyTuple<int, string>(1, strings.ValidTo_Expired),
                new MyTuple<int, string>(2, strings.ValidTo_Specified),
            };

            box.InitComboBox(options);
        }


        public static void InitAsFaceQueryType(this ComboBox box)
        {
            var options = new MyTuple<int, string>[]
            {
                new MyTuple<int, string>(0, strings.FaceType_Normal),
                new MyTuple<int, string>(1, strings.FaceType_WhiteName),
                new MyTuple<int, string>(2, strings.FaceType_BlackName),
                new MyTuple<int, string>(-1, strings.FaceType_All),
            };

            box.InitComboBox(options);
        }

        public static void InitAsMathingMode(this ComboBox box)
        {
            var options = new MyTuple<short, string>[]
            {
               new MyTuple<short, string>(0, strings.MatchingMode_Exactly),
                new MyTuple<short, string>(1, strings.MatchingMode_Fuzzy),
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

        public static void  ShowMsg(string operation, bool success = true, int errorCode = 0, string errorMsg = null)
        {
            var msg = string.Empty;
            if(success)
            {
                msg = string.Format("{0} {1}", operation, strings.Success);
            }
            else
            {
                var sb = new StringBuilder();
                sb.AppendLine(string.Format("{0} {1}", operation, strings.Fail));
                sb.AppendLine("-------------------");
                sb.Append(string.Format(strings.ErrorWithErrorMsg, errorCode, errorMsg));
                msg = sb.ToString();
            }

            MessageBox.Show(msg, string.Empty, MessageBoxButtons.OK, errorCode == 0 ? MessageBoxIcon.Information : MessageBoxIcon.Error);


        }


    }
}
