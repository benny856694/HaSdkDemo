using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

namespace HaSdkWrapper
{
    public unsafe class ConfigTemplate
    {
        #region 无关结构体
        [StructLayout(LayoutKind.Sequential, Pack = 1, Size = 28)]
        private struct TemporaryParam
        {

        }
        [StructLayout(LayoutKind.Sequential, Pack = 1, Size = 640)]
        private struct PlatformParam
        {

        }
        [StructLayout(LayoutKind.Sequential, Pack = 1, Size = 64)]
        private struct StreamParam
        {

        }

        [StructLayout(LayoutKind.Sequential, Pack = 1, Size = 32)]
        private struct AppServicesParam
        {

        }


        [StructLayout(LayoutKind.Sequential, Pack = 1, Size = 48)]
        private struct AuthParam
        {

        }

        [StructLayout(LayoutKind.Sequential, Pack = 1, Size = 8)]
        private struct HA_Point
        {
            public int x;
            public int y;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 1, Size = 8)]
        private struct SRect
        {
            public short x;
            public short y;
            public short widht;
            public short height;
        }
        [StructLayout(LayoutKind.Sequential, Pack = 1, Size = 128)]
        private struct UploaderParam
        {
            public fixed byte resv[4];
            public ClientParam client;
        }
        [StructLayout(LayoutKind.Sequential, Pack = 1, Size = 128)]
        private struct OutputerParam
        {
            public UploaderParam uploader;
        }
        // 地理位置定义。
        [StructLayout(LayoutKind.Sequential, Pack = 1, Size = 16)]
        private struct GeoLocation
        {
            /*! 经度。 */
            public float longitude;

            /*! 纬度。 */
            public float latitude;

            /*! 海拔高度。 */
            float altitude;

            /*! 坐标系统。1: WGS_84，2: GCJ_02。 */
            public byte coordinate;

            /*! 保留。 */
            public fixed sbyte resv[3];
        }
        [StructLayout(LayoutKind.Sequential, Pack = 1, Size = 276)]
        private struct GB28281Param
        {
            /*！开关 0：关 !0：开 */
            public sbyte enable;
            /*！IPC报警级别 */
            public sbyte alarm_priority;
            /*！心跳周期 单位s*/
            public sbyte heart_cycle;
            /*！SIP服务器ID */
            public fixed sbyte sip_server_id[32];
            /*！SIP服务器IP地址 */
            public fixed sbyte sip_server_ip[16];
            /*！SIP服务器端口 */
            public ushort sip_server_port;
            /*！IPC发送端口 */
            public ushort ipc_port;
            /*！IPC ID */
            public fixed sbyte ipc_id[32];
            /*！IPC发送密码 */
            public fixed sbyte ipc_passwd[24];
            /*！IPC报警ID */
            public fixed sbyte alarm_id[32];
            /*！IPC有效期 当前时间之后的秒数 */
            public uint ipc_term;
            public fixed sbyte resv[128];
        };
        #endregion

        [StructLayout(LayoutKind.Sequential, Pack = 1, Size = 512)]
        private struct FacePrivateParam
        {
            /*! 检测跟踪区域边数。 */
            public sbyte roi_border_num;
            /*! 比对开关。取值为0时关闭，其它取值打开。 */
            public sbyte enable_match;
            /*! 调试开关。 */
            public sbyte enable_debug;
            /*! 深度去重复开关。1：开 0：关。 */
            public sbyte enable_dereplication;
            /*! 重复超时。超时将不再视为重复。仅在开启去重复时有效。单位：秒。取值范围：1~60。 */
            public sbyte replication_timeout;
            /*! 重复输出间隔。对于同一人员，上报人脸结果时间间隔。单位：秒。取值范围：1~120。 */
            public sbyte replication_interval;
            /*! 输出图像品质。 */
            public sbyte quality;
            /*! 名单过期自动清理功能开关。 */
            public sbyte enable_auto_clean;
            /*! 输出控制。 */
            int output_form;
            /*! 比对满分相似度值。取值范围：0.2~1.0。相似度达到该值时确信度为满分。 */
            float full_credit;
            /*! 相似度达到该值时认为比对成功（100分制）。 */
            short match_score;
            /*! 白名单GPIO输出开关（端口1）。1：开 0：关 */
            public sbyte gpio_enable_white;
            /*! 黑名单GPIO输出开关（端口2）。1：开 0：关 */
            public sbyte gpio_enable_black;
            /*! 暂未定义GPIO输出开关（端口3）。1：开 0：关 */
            public sbyte gpio_enable_resv;

