using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HaSdkWrapper
{
    static class Extensions
    {
        public static string TrimZeroChar(this string s)
        {
            return s.Replace("\0", "");
        }
    }
}
