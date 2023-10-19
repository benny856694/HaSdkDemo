using System;

namespace HaSdkWrapper
{
    static class Extensions
    {
        public static string TrimZeroChar(this string s)
        {
            return s.Replace("\0", "");
        }

        //convert epoch to datetime
        public static DateTime ToDateTime(this uint unixTimestamp)
        {

            // Convert the Unix timestamp to a DateTimeOffset object.
            DateTimeOffset dateTimeOffset = DateTimeOffset.FromUnixTimeSeconds(unixTimestamp);

            // Get the DateTime from the DateTimeOffset object.
            return dateTimeOffset.DateTime;

        }
    }
}
