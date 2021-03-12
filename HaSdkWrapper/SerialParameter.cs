using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HaSdkWrapper
{
    public class SerialParameter
    {
        /// <summary>
        /// 波特率；只能为以下值：1200, 2400, 4800, 9600, 14400, 19200, 38400, 56000, 57600, 115200, 128000, 256000
        /// </summary>
        public int Baudrate { get; set; }
        /// <summary>
        /// 校验位；0:none, 1:odd, 2:even, 3:mark, 4:space
        /// </summary>
        public int Parity { get; set; }
        /// <summary>
        /// 数据位；只能为5，6，7，8
        /// </summary>
        public int Databit { get; set; }
        /// <summary>
        /// 停止位；只能为1，2
        /// </summary>
        public int Stopbit { get; set; }
    }
}
