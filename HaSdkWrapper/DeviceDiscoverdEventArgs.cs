using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HaSdkWrapper
{
    public class DeviceDiscoverdEventArgs : EventArgs
    {
        /// <summary>
        /// 设备IP
        /// </summary>
        public string IP { internal set; get; }
        /// <summary>
        /// 设备Mac地址
        /// </summary>
        public string Mac { internal set; get; }
        /// <summary>
        /// 子网掩码
        /// </summary>
        public string NetMask { internal set; get; }
        /// <summary>
        /// 厂商
        /// </summary>
        public string Manufacturer { internal set; get; }
        /// <summary>
        /// 平台
        /// </summary>
        public string Plateform { internal set; get; }
        /// <summary>
        /// 系统
        /// </summary>
        public string System { internal set; get; }
        /// <summary>
        /// 版本
        /// </summary>
        public string Version { internal set; get; }
    }
}
