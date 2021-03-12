using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HaSdkWrapper
{
    public class  WeiGangno:EventArgs
    {
        /// <summary>
        /// type GPIO的输入信号类型，255:gpio   0:WG26 1:WG34
        /// </summary>
        public int type { internal set; get; }
        /// <summary>
        /// 输入类型为gpio时，该值表示gpio端口号。输入类型为韦根信号时，该值为韦根协议门禁卡号
        /// </summary>
        public uint data { internal set; get; }
    }
}