            public byte serial_send_flag;
            public fixed byte serial_databit[2];    // 数据位
            public fixed byte serial_parity[2];     // 是否开始校验
            public fixed byte serial_stopbit[2];    // 停止位
            public fixed int serial_baudrate[2];   // 波特率

            /*! 补光灯工作模式。1：常亮 2：自动控制 3：常闭。 */
            public byte light_mode;
            /*! 补光灯亮度等级(1~100)。 */
            public byte light_level;
            /*! 亮灯门限。画面亮度值低于该值时亮灯。亮度取值范围：1~255。 */
            public byte light_threshold;
            /*! 音量取值范围：0~100。 */
            public byte audio_volume;
            /*使用内置语音编号*/
            public byte audio_index;
            /*! 使用动态对比分数阈值，打开后将不使用配置的对比分数阈值。0：关 !0开*/
            public sbyte auto_score_enable;
            /*! 闸机控制类型：0继电器， 1韦根。 */
            public byte gateway_control_type;
            /*! 继电器序号。 */
            public byte alarm_index;
            /*! 继电器自动闭合持续时间，单位ms(500-5000)。 */
            public ushort alarm_duration;
            /*! 韦根类型，WG26,WG34, WG36, WG44。目前只支持WG26, WG34。 */
            public byte wiegand_type;
            /*! 发行码，wg36 wg44需要此字段 */
            public byte wiegand_dcode;
            /*! 韦根门禁公共卡号。 */
            public uint wiegand_public_cardid;
            /*! 自动升成卡号时，韦根卡号范围，最小值。 */
            public uint wiegand_card_id_min;
            /*! 自动升成卡号时，韦根卡号范围，最大值。 */
            public uint wiegand_card_id_max;
            /*! 工作模式（@ref WorkMode ）。 */
            public byte work_mode;
            /*! 继电器状态，0表示常闭合 1表示常断开  */
            public byte gpio_state;
            /*! 无感录入（聚类）开关 */
            public byte cluster_enable;
            /*! 同一聚类通过的最大次数，当同一聚类通过的次数大于等于该次数时自动注册 */
            public byte max_pass_times;
            /*! 计算次数的时间间隔，在该时间间隔内只算通过一次 单位 秒*/
            public uint calc_times_interval;
            /*! 抓拍记录开关 0:关 !0:开*/
            public sbyte record_enable;
            /*! 断点续传开关，自动上传离线数据 */
            public sbyte record_resume_enable;
            /*人脸报警开关，打开后只要检测到人脸就报警开闸*/
            public sbyte face_alarm_enable;
            /*! 外接显示屏屏幕亮度 */
            public sbyte lcd_light_level;
            /*! gpio输入类型， 参见 enum WiegandType */
            int gpio_input_type;
            /*! gpio输入开关，0关，!0开*/
            public sbyte gpio_input_enable;
            /* 过滤未比对上的抓拍数据 0 不过滤 非0过滤  */
            public sbyte filter_not_match;
            /* 是否需要带安全帽 0 不需要 非0须要  */
            public sbyte must_wear_hat;
            /* 通行语音播放间隔 单位：秒  */
            public sbyte audio_interval;
            /* 韦根开闸时是否联动IO开闸 0:不联动 1:联动*/
            public sbyte ctrl_wiegand_io;
            /* 归一化保存图像开关 0:保存 !0:不保存 */
            public sbyte no_twist_image;
            /* 多人脸模式 0:单人脸检测 !0:多人脸检测 */
            public sbyte multipleFaceMod;
            /* 姓名隐私模式 0:关 !0:开         */
            public sbyte namePrivacy;
            /* 注册人员即将到期提醒时间 注: (有效时间 - alarm_expire) 至有效时间 内提醒  */
            public uint expire_alarm;
            /*! 检测到人脸时打开所有继电器 。 */
            public sbyte allGpioOut;
            /*! 抓拍记录保存位置 0：TF卡 1：相机EMMC  默认TF卡  重启生效*/
            public sbyte record_path;
            /*! 二维码识别 开关         0：关 1: 开 */
            public sbyte qr_code_enable;
            /*! 重复二维码    过滤间隔 0~255 S      默认 0*/
            public byte qr_code_interval;

