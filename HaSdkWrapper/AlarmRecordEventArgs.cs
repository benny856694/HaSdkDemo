using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HaSdkWrapper
{
    public sealed class AlarmRecordEventArgs : EventArgs
    {
        /// <summary>
        /// 相机编号
        /// </summary>
        public string CameraID { get; internal set; }
        /// <summary>
        /// 人员id，开闸的人员id
        /// </summary>
        public string PersonID { get; internal set; }
        /// <summary>
        /// 请求时间 格式：2018/3/6 16:38:20
        /// </summary>
        public string AlarmTime { get; internal set; }
        /// <summary>
        /// 请求的开闸设备类型，0：继电器 1：韦根设备
        /// </summary>
        public byte AlarmDeviceType { get; internal set; }
        /// <summary>
        /// 开闸设备id，外设类型为继电器时，外设ID为GPIO端口号。外设类型为支持韦根协议的设备时，外设ID为卡号。
        /// </summary>
        public uint AlarmDeviceId { get; internal set; }
    }
}
