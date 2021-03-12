using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HaSdkWrapper
{
   public class Qrcode : EventArgs
    {
       /// <summary>
       /// 二维码内容
       /// </summary>
       public String code { internal set; get; }
       /// <summary>
       /// 保留字段
       /// </summary>
       public String res { internal set; get; }


    }
}