            public byte serialmod;

            /*! 单人脸系统保留。 */
            public fixed sbyte resv2[15];
            /*对比模式*/
            public byte mache_mode;
            /*多人脸系统保留*/
            public fixed sbyte resv_mface[19];
            /*! 检测跟踪区域坐标点。顺次连接构成检测跟踪区域。 */
            //[MarshalAs(UnmanagedType.Struct, SizeConst = 6)]
            //public HA_Point[] roi;
            public fixed sbyte roi[8 * 6];
            /*! 人脸检测最小人脸尺寸 */
            public short min_face_size;
            /*! 串口配置服务开关，0：关 非0：开*/
            public fixed sbyte serial_config_enable[2];
            /*! 大角度人脸过滤开关*/
            public sbyte valid_angle_enable;
            /*! 过滤人脸的最大角度，暂未使用*/
            public sbyte valid_angle;
            /*人脸质量过滤开关*/
            public sbyte valid_qvalue_enable;
            /*图像质量阈值*/
            public sbyte qvalue_threshold;
            /*! 人像数据同步开关 */
            public sbyte sync_enable;
            /*! 人像数据同步协议类型（暂未使用），/* 0 未初始化。 1 TCP协议。 2 FTP协议。 3 HTTP协议。4 WebService */
            public sbyte sync_mode;
            /*! 人像数据同步间隔时间 单位s*/
            public ushort sync_interval;
            /*! 人像数据同步IP地址。 */
            public fixed sbyte sync_ip[16];
            /*! 人像数据同步端口。 */
            public ushort sync_port;
            /*! 人像数据同步URL。 */
            public fixed sbyte sync_url[102];
            /*双目摄像图像差校正区域*/
            //[MarshalAs(UnmanagedType.Struct, SizeConst = 3)]
            //public SRect[] bino_corret_area;
            public fixed sbyte bino_corret_area[8 * 8];
            /*! 语音拼接内容，按低字节->高字节 存拼接的内容标记 例如：char[0]=SPEECH_SPLICE_FLAG_ROLE 参见类型SpeechSplicesFlag */
            public fixed sbyte speech_splices[4];
            /*! 普通人员语音播报内容（utf8编码）*/
            public fixed sbyte normal_speech[32];
            /*! 白名单语音播报内容（utf8编码） */
            public fixed sbyte white_speech[32];
            /*! 黑名单语音播报内容（utf8编码） */
            public fixed sbyte black_speech[32];
            /*! 保存连接WIFI名称 */
            public fixed sbyte wifi_ssid[32];

            public fixed sbyte wifi_passwd[16];

            public fixed sbyte resv[12];

            /*! 配对相机IP。 */
            public fixed sbyte pair_ip[16];
            /*! 是否启用配对。 */
            public byte enable_pair;
            /*! 配对相机开闸间隔。单位：秒。 */
            public byte pair_timeout;

