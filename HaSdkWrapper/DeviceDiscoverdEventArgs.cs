using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HaSdkWrapper
{
    public class DeviceDiscoverdEventArgs : EventArgs
    {
        /// <summary>
        /// <para>设备IP</para>
        /// <EN>Ip address</EN>
        /// </summary>
        public string IP { internal set; get; }
        /// <summary>
        /// <para>设备Mac地址</para>
        /// <EN>Mac address</EN>
        /// </summary>
        public string Mac { internal set; get; }
        /// <summary>
        /// <para>子网掩码</para>
        /// <EN>Subnet mask</EN>
        /// </summary>
        public string NetMask { internal set; get; }
        /// <summary>
        /// <para>厂商</para>
        /// <EN>Manufacturer of the device</EN>
        /// </summary>
        public string Manufacturer { internal set; get; }
        /// <summary>
        /// <para>平台</para>
        /// <EN>Platform</EN>
        /// </summary>
        public string Plateform { internal set; get; }
        /// <summary>
        /// <para>系统</para>
        /// <EN>System</EN>
        /// </summary>
        public string System { internal set; get; }
        /// <summary>
        /// <para>版本</para>
        /// <EN>Version</EN>
        /// </summary>
        public string Version { internal set; get; }
    }
}
