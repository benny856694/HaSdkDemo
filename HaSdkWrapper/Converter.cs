using System;
using System.Runtime.InteropServices;
using System.Text;

namespace HaSdkWrapper
{
    public static class Converter
    {
        public static DateTime ConvertToDateTime(uint seconds, uint useconds)
        {
            var milliseconds = useconds * 0.001;
            var dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
            dtDateTime = dtDateTime.AddSeconds(seconds).AddMilliseconds(milliseconds).ToLocalTime();
            return dtDateTime;
        }

        public static byte[] ConvertStringToUTF8(string src)
        {
            if (string.IsNullOrEmpty(src) || string.IsNullOrEmpty(src.Trim()))
                return new byte[1] { 0 };
            return Encoding.UTF8.GetBytes(src);
        }

        public static byte[] ConvertStringToUTF8(string src, int retLen)
        {
            byte[] retBytes = new byte[retLen];
            byte[] utf8Bytes = ConvertStringToUTF8(src);
            if (utf8Bytes.Length >= retLen)
                return retBytes;
            Array.Copy(utf8Bytes, retBytes, utf8Bytes.Length);
            return retBytes;
        }

        public static IntPtr ConvertStringToUTF8Unmanaged(string src)
        {
            byte[] utf8Bytes = ConvertStringToUTF8(src);
            IntPtr retPtr = Marshal.AllocHGlobal(utf8Bytes.Length + 1);
            Marshal.Copy(utf8Bytes, 0, retPtr, utf8Bytes.Length);
            Marshal.WriteByte(retPtr, utf8Bytes.Length, 0);
            return retPtr;
        }

        public static byte[] ConvertStringToDefault(byte[] utfsrc)
        {
            if (utfsrc == null || utfsrc.Length < 1)
                return new byte[1] { 0 };
            int len = 0;
            for (int i = 0; i < utfsrc.Length; ++i)
            {
                if (utfsrc[i] == 0) break;
                len++;
            }
            byte[] utfdes = new byte[len];
            if (len < 1) return Encoding.Default.GetBytes(string.Empty);
            Array.Copy(utfsrc, utfdes, len);
            return Encoding.Convert(Encoding.UTF8, Encoding.Default, utfdes);
        }
    }
}