            public fixed byte resv1[2];
        };
        [StructLayout(LayoutKind.Sequential, Pack = 1, Size = 120)]
        private struct HttpClientParam
        {
            public fixed byte ip[16];
            public ushort port;
            public fixed byte url[102];
        }
        [StructLayout(LayoutKind.Sequential, Pack = 1, Size = 120)]
        private struct TcpClientParam
        {
            public fixed byte ip[16];
            public int port;
            public sbyte enable;
            public byte enable_verify;
            public fixed byte username[16];
            public fixed byte passwd[17];
            public byte enable_ssl;
            public fixed byte resv[64];
        }
        /// FTP上传参数。
        [StructLayout(LayoutKind.Sequential, Pack = 1, Size = 120)]
        private struct FtpClientParam
        {
            /*! 服务器IP地址。 */
            public fixed sbyte ip[16];
            /*! 服务器端口。 */
            public int port;
            /*! 登录用户名。 */
            public fixed sbyte user[15];
            /*! 登录密码。 */
            public fixed sbyte password[15];
            /*! 上传目录。 */
            public fixed sbyte pattern[70];
        };
        [StructLayout(LayoutKind.Sequential, Pack = 1, Size = 128)]
        private struct ExtranetParam
        {
            public fixed byte client[120]; /*union {
            struct TcpClientParam tcp;
	        struct HttpClientParam http;
          };*/
            public byte enable;
            public sbyte mode;
            public fixed sbyte resv[6];
        }
        [StructLayout(LayoutKind.Sequential, Pack = 1, Size = 224)]
        private struct DescriptionParam
        {
            public fixed byte addr_id[32];
            public fixed byte addr_name[96];
            public fixed byte device_id[32];
            public sbyte device_type;
            public fixed byte resv[63];
        }
        [StructLayout(LayoutKind.Sequential, Pack = 1, Size = 512)]
        private struct AppCommonParam
        {
            public AppServicesParam service;
            public DescriptionParam description;
            public ExtranetParam extranet;
            public AuthParam auth;
            public fixed byte resv[28];
        }
        [StructLayout(LayoutKind.Sequential, Pack = 1, Size = 1024)]
        private struct AppParam
        {
            public AppCommonParam common;
            public FacePrivateParam priv;
        }
        [StructLayout(LayoutKind.Sequential, Pack = 1, Size = 124)]
        private struct ClientParam
        {
            public sbyte mode;
            public sbyte enable_heart;
            public fixed sbyte resv[2];
            public fixed sbyte client[120];/* union {
                FtpClientParam ftp;
                TcpClientParam tcp;
                HttpClientParam http;
	            HttpClientParam web_service;
              };
            */
        }
        /// 人脸应用附加参数。
        [StructLayout(LayoutKind.Sequential, Pack = 1, Size = 2048)]
        private struct FaceExtraParam
        {
            /*! 人脸库ID。 */
            public fixed sbyte face_set_id[32];
            /*! 地理位置。 */
            public GeoLocation location;
            /*! 人脸库md5 */
            public fixed sbyte face_set_md5[33];

            /*! 阿里云OSS的access_key */
            public fixed sbyte oss_key_id[32];

            /*! 阿里云OSS的access_secret */
            public fixed sbyte oss_key_secret[32];

            /*! 阿里云OSS数据中心位置 */
            public fixed sbyte oss_endpoint[64];

            /*! 此设备在阿里云OSS存放位置的bucket名称  */
            public fixed sbyte oss_bucket_name[64];
            /*! 相机http服务  0：关 1：开*/
            byte http_server_enable;
            /*! 保留。 */
            public fixed sbyte resv1[238];
            /*gb28181参数*/
            GB28281Param gb28181param;
            /*! 上传域名 */
            public fixed sbyte uploader_domain[128];
            /*! 外网穿透使用域名 */
            public fixed sbyte extra_net_domain[128];
            /*! 保留。 */
            public fixed sbyte resv2[1004];

        }
        [StructLayout(LayoutKind.Sequential, Pack = 1, Size = 3932)]
        private struct FaceSystemConfig
        {
            public TemporaryParam temp;
            public PlatformParam platform;
            public StreamParam stream;
            public AppParam app;
            public OutputerParam outputer;
            public FaceExtraParam extraParam;
        }

        #region nativeMethods
        [DllImport("msvcrt", CallingConvention = CallingConvention.Cdecl)]
        static extern void memcpy(void* dest, void* src, int count);
        #endregion nativeMethods

        private FaceSystemConfig faceSystemConfig;
        private ConfigTemplate()
        {

        }

        #region 外部接口
        /// <summary>
        /// 获取或设置设备编号
        /// </summary>
        public string DeviceNo
        {
            set
            {
                byte[] new_device_id = Converter.ConvertStringToUTF8(value, 32);
                fixed (byte* pnew = &new_device_id[0])
                fixed (byte* pold = faceSystemConfig.app.common.description.device_id)
                {
                    memcpy(pold, pnew, 32);
                }
            }
            get
            {
                byte[] ret = new byte[32];
                fixed (byte* pret = &ret[0])
                fixed (byte* pvalue = faceSystemConfig.app.common.description.device_id)
                {
                    memcpy(pret, pvalue, 32);
                }
                return Encoding.UTF8.GetString(ret).TrimEnd('\0');
            }
        }
        /// <summary>
        /// 获取或设置点位编号
        /// </summary>
        public string AddrID
        {
            set
            {
                byte[] new_addr_id = Converter.ConvertStringToUTF8(value, 32);
                fixed (byte* pnew = &new_addr_id[0])
                fixed (byte* pold = faceSystemConfig.app.common.description.addr_id)
                {
                    memcpy(pold, pnew, 32);
                }
            }
            get
            {
                byte[] ret = new byte[32];
                fixed (byte* pret = &ret[0])
                fixed (byte* pvalue = faceSystemConfig.app.common.description.addr_id)
                {
                    memcpy(pret, pvalue, 32);
                }
                return Encoding.UTF8.GetString(ret).TrimEnd('\0');
            }
        }
        /// <summary>
        /// 获取或设置点位名称
        /// </summary>
        public string AddrName
        {
            set
            {
                byte[] new_addr_name = Converter.ConvertStringToUTF8(value, 96);
                fixed (byte* pnew = &new_addr_name[0])
                fixed (byte* pold = faceSystemConfig.app.common.description.addr_name)
                {
                    memcpy(pold, pnew, 32);
                }
            }
            get
            {
                byte[] ret = new byte[32];
                fixed (byte* pret = &ret[0])
                fixed (byte* pvalue = faceSystemConfig.app.common.description.addr_name)
                {
                    memcpy(pret, pvalue, 96);
                }
                return Encoding.UTF8.GetString(ret).TrimEnd('\0');
            }
        }
        /// <summary>
        /// 从一个已连接的设备创建配置模板
        /// </summary>
        public ConfigTemplate(HaCamera cam)
        {
            fixed (FaceSystemConfig* pFaceSystemConfig = &faceSystemConfig)
            {
                int ret = HaSdkWrapper.NativeMethods.HA_GetFaceSystemCfgEx((void*)cam._cam, pFaceSystemConfig);
                if (ret != 0)
                    throw new Exception("HA_GetFaceSystemCfgEx return " + ret);
            }
        }

        /// <summary>
        /// 将配置更新到某个设备
        /// </summary>
        public bool UpdateToCamera(HaCamera cam)
        {
            fixed (FaceSystemConfig* pFaceSystemConfig = &faceSystemConfig)
            {
                int ret = HaSdkWrapper.NativeMethods.HA_SetFaceSystemCfgEx((void*)cam._cam, pFaceSystemConfig);
                return ret == 0; // 如果希望查找原因，则自行将ret上报到外部
            }
        }

        /// <summary>
        /// 从一个导出的模板文件还原配置模板
        /// </summary>
        public ConfigTemplate(string fPath)
        {
            byte[] data = File.ReadAllBytes(fPath);
            ParseFromByteArray(this, data);
        }

        /// <summary>
        /// 将模板导出为文件
        /// </summary>
        public void SaveToFile(string fPath)
        {
            File.WriteAllBytes(fPath, this);
        }

        /// <summary>
        /// 隐士的类型转换，当可以在代码中将本对象序列化为字节数组，方便网络传输等
        /// </summary>
        public static implicit operator byte[](ConfigTemplate _this)
        {
            byte[] ret = new byte[Marshal.SizeOf(typeof(FaceSystemConfig))];
            fixed (byte* pRet = &ret[0])
            fixed (FaceSystemConfig* pfaceSystemConfig = &_this.faceSystemConfig)
            {
                memcpy(pRet, pfaceSystemConfig, ret.Length);
            }
            return ret;
        }
        #endregion 外部接口

        public static implicit operator ConfigTemplate(byte[] data)
        {
            return ParseFromByteArray(new ConfigTemplate(), data);
        }

        private static ConfigTemplate ParseFromByteArray(ConfigTemplate ret, byte[] data)
        {
            fixed (byte* pData = &data[0])
            fixed (FaceSystemConfig* pfaceSystemConfig = &ret.faceSystemConfig)
            {
                memcpy(pfaceSystemConfig, pData, data.Length);
            }
            return ret;
        }
    }
}
