// 从C/C++头文件翻译而来，请勿修改，也勿直接引用


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace HaSdkWrapper
{

    public partial class NativeConstants
    {

        /// ERR_NONE -> 0
        public const int ERR_NONE = 0;

        /// ERR_INVALID_PARAM -> -1
        public const int ERR_INVALID_PARAM = -1;

        /// ERR_TIMEOUT -> -2
        public const int ERR_TIMEOUT = -2;

        /// ERR_SEND_BUF_FULL -> -3
        public const int ERR_SEND_BUF_FULL = -3;

        /// ERR_SYS_NOT_MATCH -> -4
        public const int ERR_SYS_NOT_MATCH = -4;

        /// ERR_UNCONNECTED -> -5
        public const int ERR_UNCONNECTED = -5;

        /// ERR_SNAPSHOT_UNAVAILABLE -> -6
        public const int ERR_SNAPSHOT_UNAVAILABLE = -6;

        /// ERR_JPEG_ENCODE_ERROR -> -7
        public const int ERR_JPEG_ENCODE_ERROR = -7;

        /// ERR_JPEG_BUF_TOO_SMALL -> -8
        public const int ERR_JPEG_BUF_TOO_SMALL = -8;

        /// ERR_CANCEL -> -9
        public const int ERR_CANCEL = -9;

        /// ERR_UNABLE_TO_OPEN_FILE -> -10
        public const int ERR_UNABLE_TO_OPEN_FILE = -10;

        /// ERR_NOT_IMPLEMENTED -> -11
        public const int ERR_NOT_IMPLEMENTED = -11;

        /// ERR_COUNT_INVALID -> -12
        public const int ERR_COUNT_INVALID = -12;

        /// ERR_OUT_PUT_OF_ARRAY -> -13
        public const int ERR_OUT_PUT_OF_ARRAY = -13;

        /// ERR_GET_FACE_FEATURE -> -14
        public const int ERR_GET_FACE_FEATURE = -14;

        /// ERR_FACE_ID_REPEAT -> -15
        public const int ERR_FACE_ID_REPEAT = -15;

        /// ERR_FACE_ID_NOT_EXITS -> -16
        public const int ERR_FACE_ID_NOT_EXITS = -16;

        /// ERR_GET_FACE_INIT -> -17
        public const int ERR_GET_FACE_INIT = -17;

        /// ERR_GET_FACE_ID -> -18
        public const int ERR_GET_FACE_ID = -18;

        /// ERR_SERIAL_INDEX -> -19
        public const int ERR_SERIAL_INDEX = -19;

        /// ERR_SYSTEM_REBOOT -> -20
        public const int ERR_SYSTEM_REBOOT = -20;

        /// ERR_APP_REBOOT -> -21
        public const int ERR_APP_REBOOT = -21;

        /// ERR_ENCODE_JPG -> -22
        public const int ERR_ENCODE_JPG = -22;

        /// ERR_FACES_NUM -> -23
        public const int ERR_FACES_NUM = -23;

        /// ERR_IMAGE_DECODE -> -24
        public const int ERR_IMAGE_DECODE = -24;

        /// ERR_IMAGE_SIZE -> -25
        public const int ERR_IMAGE_SIZE = -25;

        /// ERR_IMAGE_PATH -> -26
        public const int ERR_IMAGE_PATH = -26;

        /// ERR_SAVE_IMG_NUM -> -27
        public const int ERR_SAVE_IMG_NUM = -27;

        /// ERR_PTZ_CTRL -> -28
        public const int ERR_PTZ_CTRL = -28;

        /// ERR_PTZ_CTRL_MODE -> -29
        public const int ERR_PTZ_CTRL_MODE = -29;

        /// ERR_DAEMON_REQUEST -> -30
        public const int ERR_DAEMON_REQUEST = -30;

        /// ERR_UPPER_LIMIT -> -31
        public const int ERR_UPPER_LIMIT = -31;

        /// ERR_PROTOCAL_VER -> -32
        public const int ERR_PROTOCAL_VER = -32;

        /// ERR_REQUEST_CMD -> -33
        public const int ERR_REQUEST_CMD = -33;

        /// ERR_PACKET_DATA -> -34
        public const int ERR_PACKET_DATA = -34;

        /// ERR_AUTH_FAILED -> -35
        public const int ERR_AUTH_FAILED = -35;

        /// ERR_WRITE_DATA -> -36
        public const int ERR_WRITE_DATA = -36;

        /// ERR_READ_DATA -> -37
        public const int ERR_READ_DATA = -37;

        /// ERR_TWIST_FACE -> -38
        public const int ERR_TWIST_FACE = -38;

        /// ERR_EXTRACT_FEATURE -> -39
        public const int ERR_EXTRACT_FEATURE = -39;

        /// ERR_MIN_FACE -> -40
        public const int ERR_MIN_FACE = -40;

        /// ERR_QVALUE_TOO_SMALL -> -41
        public const int ERR_QVALUE_TOO_SMALL = -41;

        /// ERR_INVALID_SYNC_MODE -> -42
        public const int ERR_INVALID_SYNC_MODE = -42;

        /// ERR_WG_QUERY_MODE -> -43
        public const int ERR_WG_QUERY_MODE = -43;

        /// ERR_SYSTEM_BUSY -> -44
        public const int ERR_SYSTEM_BUSY = -44;

        /// ERR_VERSION_MATCH -> -45
        public const int ERR_VERSION_MATCH = -45;

        /// ERR_TOO_MUCH_FACE -> -46
        public const int ERR_TOO_MUCH_FACE = -46;

        /// ERR_FACE_INCOMPLETE -> -47
        public const int ERR_FACE_INCOMPLETE = -47;

        /// ERR_ANGLE_PITCH -> -48
        public const int ERR_ANGLE_PITCH = -48;

        /// ERR_ANGLE_YAW -> -49
        public const int ERR_ANGLE_YAW = -49;

        /// ERR_ANGLE_ROLL -> -50
        public const int ERR_ANGLE_ROLL = -50;

        /// ERR_MOUTH_OPEN -> -51
        public const int ERR_MOUTH_OPEN = -51;

        /// ERR_YINYANG_FACE -> -52
        public const int ERR_YINYANG_FACE = -52;

        public const int ERR_DARK_LIGHT = -53;     //光照太暗

        /// ERR_VISIBLE_TARGET -> -54
        public const int ERR_VISIBLE_TARGET = -54;

        /// ERR_INFRARED_TARGET -> -55
        public const int ERR_INFRARED_TARGET = -55;

        /// ERR_ABERRATION_TOO_BIG -> -56
        public const int ERR_ABERRATION_TOO_BIG = -56;

        public const int ERR_BRIGHT_LIGHT=-57 ;    //  光线太亮

        public const int ERR_FACE_FUZZY = -58;  //  人脸模糊

        /// ERR_REPLYCODE_FEATURE_VERSION -> -60
        public const int ERR_REPLYCODE_FEATURE_VERSION = -60;

        /// ERR_LACK_TWISTIMGE -> -61
        public const int ERR_LACK_TWISTIMGE = -61;

        ///ERR_FACE_EXISTED
        public const int ERR_FACE_EXISTED = -62;
        ///ERR_FUNC_AUTH -70   
        public const int ERR_FUNC_AUTH = -70;
        ///ERR_FUNC_AUTHORIZED          -71   //功能已授权
        public const int ERR_FUNC_AUTHORIZED = -71;
        ///ERR_UN_AUTH					 -72   //功能未授权
        public const int ERR_UN_AUTH = -72;

        public const int ERR_4GINFO = -75;   //获取4G信号消息失败

        public const int ERR_PING_BLOCK = -76;   //ping网址失败

        public const int ERR_WIFIUNCONNECTED = -80;   //wifi未连接

        /// ERR_UNKNOWN -> -1000
        public const int ERR_UNKNOWN = -1000;

        /// MCAST_PORT -> 6100
        public const int MCAST_PORT = 6100;

        /// MCAST_IP_D -> "224.0.1.1"
        public const string MCAST_IP_D = "224.0.1.1";

        /// MSG_PACKET_PROGRESS -> 3001
        public const int MSG_PACKET_PROGRESS = 3001;

        /// MSG_PACKET_ADVANCE -> 3002
        public const int MSG_PACKET_ADVANCE = 3002;

        /// MSG_PACKET_CMCAST -> 3003
        public const int MSG_PACKET_CMCAST = 3003;

        /// MSG_PACKET_CMCAST_ACK -> 3004
        public const int MSG_PACKET_CMCAST_ACK = 3004;

        /// MSG_PACKET_IPSET -> 3005
        public const int MSG_PACKET_IPSET = 3005;

        /// MAX_LANE_NUM -> (4)
        public const int MAX_LANE_NUM = 4;

        /// MAX_FLASH_NUM -> (4)
        public const int MAX_FLASH_NUM = 4;

        /// MAX_RADAR_NUM -> (4)
        public const int MAX_RADAR_NUM = 4;

        /// MAX_INPUT_IO_NUM -> (8)
        public const int MAX_INPUT_IO_NUM = 8;

        /// MAX_COIL_GROUP -> (4)
        public const int MAX_COIL_GROUP = 4;

        /// MAX_CABINET_STATE -> (8)
        public const int MAX_CABINET_STATE = 8;

        /// HA_SERIA_RS485 -> (1)
        public const int HA_SERIA_RS485 = 1;

        /// HA_SERIA_RS232 -> (2)
        public const int HA_SERIA_RS232 = 2;

        /// MAX_IMG_NUM -> 4
        public const int MAX_IMG_NUM = 4;

        /// MAX_VIDEO_NUM -> 2
        public const int MAX_VIDEO_NUM = 2;

        /// MAX_PLATE_IMG_NUM -> 2
        public const int MAX_PLATE_IMG_NUM = 2;

        /// MAX_FACE_IMG_NUM -> 32
        public const int MAX_FACE_IMG_NUM = 32;

        /// TL_HEADER_SIZE -> 8
        public const int TL_HEADER_SIZE = 8;

        /// PROTOCOL_MAJOR -> 0
        public const int PROTOCOL_MAJOR = 0;

        /// PROTOCOL_MINOR -> 2
        public const int PROTOCOL_MINOR = 2;

        /// SYS_TYPE_EP -> 1
        public const int SYS_TYPE_EP = 1;

        /// SYS_TYPE_GW -> 2
        public const int SYS_TYPE_GW = 2;

        /// SYS_TYPE_GKJ -> 3
        public const int SYS_TYPE_GKJ = 3;

        /// SYS_TYPE_ILLEGALPARK -> 4
        public const int SYS_TYPE_ILLEGALPARK = 4;

        /// SYS_TYPE_MIDDLEWARE -> 5
        public const int SYS_TYPE_MIDDLEWARE = 5;

        /// SYS_TYPE_FACE_CAR_GW -> 6
        public const int SYS_TYPE_FACE_CAR_GW = 6;

        /// SYS_TYPE_PARK -> 7
        public const int SYS_TYPE_PARK = 7;

        /// SYSTEM_TYPE_FACE -> 12
        public const int SYSTEM_TYPE_FACE = 12;

        /// MESSAGE_ID_REBOOT -> 0
        public const int MESSAGE_ID_REBOOT = 0;

        /// MESSAGE_ID_RESTART -> 1
        public const int MESSAGE_ID_RESTART = 1;

        /// MESSAGE_ID_HEART_BEAT -> 2
        public const int MESSAGE_ID_HEART_BEAT = 2;

        /// MESSAGE_ID_SYNCTIME -> 3
        public const int MESSAGE_ID_SYNCTIME = 3;

        /// MESSAGE_ID_REPLY -> 4
        public const int MESSAGE_ID_REPLY = 4;

        /// MESSAGE_ID_CAR -> 5
        public const int MESSAGE_ID_CAR = 5;

        /// MESSAGE_ID_GET_FIRMWARE_VER -> 6
        public const int MESSAGE_ID_GET_FIRMWARE_VER = 6;

        /// MESSAGE_ID_WORK_STATE -> 7
        public const int MESSAGE_ID_WORK_STATE = 7;

        /// MESSAGE_ID_SERIAL_READ -> 8
        public const int MESSAGE_ID_SERIAL_READ = 8;

        /// MESSAGE_ID_REQ_SYS_TIME -> 11
        public const int MESSAGE_ID_REQ_SYS_TIME = 11;

        /// MESSAGE_ID_SET_SYS_TIME -> 12
        public const int MESSAGE_ID_SET_SYS_TIME = 12;

        /// MESSAGE_ID_REQ_NTP_INFO -> 13
        public const int MESSAGE_ID_REQ_NTP_INFO = 13;

        /// MESSAGE_ID_SET_NTP_INFO -> 14
        public const int MESSAGE_ID_SET_NTP_INFO = 14;

        /// MESSAGE_ID_REQ_NET_INFO -> 15
        public const int MESSAGE_ID_REQ_NET_INFO = 15;

        /// MESSAGE_ID_SET_NET_INFO -> 16
        public const int MESSAGE_ID_SET_NET_INFO = 16;

        /// MESSAGE_ID_SERIAL232_READ -> 80
        public const int MESSAGE_ID_SERIAL232_READ = 80;

        /// MESSAGE_ID_SERIAL_WRITE -> 9
        public const int MESSAGE_ID_SERIAL_WRITE = 9;

        /// MESSAGE_ID_REQ_AUTH -> 101
        public const int MESSAGE_ID_REQ_AUTH = 101;

        /// MESSAGE_ID_SET_AUTH -> 102
        public const int MESSAGE_ID_SET_AUTH = 102;

        /// MESSAGE_ID_LIVE_IMAGE -> 103
        public const int MESSAGE_ID_LIVE_IMAGE = 103;

        /// MESSAGE_ID_ALG_IMAGE -> 104
        public const int MESSAGE_ID_ALG_IMAGE = 104;

        /// MESSAGE_ID_LAMP_STATE -> 105
        public const int MESSAGE_ID_LAMP_STATE = 105;

        /// MESSAGE_ID_PLATE_IMAGE -> 106
        public const int MESSAGE_ID_PLATE_IMAGE = 106;

        /// MESSAGE_ID_RADAR_STATE -> 107
        public const int MESSAGE_ID_RADAR_STATE = 107;

        /// MESSAGE_ID_COIL_STATE -> 108
        public const int MESSAGE_ID_COIL_STATE = 108;

        /// MESSAGE_ID_DMODE_STATE -> 109
        public const int MESSAGE_ID_DMODE_STATE = 109;

        /// MESSAGE_ID_GPIO_SET -> 110
        public const int MESSAGE_ID_GPIO_SET = 110;

        /// MESSAGE_ID_GW_TEST_AUDIO -> 111
        public const int MESSAGE_ID_GW_TEST_AUDIO = 111;

        /// MESSAGE_ID_GW_GET_AUDIOLIST -> 113
        public const int MESSAGE_ID_GW_GET_AUDIOLIST = 113;

        /// MESSAGE_ID_SET_WHITELIST -> 114
        public const int MESSAGE_ID_SET_WHITELIST = 114;

        /// MESSAGE_ID_GET_WHITELIST -> 115
        public const int MESSAGE_ID_GET_WHITELIST = 115;

        /// MESSAGE_ID_SET_ALARM -> 116
        public const int MESSAGE_ID_SET_ALARM = 116;

        /// MESSAGE_ID_BACKUP_USER_DEFAULT -> 117
        public const int MESSAGE_ID_BACKUP_USER_DEFAULT = 117;

        /// MESSAGE_ID_RESTORE_USER_DEFAULT -> 118
        public const int MESSAGE_ID_RESTORE_USER_DEFAULT = 118;

        /// MESSAGE_ID_RESTORE_MANNUF_DEFAULT -> 119
        public const int MESSAGE_ID_RESTORE_MANNUF_DEFAULT = 119;

        /// MESSAGE_ID_CUSTOMER_GET_SN -> 120
        public const int MESSAGE_ID_CUSTOMER_GET_SN = 120;

        /// MESSAGE_ID_CUSTOMER_READ_AUTHCODE -> 121
        public const int MESSAGE_ID_CUSTOMER_READ_AUTHCODE = 121;

        /// MESSAGE_ID_CUSTOMER_WRITE_AUTHCODE -> 122
        public const int MESSAGE_ID_CUSTOMER_WRITE_AUTHCODE = 122;

        /// MESSAGE_ID_QUERY_DISK -> 123
        public const int MESSAGE_ID_QUERY_DISK = 123;

        /// MESSAGE_ID_FORMAT_DISK -> 124
        public const int MESSAGE_ID_FORMAT_DISK = 124;

        /// MESSAGE_ID_PLAY_AUDIO_STREAM -> 125
        public const int MESSAGE_ID_PLAY_AUDIO_STREAM = 125;

        /// MESSAGE_ID_SIMPLE_CARINFO -> 126
        public const int MESSAGE_ID_SIMPLE_CARINFO = 126;

        /// MESSAGE_ID_GET_SIMPLE_WLIST -> 127
        public const int MESSAGE_ID_GET_SIMPLE_WLIST = 127;

        /// MESSAGE_ID_SET_SIMPLE_WLIST -> 128
        public const int MESSAGE_ID_SET_SIMPLE_WLIST = 128;

        /// MESSAGE_ID_GET_REGINFO -> 129
        public const int MESSAGE_ID_GET_REGINFO = 129;

        /// MESSAGE_ID_UPDATE_ONE_WHITELIST -> 130
        public const int MESSAGE_ID_UPDATE_ONE_WHITELIST = 130;

        /// MESSAGE_ID_DELETE_ONE_WHITELIST -> 131
        public const int MESSAGE_ID_DELETE_ONE_WHITELIST = 131;

        /// MESSAGE_ID_QUERY_ONE_WHITELIST -> 132
        public const int MESSAGE_ID_QUERY_ONE_WHITELIST = 132;

        /// MESSAGE_ID_QUERY_DB_COUNT -> 133
        public const int MESSAGE_ID_QUERY_DB_COUNT = 133;

        /// MESSAGE_ID_QUERY_DB_RECORD -> 134
        public const int MESSAGE_ID_QUERY_DB_RECORD = 134;

        /// MESSAGE_ID_CAR_PARK_VZ -> 135
        public const int MESSAGE_ID_CAR_PARK_VZ = 135;

        /// MESSAGE_ID_QUERY_DB_RECORD_BY_ID -> 136
        public const int MESSAGE_ID_QUERY_DB_RECORD_BY_ID = 136;

        /// MESSAGE_ID_GET_NET_AUTH -> 143
        public const int MESSAGE_ID_GET_NET_AUTH = 143;

        /// MESSAGE_ID_RESET_USER_INFO -> 144
        public const int MESSAGE_ID_RESET_USER_INFO = 144;

        /// MESSAGE_ID_REQ_CONFIG -> 201
        public const int MESSAGE_ID_REQ_CONFIG = 201;

        /// MESSAGE_ID_SET_CONFIG -> 202
        public const int MESSAGE_ID_SET_CONFIG = 202;

        /// MESSAGE_ID_RESET_CONFIG -> 203
        public const int MESSAGE_ID_RESET_CONFIG = 203;

        /// MESSAGE_ID_REQ_CAM_PARAM -> 204
        public const int MESSAGE_ID_REQ_CAM_PARAM = 204;

        /// MESSAGE_ID_SET_CAM_PARAM -> 205
        public const int MESSAGE_ID_SET_CAM_PARAM = 205;

        /// MESSAGE_ID_RESET_CAM_PARAM -> 206
        public const int MESSAGE_ID_RESET_CAM_PARAM = 206;

        /// MESSAGE_ID_REQ_TEMP_CONFIG -> 207
        public const int MESSAGE_ID_REQ_TEMP_CONFIG = 207;

        /// MESSAGE_ID_SET_TEMP_CONFIG -> 208
        public const int MESSAGE_ID_SET_TEMP_CONFIG = 208;

        /// MESSAGE_ID_RESET_TEMP_CONFIG -> 209
        public const int MESSAGE_ID_RESET_TEMP_CONFIG = 209;

        /// MESSAGE_ID_PL_STATUS -> 210
        public const int MESSAGE_ID_PL_STATUS = 210;

        /// MESSAGE_ID_SOFT_TRIGG -> 211
        public const int MESSAGE_ID_SOFT_TRIGG = 211;

        /// MESSAGE_ID_SEND_UP_OFFLINE_DATA -> 216
        public const int MESSAGE_ID_SEND_UP_OFFLINE_DATA = 216;

        /// MESSAGE_ID_QUERY_OFFLINE_DATA -> 217
        public const int MESSAGE_ID_QUERY_OFFLINE_DATA = 217;

        /// MESSAGE_ID_QUERY_COUNT_AND_MONEY_DATA -> 218
        public const int MESSAGE_ID_QUERY_COUNT_AND_MONEY_DATA = 218;

        /// MESSAGE_ID_DELETE_OFFLINE_DATA -> 219
        public const int MESSAGE_ID_DELETE_OFFLINE_DATA = 219;

        /// MESSAGE_ID_QUERY_OFFLINE_ENTRY_TIME_BY_PLATE -> 220
        public const int MESSAGE_ID_QUERY_OFFLINE_ENTRY_TIME_BY_PLATE = 220;

        /// MESSAGE_ID_LOG -> 300
        public const int MESSAGE_ID_LOG = 300;

        /// MESSAGE_ID_QUREY_FACE -> 401
        public const int MESSAGE_ID_QUREY_FACE = 401;

        /// MESSAGE_ID_REG_FACE -> 402
        public const int MESSAGE_ID_REG_FACE = 402;

        /// MESSAGE_ID_MODIFY_FACE -> 403
        public const int MESSAGE_ID_MODIFY_FACE = 403;

        /// MESSAGE_ID_DELETE_FACE -> 404
        public const int MESSAGE_ID_DELETE_FACE = 404;

        /// MESSAGE_ID_REQ_SYS_STORAGE -> 500
        public const int MESSAGE_ID_REQ_SYS_STORAGE = 500;

        /// MESSAGE_ID_SET_SYS_STORAGE -> 501
        public const int MESSAGE_ID_SET_SYS_STORAGE = 501;

        /// MESSAGE_ID_REQ_SYS_NETWORK -> 502
        public const int MESSAGE_ID_REQ_SYS_NETWORK = 502;

        /// MESSAGE_ID_SET_SYS_NETWORK -> 503
        public const int MESSAGE_ID_SET_SYS_NETWORK = 503;

        /// MESSAGE_ID_REQ_TIME -> 504
        public const int MESSAGE_ID_REQ_TIME = 504;

        /// MESSAGE_ID_HASX_REQ_CAM_PARAM -> 500
        public const int MESSAGE_ID_HASX_REQ_CAM_PARAM = 500;

        /// MESSAGE_ID_HASX_SET_CAM_PARAM -> 501
        public const int MESSAGE_ID_HASX_SET_CAM_PARAM = 501;

        /// MESSAGE_ID_HASX_RESET_CAM_PARAM -> 502
        public const int MESSAGE_ID_HASX_RESET_CAM_PARAM = 502;

        /// MESSAGE_ID_HASX_REQ_CAM_PARAM_ONE -> 503
        public const int MESSAGE_ID_HASX_REQ_CAM_PARAM_ONE = 503;

        /// MESSAGE_ID_HASX_SET_CAM_PARAM_ONE -> 504
        public const int MESSAGE_ID_HASX_SET_CAM_PARAM_ONE = 504;

        /// MESSAGE_ID_HASX_LIVE_IMAGE -> 505
        public const int MESSAGE_ID_HASX_LIVE_IMAGE = 505;

        /// MESSAGE_ID_UPDATE -> 900
        public const int MESSAGE_ID_UPDATE = 900;

        /// MESSAGE_ID_REQ_SYS_INFO -> 1000
        public const int MESSAGE_ID_REQ_SYS_INFO = 1000;

        /// MESSAGE_ID_MAX -> 1023
        public const int MESSAGE_ID_MAX = 1023;

        /// REPLYCODE_OK -> (0)
        public const int REPLYCODE_OK = 0;

        /// REPLYCODE_PROTOCOL_UNMATCH -> (1)
        public const int REPLYCODE_PROTOCOL_UNMATCH = 1;

        /// REPLYCODE_MESSAGEID_ERROR -> (2)
        public const int REPLYCODE_MESSAGEID_ERROR = 2;

        /// REPLYCODE_ERROR_VALUE -> (3)
        public const int REPLYCODE_ERROR_VALUE = 3;

        /// DATA_TYPE_FACE_CAR_FACE -> 0
        public const int DATA_TYPE_FACE_CAR_FACE = 0;

        /// DATA_TYPE_FACE_CAR_CAR -> 1
        public const int DATA_TYPE_FACE_CAR_CAR = 1;

    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct CamCtrlLED
    {

        /// int
        public int seq;

        /// int
        public int lightType;

        /// int
        public int hz;

        /// int
        public int trigType;

        /// int
        public int phase;

        /// int
        public int pulseWidth;

        /// int[32]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = System.Runtime.InteropServices.UnmanagedType.I4)]
        public int[] rev;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct CamCtrlAutoCtrl
    {

        /// int
        public int standard;

        /// int
        public int maxShut;

        /// int
        public int minShut;

        /// int
        public int maxGain;

        /// int[4]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = System.Runtime.InteropServices.UnmanagedType.I4)]
        public int[] gainLevel;

        /// int[6]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = System.Runtime.InteropServices.UnmanagedType.I4)]
        public int[] agcSelect;

        /// int[32]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = System.Runtime.InteropServices.UnmanagedType.I4)]
        public int[] rev;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct CamCtrlMannualCtrl
    {

        /// int
        public int manualShut;

        /// int
        public int mannuGainLevel;

        /// int
        public int mannualGainValue;

        /// int
        public int mannualR;

        /// int
        public int mannualGr;

        /// int
        public int mannualGb;

        /// int
        public int mannualB;

        /// int
        public int mannualRoft;

        /// int
        public int mannualGroft;

        /// int
        public int mannualGboft;

        /// int
        public int mannualBoft;

        /// int[32]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = System.Runtime.InteropServices.UnmanagedType.I4)]
        public int[] rev;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct CamCtrlImageEnhance
    {

        /// int
        public int imgSaturability;

        /// int
        public int imgContrast;

        /// int
        public int imgSharpen;

        /// int
        public int imgNoise;

        /// int
        public int imgGamma;

        /// int
        public int imgGammaEnable;

        /// int[31]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 31, ArraySubType = System.Runtime.InteropServices.UnmanagedType.I4)]
        public int[] rev;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct CamCtrlTrigIO
    {

        /// int
        public int trigType;

        /// int
        public int trigNum;

        /// int[2]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = System.Runtime.InteropServices.UnmanagedType.I4)]
        public int[] trigInter;

        /// int
        public int flashEable;

        /// int
        public int flashIndex;

        /// int[8]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = System.Runtime.InteropServices.UnmanagedType.I4)]
        public int[] rev;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct CamCtrlExtSync
    {

        /// int
        public int enable;

        /// int
        public int phase;

        /// int
        public int filter;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct CamCtrl
    {

        /// int
        public int enableAutoExp;

        /// int
        public int enableAutoAwb;

        /// CamCtrlAutoCtrl
        public CamCtrlAutoCtrl autoCtrl;

        /// CamCtrlMannualCtrl
        public CamCtrlMannualCtrl manualCtrl;

        /// CamCtrlImageEnhance
        public CamCtrlImageEnhance imgEnhance;

        /// CamCtrlLED[5]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 5, ArraySubType = System.Runtime.InteropServices.UnmanagedType.Struct)]
        public CamCtrlLED[] led;

        /// CamCtrlTrigIO[8]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = System.Runtime.InteropServices.UnmanagedType.Struct)]
        public CamCtrlTrigIO[] trigIO;

        /// CamCtrlExtSync
        public CamCtrlExtSync extSync;

        /// int
        public int jpegQ;

        /// int
        public int h264W;

        /// int
        public int h264H;

        /// int
        public int h264Bitrate;

        /// int
        public int ip;

        /// int
        public int netmask;

        /// int
        public int gateway;

        /// int
        public int systime;

        /// unsigned short
        public ushort trig_shut;

        /// unsigned short
        public ushort trig_gain;

        /// int
        public int sensorType;

        /// int[126]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 126, ArraySubType = System.Runtime.InteropServices.UnmanagedType.I4)]
        public int[] rev;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct DayTime
    {

        /// unsigned char
        public byte startHour;

        /// unsigned char
        public byte startMinute;

        /// unsigned char
        public byte endHour;

        /// unsigned char
        public byte endMinute;
    }

    public enum CAM_TYPE
    {

        CAM_TYPE_TI8127,

        CAM_TYPE_S2,
    }

    public enum STREAM_FORMAT
    {

        /// STREAM_FORMAT_JPEG -> 1
        STREAM_FORMAT_JPEG = 1,

        /// STREAM_FORMAT_H264 -> 2
        STREAM_FORMAT_H264 = 2,
    }

    public enum CHAR_ENCODE
    {

        /// CHAR_ENCODE_GBK -> 0
        CHAR_ENCODE_GBK = 0,

        CHAR_ENCODE_UTF8,
    }

    public enum TRIG_TYPE
    {

        TRIG_TYPE_VIDEO,

        TRIG_TYPE_COIL,

        TRIG_TYPE_SOFT,

        TRIG_TYPE_RADIA,
    }

    public enum UploadMode
    {

        /// UPLOAD_MODE_NULL -> 0
        UPLOAD_MODE_NULL = 0,

        /// UPLOAD_MODE_TCP -> 1
        UPLOAD_MODE_TCP = 1,

        /// UPLOAD_MODE_FTP -> 2
        UPLOAD_MODE_FTP = 2,

        /// UPLOAD_MODE_HTTP -> 3
        UPLOAD_MODE_HTTP = 3,
    }

    public enum UPLOAD_MODE
    {

        /// UPLOAD_MODE_TCP -> 0
        UPLOAD_MODE_TCP = 0,

        UPLOAD_MODE_FTP,
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct HA_LiveStream
    {

        /// int
        public int w;

        /// int
        public int h;

        /// STREAM_FORMAT->Anonymous_82fe6ace_67d9_4f6e_ae7f_974b643259dc
        public STREAM_FORMAT format;

        /// int
        public int streamLen;

        /// int
        public int streamBufSize;

        /// char*
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)]
        public string streamBuf;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
    public struct FeeInfoRes
    {

        /// char[16]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 16)]
        public string plate;

        /// time_t->__time32_t->int
        public int time_in;

        /// time_t->__time32_t->int
        public int time_out;

        /// float
        public float park_fee;

        /// unsigned short
        public ushort fee_mode;

        /// unsigned char
        public byte platecolor;

        /// unsigned char
        public byte InOut_type;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
    public struct FeeInfo
    {

        /// char[16]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 16)]
        public string plate;

        /// unsigned short
        public ushort in_year;

        /// unsigned short
        public ushort in_month;

        /// unsigned short
        public ushort in_day;

        /// unsigned short
        public ushort in_hour;

        /// unsigned short
        public ushort in_min;

        /// unsigned short
        public ushort in_sec;

        /// unsigned short
        public ushort out_year;

        /// unsigned short
        public ushort out_month;

        /// unsigned short
        public ushort out_day;

        /// unsigned short
        public ushort out_hour;

        /// unsigned short
        public ushort out_min;

        /// unsigned short
        public ushort out_sec;

        /// float
        public float park_fee;

        /// unsigned short
        public ushort fee_mode;

        /// unsigned char
        public byte platecolor;

        /// unsigned char
        public byte InOut_type;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
    public struct FeeInfoEx
    {

        /// char[16]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 16)]
        public string plate;

        /// unsigned short
        public ushort year_in;

        /// unsigned char
        public byte mon_in;

        /// unsigned char
        public byte day_in;

        /// unsigned char
        public byte hour_in;

        /// unsigned char
        public byte min_in;

        /// unsigned short
        public ushort sec_in;

        /// unsigned short
        public ushort year_out;

        /// unsigned char
        public byte mon_out;

        /// unsigned char
        public byte day_out;

        /// unsigned char
        public byte hour_out;

        /// unsigned char
        public byte min_out;

        /// unsigned short
        public ushort sec_out;

        /// float
        public float park_fee;

        /// unsigned short
        public ushort fee_mode;

        /// unsigned char
        public byte platecolor;

        /// unsigned char
        public byte InOut_type;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
    public struct HA_AllowList
    {

        /// char[16]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 16)]
        public string plate;

        /// unsigned short
        public ushort plateColor;

        /// unsigned short
        public ushort year;

        /// unsigned short
        public ushort month;

        /// unsigned short
        public ushort day;

        /// unsigned char
        public byte hour;

        /// unsigned char
        public byte AnonymousMember1;

        /// unsigned char
        public byte sec;

        /// unsigned char
        public byte bEnable;

        /// unsigned short
        public ushort enable_year;

        /// unsigned char
        public byte enable_month;

        /// unsigned char
        public byte enable_day;

        /// unsigned char
        public byte enable_hour;

        /// unsigned char
        public byte enable_min;

        /// unsigned char
        public byte enable_sec;

        /// unsigned char
        public byte bAlarm;

        /// int[13]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 13, ArraySubType = System.Runtime.InteropServices.UnmanagedType.I4)]
        public int[] resv;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
    public struct VERSION
    {

        /// char[64]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 64)]
        public string protocl_version;

        /// char[64]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 64)]
        public string arm_version;

        /// char[64]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 64)]
        public string arm_buildtime;

        /// char[64]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 64)]
        public string arm_code_version;

        /// char[64]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 64)]
        public string dsp_version;

        /// char[64]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 64)]
        public string dsp_buildtime;

        /// char[64]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 64)]
        public string dsp_code_version;

        /// unsigned short
        public ushort video_width;

        /// unsigned short
        public ushort video_height;
    }
  
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
    public struct AudioItem
    {

        /// int
        public int id;

        /// char[64]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 64)]
        public string desc;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
    public struct FaceRecoInfo
    {

        /// unsigned int
        public uint sequence;

        /// char[32]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 32)]
        public byte[] camId;

        /// char[32]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 32)]
        public byte[] posId;

        /// char[96]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 96)]
        public byte[] posName;

        /// unsigned int
        public uint tvSec;

        /// unsigned int
        public uint tvUsec;

        /// short
        public short isRealtimeData;

        /// short
        public short matched;

        /// char[20]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 20)]
        public byte[] matchPersonId;

        /// char[16]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 16)]
        private byte[] _matchPersonName;

        /// int
        public int matchRole;

        /// int
        public int existImg;

        /// char[4]
        
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 4)]
        public string imgFormat;

        /// int
        public int imgLen;

        /// unsigned short
        public ushort faceXInImg;

        /// unsigned short
        public ushort faceYInImg;

        /// unsigned short
        public ushort faceWInImg;

        /// unsigned short
        public ushort faceHInImg;

        /// int
        public int existFaceImg;

        /// char[4]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 4)]
        public string faceImgFormat;

        /// int
        public int faceImgLen;

        /// unsigned short
        public ushort faceXInFaceImg;

        /// unsigned short
        public ushort faceYInFaceImg;

        /// unsigned short
        public ushort faceWInFaceImg;

        /// unsigned short
        public ushort faceHInFaceImg;

        /// int
        public int existVideo;

        /// unsigned int
        public uint videoStartSec;

        /// unsigned int
        public uint videoStartUsec;

        /// unsigned int
        public uint videoEndSec;

        /// unsigned int
        public uint videoEndUsec;

        /// char[4]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 4)]
        public string videoFormat;

        /// int
        public int videoLen;

        /// unsigned char
        public byte sex;

        /// unsigned char
        public byte age;

        /// unsigned char
        public byte expression;

        /// unsigned char
        public byte skinColour;

        /// unsigned char
        public byte qValue;

        public byte sourceOfReg;
        public byte attributeOfReg;
      
        /// 活体
        public byte living;
        /// 枚举 
        public byte hatColour;

        public byte FaceAngle;
        public byte FaceAngleFlat;
        public byte res0;
        public MatchType math_type;

        public int wgCardNO;

        public long wgCardNOLong;

        /// char[100]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 95)]
        public string resv;
        public byte hasMask;
        public float temperature;
        /// unsigned char*
        public System.IntPtr img;

        /// unsigned char*
        public System.IntPtr faceImg;

        /// unsigned char*
        public System.IntPtr video;

        public int feature_size;
        public IntPtr feature;
        public int modelFaceImgLen;
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 4)]
        public string modelFaceImgFmt;
        public IntPtr modelFaceImg;
        /// char[80]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 80)]
        public string resv1;

        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 32)]
        public string dev_id;
        /// <summary>
        /// 是否存在身份信息
        /// </summary>
        public int existIDCard;
        /// <summary>
        /// 身份证号
        /// </summary>
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 36)]
        public string IDCardnumber;
        /// <summary>
        /// 姓名
        /// </summary>
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 43)]
        public byte[] IDCardname;
        /// <summary>
        /// 性别
        /// </summary>
        public byte IDCardsex;
        /// <summary>
        /// 民族
        /// </summary>
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 19)]
        public byte[] IDCardnational;
        /// <summary>
        /// 出生日期
        /// </summary>
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 17)]
        public string IDCardbirth;
        /// <summary>
        /// 地址
        /// </summary>
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 103)]
        public byte[] IDCardresidence_address;
        /// <summary>
        /// 签发机关
        /// </summary>
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 43)]
        public byte[] IDCardorgan_issue;
        /// <summary>
        /// 有效期起始时间
        /// </summary>
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 17)]
        public string IDCardvalid_date_start;

        /// <summary>
        ///有效期截止时间
        /// </summary>
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 17)]
        public string IDCardvalid_date_end;
        
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 68)]
        private byte[] _userParam;

        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 64)]
        private byte[] _matchPersonIDEx; //id 加密后密文


        byte person_name_aes_len;  // 加密后姓名密文长度
        byte person_id_aes_len;  // 加密后id密文长度

        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 512)]
        private byte[] _trip_info;


        /// <summary>
        /// 自定义字段
        /// </summary>
        public string userParam
        {
            get
            {
                var s = Encoding.UTF8.GetString(_userParam).TrimZeroChar();
                return s;
            }
        }

        public string matchPersonIDEx
        {
            get
            {
                return Encoding.UTF8.GetString(_matchPersonIDEx).TrimZeroChar();
            }
        }

        public string trip_info
        {
            get
            {
                return Encoding.UTF8.GetString(_trip_info).TrimZeroChar();
            }
        }

        
        public string matchPersonName
        {
            get
            {
                var isNullString = _matchPersonName[0];
                if (isNullString != 0) return Encoding.UTF8.GetString(_matchPersonName).TrimZeroChar();

                isNullString = _matchPersonIDEx[0];
                if (isNullString != 0) return Encoding.UTF8.GetString(_matchPersonIDEx).TrimZeroChar();

                return null;
            }
        }
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
    public struct FaceFlags
    {

        /// char[20]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 20)]
        public byte[] faceID;

        /// char[16]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 16)]
        public byte[] faceName;

        /// int
        public int role;

        /// unsigned int
        public uint wgCardNO;

        /// unsigned int
        public uint effectTime;
        public uint effectStartTime;

        public short version;
     
        public long wgCardNOLong;

        public byte ScheduleMode;
        public byte resv2;
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 68)]
        public byte[] userParam;//自定义字段

        /// char[8188]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 8104)]
        public byte[] resv;
    }


    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
    public struct QueryFaceFlags
    {

        /// char[20]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 20)]
        public byte[] personID;

        /// char[16]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 16)]
        public byte[] personName;

        /// int
        public int featureSize;

        /// unsigned char[1024]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 2048)]
        public float[] feature;

        /// int
        public int imgNum;

        /// int
        public int imgSize;

        /// unsigned char[10240]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 10240)]
        public byte[] img;

        /// char[16]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 16)]
        public byte[] resv;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
    public struct ipscan_t
    {

        /// char[20]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 20)]
        public byte[] mac;

        /// char[20]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 20)]
        public byte[] ip;

        /// char[20]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 20)]
        public byte[] netmask;

        /// char[16]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 16)]
        public byte[] manufacturer;

        /// char[32]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 32)]
        public byte[] platform;

        /// char[32]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 32)]
        public byte[] system;

        /// char[64]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 64)]
        public byte[] version;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
    public struct ipset_t
    {

        /// char[20]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 20)]
        public string mac;

        /// char[20]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 20)]
        public string ip;

        /// char[20]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 20)]
        public string netmask;

        /// char[20]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 20)]
        public string gateway;
    }

    /// Return Type: void
    ///ipscan: ipscan_t*
    ///usr_param: int
    [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute(System.Runtime.InteropServices.CallingConvention.StdCall)]
    public delegate void discover_ipscan_cb_t(IntPtr ipscan, int usr_param);

    public enum ImageForm
    {

        /// IMAGE_FORM_NULL -> 0
        IMAGE_FORM_NULL = 0,

        /// IMAGE_FORM_OVERALL -> 0x1
        IMAGE_FORM_OVERALL = 1,

        /// IMAGE_FORM_FEATURE -> 0x1<<1
        IMAGE_FORM_FEATURE = (1) << (1),

        /// IMAGE_FORM_BOTH -> IMAGE_FORM_OVERALL|IMAGE_FORM_FEATURE
        IMAGE_FORM_BOTH = (ImageForm.IMAGE_FORM_OVERALL | ImageForm.IMAGE_FORM_FEATURE),
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct config_size
    {

        /// unsigned short
        public ushort width;

        /// unsigned short
        public ushort height;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct config_point
    {

        /// unsigned short
        public ushort x;

        /// unsigned short
        public ushort y;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct config_rect
    {

        /// unsigned short
        public ushort x;

        /// unsigned short
        public ushort y;

        /// unsigned short
        public ushort w;

        /// unsigned short
        public ushort h;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct config_worktime
    {

        /// unsigned char
        public byte start_hour;

        /// unsigned char
        public byte start_min;

        /// unsigned char
        public byte end_hour;

        /// unsigned char
        public byte end_min;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
    public struct config_addr
    {

        /// char[32]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 32)]
        public string device_id;

        /// char[32]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 32)]
        public string device_name;

        /// char[32]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 32)]
        public string addr_id;

        /// char[96]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 96)]
        public string addr_name;

        /// char[32]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 32)]
        public string direction_id;

        /// char[96]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 96)]
        public string direction_name;

        /// unsigned short
        public ushort lane_number;

        /// unsigned short
        public ushort lane_start_id;

        /// unsigned char[4]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 4)]
        public string match_light;

        /// char
        public byte master_mode;

        /// char
        public byte slave_mode;

        /// char
        public byte mode_change_threshold;

        /// unsigned char
        public byte serial_index;

        /// int
        public int serial_baudrate;

        /// unsigned char
        public byte serial_databit;

        /// unsigned char
        public byte serial_parity;

        /// unsigned char
        public byte serial_stopbit;

        /// char[113]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 113)]
        public string resv;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct coil_io_attr
    {

        /// unsigned char
        public byte group;

        /// unsigned char
        public byte index;

        /// unsigned char
        public byte count;

        /// unsigned char
        public byte match_light;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
    public struct config_coil
    {

        /// int
        public int enable;

        /// unsigned int
        public uint distance;

        /// coil_io_attr[8]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = System.Runtime.InteropServices.UnmanagedType.Struct)]
        public coil_io_attr[] io_attr;

        /// char[64]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 64)]
        public string resv;
    }

    public enum RADAR_TYPE
    {

        /// RADAR_TYPE_NONE -> 0
        RADAR_TYPE_NONE = 0,

        /// RADAR_TYPE_CSRIN -> 1
        RADAR_TYPE_CSRIN = 1,

        /// RADAR_TYPE_CSRIN_M -> 2
        RADAR_TYPE_CSRIN_M = 2,
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
    public struct config_radar
    {

        /// int
        public int enable;

        /// RADAR_TYPE
        public RADAR_TYPE type;

        /// unsigned int
        public uint count;

        /// unsigned char[4]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 4)]
        public string match_lane;

        /// unsigned char[4]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 4)]
        public string match_light;

        /// int
        public int enable_log;

        /// char[64]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 64)]
        public string resv;
    }

    public enum CALC_LANENO_METHOD
    {

        LEFT_TO_RIGHT,

        RIGHT_TO_LEFT,
    }

    public enum vdetect_type
    {

        VDETECT_TYPE_RECO,

        VDETECT_TYPE_DET,

        VDETECT_TYPE_BOTH,
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
    public struct config_vdetect
    {

        /// int
        public int enable;

        /// vdetect_type
        public vdetect_type type;

        /// int
        public int flash;

        /// int
        public int motion;

        /// int
        public int diff;

        /// config_rect
        public config_rect detect_area;

        /// config_rect
        public config_rect virtual_coil;

        /// int
        public int night_threshold;

        /// int
        public int rsv2;

        /// unsigned int
        public uint skip;

        /// unsigned int
        public uint cut;

        /// unsigned int
        public uint min_size;

        /// unsigned int
        public uint max_size;

        /// unsigned int
        public uint resize;

        /// float
        public float step;

        /// int
        public int debug;

        /// int
        public int draw_coil;

        /// int
        public int draw_area;

        /// CALC_LANENO_METHOD
        public CALC_LANENO_METHOD m;

        /// unsigned char[4]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 4)]
        public string match_light;

        /// config_point[4]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = System.Runtime.InteropServices.UnmanagedType.Struct)]
        public config_point[] virtual_coil_polygon;

        /// char[40]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 40)]
        public string resv;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
    public struct config_face_detect
    {

        /// int
        public int enable;

        /// int
        public int debug;

        /// config_rect
        public config_rect detect_area;

        /// config_size
        public config_size minsize;

        /// config_size
        public config_size maxsize;

        /// float
        public float step;

        /// float
        public float ratio;

        /// unsigned int
        public uint interval;

        /// unsigned int
        public uint use_motion;

        /// unsigned int
        public uint face_step;

        /// char[48]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 48)]
        public string resv;
    }

    public enum reco_filter_color
    {

        /// RECO_FILTER_BLUE -> 0
        RECO_FILTER_BLUE = 0,

        /// RECO_FILTER_BLACK -> 1
        RECO_FILTER_BLACK = 1,

        /// RECO_FILTER_YELLOW -> 2
        RECO_FILTER_YELLOW = 2,

        /// RECO_FILTER_WHITE -> 3
        RECO_FILTER_WHITE = 3,

        /// RECO_FILTER_GREEN -> 4
        RECO_FILTER_GREEN = 4,
    }

    public enum reco_filter_num
    {

        /// RECO_FILTER_NULL -> 0
        RECO_FILTER_NULL = 0,

        /// RECO_FILTER_XUE -> 1
        RECO_FILTER_XUE = 1,

        /// RECO_FILTER_JING -> 2
        RECO_FILTER_JING = 2,
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
    public struct config_reco
    {

        /// int
        public int enable;

        /// float
        public float ratio;

        /// char[16]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 16)]
        public string province;

        /// unsigned short
        public ushort min_width;

        /// unsigned short
        public ushort max_width;

        /// config_rect[4]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = System.Runtime.InteropServices.UnmanagedType.Struct)]
        public config_rect[] reco_area;

        /// int
        public int draw_reco_area;

        /// unsigned int
        public uint filter_color;

        /// unsigned int
        public uint filter_num;

        /// unsigned short
        public ushort same_plate_report_time;

        /// unsigned char
        public byte draw_reco_area_video;

        /// unsigned char
        public byte reco_mode;

        /// char[48]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 48)]
        public string resv;
    }

    public enum PLATE_FILTER_TYPE
    {

        /// PLATE_FILTER_TYPE_NONE -> 0
        PLATE_FILTER_TYPE_NONE = 0,
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
    public struct config_special
    {

        /// int
        public int merge_two;

        /// int
        public int keep_one;

        /// PLATE_FILTER_TYPE
        public PLATE_FILTER_TYPE plate_filter;

        /// char[32]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 32)]
        public string resv;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
    public struct config_limit_speed
    {

        /// unsigned short
        public ushort capture_count;

        /// unsigned short
        public ushort overspeed_count;

        /// unsigned int
        public uint interval;

        /// unsigned short[4]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = System.Runtime.InteropServices.UnmanagedType.U2)]
        public ushort[] lspeed;

        /// unsigned short[4]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = System.Runtime.InteropServices.UnmanagedType.U2)]
        public ushort[] rlspeed;

        /// char[32]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 32)]
        public string resv;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
    public struct config_net
    {

        /// UPLOAD_MODE
        public UPLOAD_MODE upload_mode;

        /// char[16]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 16)]
        public string ftp_server;

        /// char[16]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 16)]
        public string tcp_server;

        /// char[16]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 16)]
        public string ntp_server;

        /// int
        public int ntp_interval;

        /// unsigned short
        public ushort ftp_port;

        /// unsigned short
        public ushort tcp_port;

        /// char[32]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 32)]
        public string ftp_user;

        /// char[32]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 32)]
        public string ftp_passwd;

        /// char[16]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 16)]
        public string led_server;

        /// unsigned short
        public ushort led_port;

        /// unsigned short
        public ushort http_port;

        /// char[16]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 16)]
        public string http_server;

        /// char
        public byte tcp_enable;

        /// char
        public byte ftp_enable;

        /// char
        public byte led_enable;

        /// char
        public byte http_enable;

        /// char[88]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 88)]
        public string resv;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
    public struct CONF_OSD
    {

        /// unsigned short
        public ushort imgStartX;

        /// unsigned short
        public ushort imgStartY;

        /// unsigned char
        public byte imgFontSize;

        /// unsigned char[3]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 3)]
        public string imgFontColor;

        /// char[512]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 512)]
        public string imgOSDRules;

        /// char[16]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 16)]
        public string resv;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct lamp_area
    {

        /// int
        public int lamp_num;

        /// unsigned short
        public ushort only_red_x;

        /// unsigned short
        public ushort only_red_y;

        /// unsigned short
        public ushort only_red_w;

        /// unsigned short
        public ushort only_red_h;

        /// unsigned short
        public ushort all_lamp_x;

        /// unsigned short
        public ushort all_lamp_y;

        /// unsigned short
        public ushort all_lamp_w;

        /// unsigned short
        public ushort all_lamp_h;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
    public struct config_people_red
    {

        /// int
        public int enable;

        /// lamp_area
        public lamp_area lamp;

        /// char[64]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 64)]
        public string resv;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
    public struct config_gw_park
    {

        /// unsigned char
        public byte offline;

        /// unsigned char
        public byte alarm_out_mode;

        /// unsigned char
        public byte transfer_offline_data;

        /// unsigned char
        public byte diable_serial_output;

        /// unsigned char
        public byte same_count;

        /// unsigned char
        public byte min_volume;

        /// unsigned char
        public byte max_volume;

        /// unsigned char
        public byte cur_volume;

        /// unsigned char
        public byte light;

        /// unsigned char
        public byte drive_direct;

        /// unsigned char
        public byte ctrl_light_mode;

        /// unsigned char
        public byte day_brightness;

        /// unsigned short
        public ushort alarmOutDuration;

        /// unsigned char
        public byte disable_io_port;

        /// unsigned char
        public byte disable_io_output;

        /// unsigned char
        public byte gpio_in;

        /// unsigned char
        public byte gpio_out;

        /// unsigned char
        public byte flash_sync_out1;

        /// unsigned char
        public byte reboot_flag;

        /// unsigned char[16]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 16)]
        public string resv;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
    public struct config_carbinet_inturn_control
    {

        /// int
        public int isEnable;

        /// char[64]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 64)]
        public string ip;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
    public struct MessageCarPortState
    {

        /// int
        public int carPortState;

        /// int
        public int lightColor;

        /// int
        public int laneNum;

        /// int[4]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = System.Runtime.InteropServices.UnmanagedType.I4)]
        public int[] hasCar;

        /// int[4]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = System.Runtime.InteropServices.UnmanagedType.I4)]
        public int[] hasPlate;

        /// char[64]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 64)]
        public string plate;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct config_carbinet
    {

        /// int
        public int isSpecial;

        /// int
        public int portNum;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct config_carbinet_state
    {

        /// int
        public int isEnable;

        /// int
        public int isFlicker;

        /// int
        public int lightColor;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct config_carbinet_vdetect
    {

        /// config_point[16]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = System.Runtime.InteropServices.UnmanagedType.Struct)]
        public config_point[] inventedRoi;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct config_gw_car_port
    {

        /// int
        public int lightControlMode;

        /// config_carbinet_inturn_control
        public config_carbinet_inturn_control inturnControl;

        /// config_carbinet_state[8]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = System.Runtime.InteropServices.UnmanagedType.Struct)]
        public config_carbinet_state[] carbinetState;

        /// config_carbinet[4]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = System.Runtime.InteropServices.UnmanagedType.Struct)]
        public config_carbinet[] carbinet;

        /// config_carbinet_vdetect
        public config_carbinet_vdetect alg;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
    public struct config_http
    {

        /// char[20]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 20)]
        public string http_ip;

        /// unsigned short
        public ushort http_port;

        /// unsigned short
        public ushort ssl_port;

        /// int
        public int timeout;

        /// unsigned char
        public byte enable_ssl;

        /// unsigned char
        public byte enable_reg;

        /// unsigned char
        public byte enable_post_vehicle;

        /// unsigned char
        public byte enable_img;

        /// unsigned char
        public byte enable_plate_img;

        /// unsigned char
        public byte enable_post_io_info;

        /// unsigned char
        public byte enable_post_serial_data;

        /// unsigned char
        public byte vehicle_level;

        /// char[96]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 96)]
        public string reg_url;

        /// char[96]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 96)]
        public string post_vehicle_url;

        /// char[96]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 96)]
        public string post_ioinfo_url;

        /// char[96]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 96)]
        public string post_serial_url;

        /// unsigned char[128]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 128)]
        public string resv;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
    public struct device_group_cam_attr
    {

        /// char[20]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 20)]
        public string ip;

        /// char[32]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 32)]
        public string cam_name;

        /// char
        public byte assistFlag;

        /// char
        public byte inFlag;

        /// char[2]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 2)]
        public string resv;

        /// int[4]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = System.Runtime.InteropServices.UnmanagedType.I4)]
        public int[] r;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
    public struct device_group_gate_attr
    {

        /// char[32]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 32)]
        public string gate_name;

        /// int
        public int cam_num;

        /// device_group_cam_attr[4]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = System.Runtime.InteropServices.UnmanagedType.Struct)]
        public device_group_cam_attr[] attr;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
    public struct config_device_group
    {

        /// int
        public int enable_group;

        /// int
        public int enable_group_assist;

        /// char[20]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 20)]
        public string ip;

        /// int
        public int gate_num;

        /// device_group_gate_attr[8]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = System.Runtime.InteropServices.UnmanagedType.Struct)]
        public device_group_gate_attr[] attr;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct config_gateway
    {

        /// int
        public int magic_number;

        /// config_worktime
        public config_worktime worktime;

        /// config_addr
        public config_addr addr;

        /// config_reco
        public config_reco reco;

        /// config_limit_speed
        public config_limit_speed limit_speed;

        /// config_radar
        public config_radar radar;

        /// config_coil
        public config_coil coil;

        /// config_special
        public config_special special;

        /// config_net
        public config_net net;

        /// config_face_detect
        public config_face_detect face;

        /// config_vdetect
        public config_vdetect vdetect;

        /// config_people_red
        public config_people_red people_red;

        /// config_gw_park
        public config_gw_park park;

        /// config_gw_car_port
        public config_gw_car_port carpos;

        /// config_http
        public config_http http;

        /// config_device_group
        public config_device_group device_group;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
    public struct CONF_TEMP
    {

        /// char
        public byte enableLiveImage;

        /// char[124]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 124)]
        public string resv;

        /// char[128]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 128)]
        public string authKey;

        /// char[256]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 256)]
        public string authValue;

        /// int
        public int authResult;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
    public struct RPlate
    {

        /// char[16]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 16)]
        public string plate;

        /// int
        public int plateColor;

        /// unsigned short
        public ushort plateX;

        /// unsigned short
        public ushort plateY;

        /// unsigned short
        public ushort plateW;

        /// unsigned short
        public ushort plateH;

        /// float
        public float platerealty;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct reco_extra_info
    {

        /// int
        public int lane;

        /// int
        public int diff;

        /// int
        public int number;

        /// RPlate
        public RPlate plate;

        /// unsigned short
        public ushort w;

        /// unsigned short
        public ushort h;

        /// unsigned int
        public uint len;

        /// char*
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)]
        public string imgdata;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
    public struct ServiceParam
    {

        /// unsigned short
        public ushort port;

        /// unsigned char
        public byte max_clients;

        /// unsigned char
        public byte heart_timeout;

        /// unsigned char[4]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 4)]
        public byte[] resv;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
    public struct CameraParam
    {

        /// char[128]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 128)]
        public byte[] stream_url;

        /// short
        public short stream_port;

        /// short
        public short control_port;

        /// char[192]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 192)]
        public byte[] video_osd;

        /// char
        public byte fps;

        public byte saturation;

        public byte brightness;

        /// char
        public byte enable_ae;

        /// short
        public short max_exposure;

        /// short
        public short max_gain;

        /// short
        public short contrast;

        /// char[178]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 178)]
        public byte[] resv;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct AppServicesParam
    {

        /// ServiceParam
        public ServiceParam config_service;

        /// ServiceParam
        public ServiceParam query_service;

        /// ServiceParam
        public ServiceParam log_service;

        /// ServiceParam
        public ServiceParam resv_service;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
    public struct DescriptionParam
    {

        /// char[32]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 32)]
        public byte[] addr_id;

        /// char[96]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 96)]
        public byte[] addr_name;

        /// char[32]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 32)]
        public byte[] device_id;

        /// char[64]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 64)]
        public byte[] resv;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
    public struct AppPrivateParam
    {

        /// char[512]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 512)]
        public byte[] resv;





    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
    public struct AppCommonParam
    {

        /// AppServicesParam
        public AppServicesParam services;

        /// DescriptionParam
        public DescriptionParam description;

        /// char[256]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 256)]
        public byte[] resv;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct PlatformServicesParam
    {

        /// ServiceParam
        public ServiceParam config_service;

        /// ServiceParam
        public ServiceParam stream_service;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
    public struct TemporaryParam
    {

        /// char
        public byte enable_video;

        /// char[27]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 27)]
        public byte[] resv;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
    public struct PlatformParam
    {

        /// PlatformServicesParam
        public PlatformServicesParam services;

        /// CameraParam
        public CameraParam camera;

        /// char[112]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 112)]
        public byte[] resv;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
    public struct StreamParam
    {

        /// int
        public int video_format;

        /// char[60]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 60)]
        public byte[] resv;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct AppParam
    {

        /// AppCommonParam
        public AppCommonParam common;

        /// AppPrivateParam
        public AppPrivateParam priv;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
    public struct FtpClientParam
    {

        /// char[16]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 16)]
        public byte[] ip;

        /// int
        public int port;

        /// char[10]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 10)]
        public byte[] user;

        /// char[10]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 10)]
        public byte[] password;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
    public struct TcpClientParam
    {

        /// char[16]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 16)]
        public byte[] ip;

        /// int
        public int port;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
    public struct HttpClientParam
    {

        /// char[40]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 40)]
        public byte[] url;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Explicit)]
    public struct Anonymous_c922597f_4bac_4040_a652_e671cc18f637
    {

        /// FtpClientParam
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public FtpClientParam ftp;

        /// TcpClientParam
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public TcpClientParam tcp;

        /// HttpClientParam
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public HttpClientParam http;
    }

    /*[System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
    public struct ClientParam
    {

        /// char 0 未初始化。 1 TCP协议上传。 2 FTP协议上传。 3 HTTP协议上传。
        public byte mode;

        /// char[3]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 3)]
        public string resv;

        /// Anonymous_c922597f_4bac_4040_a652_e671cc18f637
        public Anonymous_c922597f_4bac_4040_a652_e671cc18f637 Union1;
    }*/

    /*[System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
    public struct UploaderParam
    {

        /// char[4]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 4)]
        public string resv;

        /// ClientParam
        public ClientParam client;
    }*/

    /*[System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
    public struct OutputerParam
    {

        /// UploaderParam
        public UploaderParam uploader;

        /// char[80]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 80)]
        public string resv;
    }*/

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct FaceSystemConfig
    {

        /// TemporaryParam
        public TemporaryParam temp;

        /// PlatformParam
        public PlatformParam platform;

        /// StreamParam
        public StreamParam stream;

        /// AppParam
        public AppParam app;

        /*/// OutputerParam
        public OutputerParam outputer;*/
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 128)]
        public byte[] resv;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct Point
    {

        /// int
        public int x;

        /// int
        public int y;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
    public struct FacePrivateParam
    {

        /// char
        public byte roi_border_num;

        /// char
        public byte enable_match;

        /// char
        public byte enable_debug;

        /// char
        public byte enable_dereplication;

        /// char
        public byte replication_timeout;

        /// char
        public byte replication_interval;

        /// char[2]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 2)]
        public byte[] resv1;

        /// ImageForm->Anonymous_7aca3c83_72c5_4283_b7a5_9c634b4243df
        public ImageForm output_form;

        /// float
        public float full_credit;

        /// short
        public short match_score;

        /// char
        public byte gpio_enable_white;

        /// char
        public byte gpio_enable_black;

        /// char
        public byte gpio_enable_resv;

        /// unsigned char
        public byte serial_send_flag;

        /// unsigned char[2]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 2)]
        public byte[] serial_databit;

        /// unsigned char[2]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 2)]
        public byte[] serial_parity;

        /// unsigned char[2]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 2)]
        public byte[] serial_stopbit;

        /// int[2]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = System.Runtime.InteropServices.UnmanagedType.I4)]
        public int[] serial_baudrate;

        /// unsigned char
        public byte light_mode;

        /// unsigned char
        public byte light_level;

        /// unsigned char
        public byte light_threshold;

        //unsigned char
        public byte audio_volume;

        //char audio_index;
        public byte audio_index;

        //char auto_score_enable;
        public byte auto_score_enable;

        //char gateway_control_type
        public byte gateway_control_type;

        //char alarm_index
        public byte alarm_index;

        //short alarm_duration
        public short alarm_duration;

        //char wiegand_type
        public byte wiegand_type;

        //char wiegand_dcode
        public byte wiegand_dcode;

        //int wiegand_public_cardid
        public int wiegand_public_cardid;

        //int wiegand_card_id_min
        public int wiegand_card_id_min;

        //int wiegand_card_id_max
        public int wiegand_card_id_max;

        //char work_mode;
        public byte work_mode;

        //char gpio_state;
        public byte gpio_state;

        //char cluster_enable
        public byte cluster_enable;

        //char max_pass_times;
        public byte max_pass_times;

        //int calc_times_interval;
        public int calc_times_interval;

        //char record_enable;
        public byte record_enable;

        //char record_resume_enable;
        public byte record_resume_enable;

        //  char face_alarm_enable
        public byte face_alarm_enable;

        //  char lcd_light_level;
        public byte lcd_light_level;

        //  int gpio_input_type
        public int gpio_input_type;

        //  char gpio_input_enable;
        public byte gpio_input_enable;

        // char filter_not_match;
        public byte filter_not_match;

        //  char must_wear_hat;
        public byte must_wear_hat;

        //  char audio_interval;
        public byte audio_interval;

        //  char ctrl_wiegand_io;
        public byte ctrl_wiegand_io;

        //  char no_twist_image;
        public byte no_twist_image;

        //  char multipleFaceMod;
        public byte multipleFaceMod;

        //  char namePrivacy;
        public byte namePrivacy;

        //  unsigned int expire_alarm; 
        public int expire_alarm;

        //  char allGpioOut;
        public byte allGpioOut;

        //  char record_path;
        public byte record_path;

        //  char qr_code_enable;
        public byte qr_code_enable;

        // unsigned char qr_code_interval;
        public byte qr_code_interval;

        //unsigned char serial_parse;
        public byte serial_parse;//50了

        //char resv_serial[1];
        public byte resv_serial;

        //  char temperature_unit;
        public byte temperature_unit;

        //  char heat_map_rorate; 
        public byte heat_map_rorate;

        //float temperature_limit; 
        public float temperature_limit;

        // char temLimit_enable; 
        public byte temLimit_enable;

        //  char must_wear_mask;
        public byte must_wear_mask;

        //char high_temp_multi_confirm;
        public byte high_temp_multi_confirm;

        //char id_card_register;
        public byte id_card_register;

        //  int enable_matchEx;
        public int enable_matchEx;

        //  unsigned char mache_mode;
        public byte mache_mode;

        //  unsigned char wiegand_input_id;
        public byte wiegand_input_id;

        //unsigned short intervaltime;
        public short intervaltime;

        //char resv_mface[16];
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 16)]
        public byte[] resv_mface;

        /// char[89] 以上扩展了其他字段
        //[System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 89)]
        //public byte[] resv2;

        /// Point[6]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = System.Runtime.InteropServices.UnmanagedType.Struct)]
        public Point[] roi;

        //short min_face_size;
        public short min_face_size;

        /// char[334]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 334)]
        public byte[] resv;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
    public struct pkg_vehicle
    {

        /// unsigned int
        public uint sequence_id;

        /// unsigned int
        public uint realtime_data;

        /// char[64]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 64)]
        public string packet_id;

        /// char[32]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 32)]
        public string device_id;

        /// char[32]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 32)]
        public string addr_id;

        /// char[32]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 32)]
        public string direction_id;

        /// char[32]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 32)]
        public string camera_id;

        /// char[32]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 32)]
        public string lane_id;

        /// char[96]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 96)]
        public string addr_name;

        /// char[96]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 96)]
        public string direction_name;

        /// char[16]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 16)]
        public string plate;

        /// unsigned short
        public ushort plate_x;

        /// unsigned short
        public ushort plate_y;

        /// unsigned short
        public ushort plate_w;

        /// unsigned short
        public ushort plate_h;

        /// int
        public int plate_confidence;

        /// unsigned char
        public byte plate_color;

        /// unsigned char
        public byte vehicle_style;

        /// unsigned char
        public byte vehicle_color;

        /// unsigned char
        public byte triger_type;

        /// int
        public int redlight_begin_sec;

        /// int
        public int redlight_begin_usec;

        /// unsigned int
        public uint system_type;

        /// unsigned int
        public uint vio_type;

        /// unsigned short
        public ushort vehicle_speed;

        /// unsigned short
        public ushort limit_speed;

        /// int
        public int recoImageIndex;

        /// unsigned short[4]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = System.Runtime.InteropServices.UnmanagedType.U2)]
        public ushort[] vehicle_x;

        /// unsigned short[4]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = System.Runtime.InteropServices.UnmanagedType.U2)]
        public ushort[] vehicle_y;

        /// unsigned short[4]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = System.Runtime.InteropServices.UnmanagedType.U2)]
        public ushort[] vehicle_w;

        /// unsigned short[4]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = System.Runtime.InteropServices.UnmanagedType.U2)]
        public ushort[] vehicle_h;

        /// unsigned short[4]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = System.Runtime.InteropServices.UnmanagedType.U2)]
        public ushort[] red_lamp_x;

        /// unsigned short[4]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = System.Runtime.InteropServices.UnmanagedType.U2)]
        public ushort[] red_lamp_y;

        /// unsigned short[4]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = System.Runtime.InteropServices.UnmanagedType.U2)]
        public ushort[] red_lamp_w;

        /// unsigned short[4]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = System.Runtime.InteropServices.UnmanagedType.U2)]
        public ushort[] red_lamp_h;

        /// unsigned short
        public ushort vio_red_lamp_index;

        /// unsigned short
        public ushort direction;

        /// char[56]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 56)]
        public string reserved;

        /// unsigned char
        public byte img_num;

        /// unsigned char
        public byte video_num;

        /// unsigned char
        public byte plate_img_num;

        /// unsigned char
        public byte face_num;

        /// unsigned int[4]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = System.Runtime.InteropServices.UnmanagedType.U4)]
        public uint[] img_len;

        /// unsigned int[2]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = System.Runtime.InteropServices.UnmanagedType.U4)]
        public uint[] video_len;

        /// unsigned int[2]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = System.Runtime.InteropServices.UnmanagedType.U4)]
        public uint[] plate_img_len;

        /// unsigned int[32]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = System.Runtime.InteropServices.UnmanagedType.U4)]
        public uint[] face_img_len;

        /// char[8]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 8)]
        public string img_format;

        /// char[8]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 8)]
        public string video_format;

        /// char[8]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 8)]
        public string plate_img_format;

        /// char[8]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 8)]
        public string face_img_format;

        /// int[4]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = System.Runtime.InteropServices.UnmanagedType.I4)]
        public int[] img_time_sec;

        /// int[4]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = System.Runtime.InteropServices.UnmanagedType.I4)]
        public int[] img_time_usec;

        /// int[2]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = System.Runtime.InteropServices.UnmanagedType.I4)]
        public int[] video_start_sec;

        /// int[2]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = System.Runtime.InteropServices.UnmanagedType.I4)]
        public int[] video_start_usec;

        /// int[2]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = System.Runtime.InteropServices.UnmanagedType.I4)]
        public int[] video_end_sec;

        /// int[2]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = System.Runtime.InteropServices.UnmanagedType.I4)]
        public int[] video_end_usec;

        /// unsigned short[32]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = System.Runtime.InteropServices.UnmanagedType.U2)]
        public ushort[] face_x;

        /// unsigned short[32]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = System.Runtime.InteropServices.UnmanagedType.U2)]
        public ushort[] face_y;

        /// unsigned short[32]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = System.Runtime.InteropServices.UnmanagedType.U2)]
        public ushort[] face_w;

        /// unsigned short[32]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = System.Runtime.InteropServices.UnmanagedType.U2)]
        public ushort[] face_h;

        /// unsigned char*[4]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = System.Runtime.InteropServices.UnmanagedType.SysUInt)]
        public System.IntPtr[] img;

        /// unsigned char*[2]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = System.Runtime.InteropServices.UnmanagedType.SysUInt)]
        public System.IntPtr[] video;

        /// unsigned char*[2]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = System.Runtime.InteropServices.UnmanagedType.SysUInt)]
        public System.IntPtr[] plate_img;

        /// unsigned char*[32]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = System.Runtime.InteropServices.UnmanagedType.SysUInt)]
        public System.IntPtr[] face_img;
    }

    public enum FORMAT_ID
    {

        /// FORMAT_ID_JPEG -> 1
        FORMAT_ID_JPEG = 1,

        /// FORMAT_ID_H264 -> 2
        FORMAT_ID_H264 = 2,

        /// FORMAT_ID_AVI -> 3
        FORMAT_ID_AVI = 3,

        /// FORMAT_ID_GRAY_8 -> 4
        FORMAT_ID_GRAY_8 = 4,
    }

    public partial class NativeMethods
    {

        /// Return Type: int
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "discover_client_init")]
        public static extern int discover_client_init();


        /// Return Type: void
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "discover_client_deinit")]
        public static extern void discover_client_deinit();


        /// Return Type: void
        ///cb: discover_ipscan_cb_t
        ///usr_param: int
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "discover_reg_ipscan_cb")]
        public static extern void discover_reg_ipscan_cb(discover_ipscan_cb_t cb, int usr_param);


        /// Return Type: void
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "discover_ipscan")]
        public static extern void discover_ipscan();


        /// Return Type: void
        ///ipscan: ipscan_t*
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "discover_print_ipscan")]
        public static extern void discover_print_ipscan(ref ipscan_t ipscan);


        /// Return Type: void
        ///mac: char*
        ///ip: char*
        ///netmask: char*
        ///gateway: char*
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "discover_setip_bymac")]
        public static extern void discover_setip_bymac([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string mac, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string ip, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string netmask, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string gateway);
        //public static extern void discover_setip_bymac([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPArray, SizeConst = 16)] byte[] mac, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPArray, SizeConst = 16)] byte[] ip, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPArray, SizeConst = 16)] byte[] netmask, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPArray, SizeConst = 16)] byte[] gateway);

        /// Return Type: int
        ///mode: int
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_SetFastFace", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_SetFastFace(int mode);

        /// Return Type: void
        ///cam: void*
        ///decodeFmt: int
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_SetStreamFmt", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern void HA_SetStreamFmt(System.IntPtr cam, int decodeFmt);

        /// Return Type: void
        ///cam: void*
        ///hWnd: void*
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_StopStreamEx", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern void HA_StopStreamEx(System.IntPtr cam, System.IntPtr hWnd);

        /// Return Type: int
        ///cam: void*
        ///type: int*
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_GetGatewayControlType", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_GetGatewayControlType(System.IntPtr cam, ref int type);


        /// Return Type: int
        ///cam: void*
        ///type: int
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_SetGatewayControlType", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_SetGatewayControlType(System.IntPtr cam, int type);


        /// Return Type: int
        ///cam: void*
        ///IoNum: int*
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_GetAlarmIoNum", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_GetAlarmIoNum(System.IntPtr cam, ref int IoNum);


        /// Return Type: int
        ///cam: void*
        ///IoNum: int
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_SetAlarmIoNum", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_SetAlarmIoNum(System.IntPtr cam, int IoNum);


        /// Return Type: int
        ///cam: void*
        ///duration: int*
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_GetAlarmDuration", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_GetAlarmDuration(System.IntPtr cam, ref int duration);


        /// Return Type: int
        ///cam: void*
        ///duration: int
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_SetAlarmDuration", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_SetAlarmDuration(System.IntPtr cam, int duration);


        /// Return Type: int
        ///cam: void*
        ///type: int*
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_GetWiegandType", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_GetWiegandType(System.IntPtr cam, ref int type);


        /// Return Type: int
        ///cam: void*
        ///type: int
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_SetWiegandType", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_SetWiegandType(System.IntPtr cam, int type);


        /// Return Type: int
        ///cam: void*
        ///dcode: int*
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_GetWiegandDcode", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_GetWiegandDcode(System.IntPtr cam, ref int dcode);


        /// Return Type: int
        ///cam: void*
        ///dcode: int
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_SetWiegandDcode", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_SetWiegandDcode(System.IntPtr cam, int dcode);


        /// Return Type: int
        ///cam: void*
        ///cardNo: unsigned int*
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_GetWiegandPublicCardNO", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_GetWiegandPublicCardNO(System.IntPtr cam, ref uint cardNo);


        /// Return Type: int
        ///cam: void*
        ///cardNo: unsigned int
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_SetWiegandPublicCardNO", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_SetWiegandPublicCardNO(System.IntPtr cam, uint cardNo);


        /// Return Type: int
        ///cam: void*
        ///cardNoMin: unsigned int*
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_GetWiegandAutoCardNoMin", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_GetWiegandAutoCardNoMin(System.IntPtr cam, ref uint cardNoMin);


        /// Return Type: int
        ///cam: void*
        ///cardNoMin: unsigned int
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_SetWiegandAutoCardNoMin", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_SetWiegandAutoCardNoMin(System.IntPtr cam, uint cardNoMin);


        /// Return Type: int
        ///cam: void*
        ///cardNoMax: unsigned int*
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_GetWiegandAutoCardNoMax", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_GetWiegandAutoCardNoMax(System.IntPtr cam, ref uint cardNoMax);


        /// Return Type: int
        ///cam: void*
        ///cardNoMax: unsigned int
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_SetWiegandAutoCardNoMax", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_SetWiegandAutoCardNoMax(System.IntPtr cam, uint cardNoMax);


        /// Return Type: int
        ///cam: void*
        ///size: unsigned int*
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_GetFaceDetectMinRect", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_GetFaceDetectMinRect(System.IntPtr cam, ref uint size);


        /// Return Type: int
        ///cam: void*
        ///size: unsigned int
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_SetFaceDetectMinRect", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_SetFaceDetectMinRect(System.IntPtr cam, uint size);

        /// Return Type: int
        ///cam: void*
        ///brightness: unsigned char*
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_GetBrightness", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_GetBrightness(System.IntPtr cam, System.IntPtr brightness);


        /// Return Type: int
        ///cam: void*
        ///brightness: unsigned char
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_SetBrightness", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_SetBrightness(System.IntPtr cam, byte brightness);


        /// Return Type: int
        ///cam: void*
        ///saturation: unsigned char*
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_GetSaturation", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_GetSaturation(System.IntPtr cam, System.IntPtr saturation);
        
        /// Return Type: int
        ///cam: void*
        ///saturation: unsigned char
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_SetSaturation", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_SetSaturation(System.IntPtr cam, byte saturation);
        
        /// Return Type: int
        ///cam: void*
        ///enable: int*
        ///ip: char*
        ///port: int*
        ///resv: char*
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_GetServerSdkParam", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_GetServerSdkParam(System.IntPtr cam, ref int enable, System.IntPtr ip, ref int port, System.IntPtr resv);
        
        /// Return Type: int
        ///cam: void*
        ///enable: int
        ///ip: char*
        ///port: int
        ///resv: char*
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_SetServerSdkParam", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_SetServerSdkParam(System.IntPtr cam, int enable, System.IntPtr ip, int port, System.IntPtr resv);

    }

    public partial class NativeMethods
    {

        public static int HA_GetVersion() { return 3; }


        /// Return Type: void
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_Init", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern void HA_Init();


        /// Return Type: void
        ///maxCamNum: unsigned int
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_InitEx", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern void HA_InitEx(uint maxCamNum);


        /// Return Type: int
        ///faceModel: char*
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_InitFaceModel", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_InitFaceModel([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string faceModel);


        /// Return Type: void
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_DeInit", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern void HA_DeInit();

    }

    public partial class NativeMethods
    {

        /// Return Type: void
        ///cb: HA_ConnectEventCb_t
        ///usrParam: int
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_RegConnectEventCb", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern void HA_RegConnectEventCb(HA_ConnectEventCb_t cb, int usrParam);


        /// Return Type: void
        ///cam: HA_Cam*
        ///cb: HA_ConnectEventCb_t
        ///usrParam: int
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_RegConnectEventCbEx", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern void HA_RegConnectEventCbEx(IntPtr cam, HA_ConnectEventCb_t cb, int usrParam);


        /// Return Type: void
        ///cb: HA_LiveStreamCb_t
        ///usrParam: int
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_RegLiveStreamCb", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern void HA_RegLiveStreamCb(HA_LiveStreamCb_t cb, int usrParam);


        /// Return Type: void
        ///cam: HA_Cam*
        ///cb: HA_LiveStreamCb_t
        ///usrParam: int
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_RegLiveStreamCbEx", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern void HA_RegLiveStreamCbEx(IntPtr cam, HA_LiveStreamCb_t cb, int usrParam);


        /// Return Type: void
        ///cb: HA_DataReadCb_t
        ///usrParam: int
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_RegDataReadCb", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern void HA_RegDataReadCb(HA_DataReadCb_t cb, int usrParam);


        /// Return Type: void
        ///cam: HA_Cam*
        ///cb: HA_DataReadCb_t
        ///usrParam: int
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_RegDataReadCbEx", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern void HA_RegDataReadCbEx(IntPtr cam, HA_DataReadCb_t cb, int usrParam);


        /// Return Type: void
        ///cam: HA_Cam*
        ///cb: HA_FaceRecoCb_t
        ///usrParam: void*
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_RegFaceRecoCb", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern void HA_RegFaceRecoCb(IntPtr cam, HA_FaceRecoCb_t cb, System.IntPtr usrParam);
        /// <summary>
        /// 注册Gpio
        /// </summary>
        /// <param name="cam"></param>
        /// <param name="cb"></param>
        /// <param name="usrParam"></param>
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_RegGpioInputCb", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern void HA_RegGpioInputCb(IntPtr cam, HA_GpioInputCb_t cb, System.IntPtr usrParam);
        /// <summary>
        /// 注册二维码回调
        /// </summary>
        /// <param name="cam"></param>
        /// <param name="cb"></param>
        /// <param name="usrParam"></param>
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_RegQRCodeCb", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern void HA_RegQRCodeCb(IntPtr cam, HA_QRCodeCb_t cb, System.IntPtr usrParam);


        /// Return Type: void
        ///cb: discover_ipscan_cb_t
        ///usrParam: int
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_RegDiscoverIpscanCb", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern void HA_RegDiscoverIpscanCb(discover_ipscan_cb_t cb, int usrParam);


        /// Return Type: void
        ///cam: HA_Cam*
        ///cb: HA_OfflineFeeData_t
        ///usrParam: int
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_RegOfflineDataCb", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern void HA_RegOfflineDataCb(IntPtr cam, HA_OfflineFeeData_t cb, int usrParam);


        /// Return Type: void
        ///cam: HA_Cam*
        ///cb: HA_OfflineQueriedEntryInfoCb_t
        ///usrParam: int
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_RegQueryEntryPlateInfoCb", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern void HA_RegQueryEntryPlateInfoCb(IntPtr cam, HA_OfflineQueriedEntryInfoCb_t cb, int usrParam);


        /// Return Type: void
        ///cam: HA_Cam*
        ///plate: char*
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_QueryOfflineEntryTimeByPlate", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern void HA_QueryOfflineEntryTimeByPlate(IntPtr cam, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string plate);


        /// Return Type: int
        ///cam: HA_Cam*
        ///pStartTime: char*
        ///pEndTime: char*
        ///queryStyle: int
        ///pPlateOrVehicleType: void*
        ///pCount: int*
        ///pMoneyTotal: float*
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_QueryOfflineFeeDataCountAndMoney", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_QueryOfflineFeeDataCountAndMoney(IntPtr cam, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string pStartTime, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string pEndTime, int queryStyle, System.IntPtr pPlateOrVehicleType, ref int pCount, ref float pMoneyTotal);


        /// Return Type: int
        ///cam: HA_Cam*
        ///pStartTime: char*
        ///pEndTime: char*
        ///queryStyle: int
        ///pPlateOrVehicleType: void*
        ///startPos: int
        ///endPos: int
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_QueryOfflineFeeDataByPage", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_QueryOfflineFeeDataByPage(IntPtr cam, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string pStartTime, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string pEndTime, int queryStyle, System.IntPtr pPlateOrVehicleType, int startPos, int endPos);


        /// Return Type: int
        ///cam: HA_Cam*
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_ClearOfflneFeeData", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_ClearOfflneFeeData(IntPtr cam);


        /// Return Type: void
        ///cam: HA_Cam*
        ///cb: HA_OfflineFeeDataQueriedByPageCb_t
        ///usrParam: int
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_RegQueryOfflineFeeDataByPageCb", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern void HA_RegQueryOfflineFeeDataByPageCb(IntPtr cam, HA_OfflineFeeDataQueriedByPageCb_t cb, int usrParam);


        /// Return Type: void
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_DiscoverIpscan", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern void HA_DiscoverIpscan();


        /// Return Type: void
        ///mac: char*
        ///ip: char*
        ///netmask: char*
        ///gateway: char*
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_SetIpBymac", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern void HA_SetIpBymac([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string mac, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string ip, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string netmask, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string gateway);


        /// Return Type: void
        ///camType: CAM_TYPE
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_SetCamType", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern void HA_SetCamType(CAM_TYPE camType);


        /// Return Type: void
        ///charEncode: CHAR_ENCODE
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_SetCharEncode", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern void HA_SetCharEncode(CHAR_ENCODE charEncode);


        /// Return Type: int
        ///cam: HA_Cam*
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_Connected", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        [return: System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.I1)]
        public static extern bool HA_Connected(IntPtr cam);


        /// Return Type: HA_Cam*
        ///ip: char*
        ///port: unsigned short
        ///usrName: char*
        ///password: char*
        ///errorNum: int*
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_Connect", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern System.IntPtr HA_Connect([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string ip, ushort port, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string usrName, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string password, ref int errorNum);


        /// Return Type: HA_Cam*
        ///ip: char*
        ///port: unsigned short
        ///usrName: char*
        ///password: char*
        ///errorNum: int*
        ///channel: unsigned int
        ///autoReconn: int
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_ConnectEx", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern System.IntPtr HA_ConnectEx([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string ip, ushort port, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string usrName, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string password, ref int errorNum, uint channel, [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.Bool)] bool autoReconn);


        /**
 * @brief   连接相机到服务器 
 * @param   ip[in]   服务器ip
 * @param   port[in]   服务器端口
 * @param   usrName[in]   保留
 * @param   password[in]  保留
 * @param   errorNum[out]  连接失败错误号，0为连接成功，-1为连接失败
 * @return  NULL 连接失败
 * @return  非NULL 连接成功  
 */
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_ConnectRelayServer", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern System.IntPtr HA_ConnectRelayServer([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string ip, ushort port, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string usrName, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string password, ref int errorNum);


        /// Return Type: int
        ///cam: HA_Cam*
        ///usrNameOld: char*
        ///passwordOld: char*
        ///usrNameNew: char*
        ///passwordNew: char*
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_ModifyUserNamePasswd", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_ModifyUserNamePasswd(IntPtr cam, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string usrNameOld, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string passwordOld, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string usrNameNew, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string passwordNew);


        /// Return Type: void
        ///cam: HA_Cam*
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_DisConnect", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern void HA_DisConnect(IntPtr cam);


        /// Return Type: void
        ///cam: HA_Cam*
        ///hWnd: HWND->HWND__*
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_StartStream", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern void HA_StartStream(IntPtr cam, System.IntPtr hWnd);


        /// Return Type: void
        ///cam: HA_Cam*
        ///hWnd: HWND->HWND__*
        ///cb: HA_DecodeImageCb_t
        ///usrParam: int
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_StartStreamEx", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern void HA_StartStreamEx(IntPtr cam, System.IntPtr hWnd, HA_DecodeImageCb_t cb, int usrParam);


        /// Return Type: void
        ///cam: HA_Cam*
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_StopStream", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern void HA_StopStream(IntPtr cam);


        /// Return Type: int
        ///cam: HA_Cam*
        ///fileName: char*
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_CapImgToFile", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_CapImgToFile(IntPtr cam, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string fileName);


        /// Return Type: int
        ///cam: HA_Cam*
        ///buffer: unsigned char*
        ///bufferSize: int
        ///len: int*
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_CapImgToBuffer", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_CapImgToBuffer(IntPtr cam, System.IntPtr buffer, int bufferSize, ref int len);


        /// Return Type: int
        ///cam: HA_Cam*
        ///usrParam: int
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_Trigger", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_Trigger(IntPtr cam, int usrParam);


        /// Return Type: int
        ///cam: HA_Cam*
        ///allowList: HA_AllowList*
        ///listNum: int
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_SetWhiteList", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_SetWhiteList(IntPtr cam, ref HA_AllowList allowList, int listNum);


        /// Return Type: int
        ///cam: HA_Cam*
        ///allowList: HA_AllowList*
        ///maxNum: int
        ///listNum: int*
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_GetWhiteList", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_GetWhiteList(IntPtr cam, ref HA_AllowList allowList, int maxNum, ref int listNum);


        /// Return Type: int
        ///cam: HA_Cam*
        ///pageNum: int
        ///recordNumPerPage: int
        ///allowList: HA_AllowList*
        ///listNum: int*
        ///totalPages: int*
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_GetWhiteListByPage", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_GetWhiteListByPage(IntPtr cam, int pageNum, int recordNumPerPage, ref HA_AllowList allowList, ref int listNum, ref int totalPages);


        /// Return Type: int
        ///cam: HA_Cam*
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_ClearWhiteList", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_ClearWhiteList(IntPtr cam);


        /// Return Type: int
        ///cam: HA_Cam*
        ///wList: HA_AllowList*
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_InsertWhiteList", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_InsertWhiteList(IntPtr cam, ref HA_AllowList wList);


        /// Return Type: int
        ///cam: HA_Cam*
        ///wList: HA_AllowList*
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_UpdateWhiteListByPlate", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_UpdateWhiteListByPlate(IntPtr cam, ref HA_AllowList wList);


        /// Return Type: int
        ///cam: HA_Cam*
        ///plate: char*
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_DeleteWhiteListByPlate", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_DeleteWhiteListByPlate(IntPtr cam, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string plate);


        /// Return Type: int
        ///cam: HA_Cam*
        ///plate: char*
        ///wList: HA_AllowList*
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_SearchWhiteListByPlate", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_SearchWhiteListByPlate(IntPtr cam, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string plate, ref HA_AllowList wList);


        /// Return Type: int
        ///cam: HA_Cam*
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_GetWhiteListCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_GetWhiteListCount(IntPtr cam);


        /// Return Type: int
        ///cam: HA_Cam*
        ///version: VERSION*
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_GetSystemVersion", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_GetSystemVersion(IntPtr cam, ref VERSION version);


        /// Return Type: int
        ///cam: HA_Cam*
        ///version: VERSION*
        ///usrName: char*
        ///password: char*
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_GetSystemVersionEX", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_GetSystemVersionEX(IntPtr cam, ref VERSION version, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string usrName, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string password);


        /// Return Type: int
        ///cam: HA_Cam*
        ///cfg: config_gateway*
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_GetGatewayConfig", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_GetGatewayConfig(IntPtr cam, ref config_gateway cfg);


        /// Return Type: int
        ///cam: HA_Cam*
        ///cfg: FaceSystemConfig*
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_GetFaceSystemCfg", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_GetFaceSystemCfg(IntPtr cam, ref FaceSystemConfig cfg);


        /// Return Type: int
        ///cam: HA_Cam*
        ///cfg: config_gateway*
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_SetGatewayConfig", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_SetGatewayConfig(IntPtr cam, ref config_gateway cfg);


        /// Return Type: int
        ///cam: HA_Cam*
        ///cfg: FaceSystemConfig*
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_SetFaceSystemCfg", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_SetFaceSystemCfg(IntPtr cam, ref FaceSystemConfig cfg);


        /// Return Type: int
        ///cam: HA_Cam*
        ///score: int*
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_GetMatchScore", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_GetMatchScore(IntPtr cam, ref int score);


        /// Return Type: int
        ///cam: HA_Cam*
        ///score: int
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_SetMatchScore", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_SetMatchScore(IntPtr cam, int score);


        /// Return Type: int
        ///cam: HA_Cam*
        ///delay: int*
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_GetOutputDelay", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_GetOutputDelay(IntPtr cam, ref int delay);


        /// Return Type: int
        ///cam: HA_Cam*
        ///delay: int
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_SetOutputDelay", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_SetOutputDelay(IntPtr cam, int delay);


        /// Return Type: int
        ///cam: HA_Cam*
        ///ctl: int*
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_GetOutputCtl", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_GetOutputCtl(IntPtr cam, ref int ctl);


        /// Return Type: int
        ///cam: HA_Cam*
        ///ctl: int
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_SetOutputCtl", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_SetOutputCtl(IntPtr cam, int ctl);


        /// Return Type: int
        ///cam: HA_Cam*
        ///level: int*
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_GetMatchLevel", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_GetMatchLevel(IntPtr cam, ref int level);


        /// Return Type: int
        ///cam: HA_Cam*
        ///level: int
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_SetMatchLevel", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_SetMatchLevel(IntPtr cam, int level);


        /// Return Type: int
        ///cam: HA_Cam*
        ///enable: int*
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_GetMatchEnable", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_GetMatchEnable(IntPtr cam, [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.Bool)] ref bool enable);


        /// Return Type: int
        ///cam: HA_Cam*
        ///enable: int
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_SetMatchEnable", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_SetMatchEnable(IntPtr cam, [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.Bool)] bool enable);


        /// Return Type: int
        ///cam: HA_Cam*
        ///enable: int*
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_GetDebugEnable", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_GetDebugEnable(IntPtr cam, [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.Bool)] ref bool enable);


        /// Return Type: int
        ///cam: HA_Cam*
        ///enable: int
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_SetDebugEnable", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_SetDebugEnable(IntPtr cam, [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.Bool)] bool enable);


        /// Return Type: int
        ///cam: HA_Cam*
        ///offlineFlag: int*
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_GetGatewayOfflineMode", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_GetGatewayOfflineMode(IntPtr cam, ref int offlineFlag);


        /// Return Type: int
        ///cam: HA_Cam*
        ///offlineFlag: int
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_SetGatewayOfflineMode", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_SetGatewayOfflineMode(IntPtr cam, int offlineFlag);


        /// Return Type: int
        ///cam: HA_Cam*
        ///cb: HA_PlateInfoCb_t
        ///usrParam: int
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_SetOfflinePlateInfoCb", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_SetOfflinePlateInfoCb(IntPtr cam, HA_PlateInfoCb_t cb, int usrParam);


        /// Return Type: int
        ///cam: HA_Cam*
        ///transFlag: int
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_SetTransfferOffline", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_SetTransfferOffline(IntPtr cam, int transFlag);


        /// Return Type: int
        ///cam: HA_Cam*
        ///transFlag: int*
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_GetTransfferOffline", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_GetTransfferOffline(IntPtr cam, ref int transFlag);


        /// Return Type: int
        ///cam: HA_Cam*
        ///index: int
        ///state: int
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_SetIOOutput", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_SetIOOutput(IntPtr cam, int index, int state);


        /// Return Type: int
        ///cam: HA_Cam*
        ///index: int
        ///timeDuration: int
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_SetIOOutputAuto", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_SetIOOutputAuto(IntPtr cam, int index, int timeDuration);


        /// Return Type: int
        ///cam: HA_Cam*
        ///open: int
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_SetAlarm", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_SetAlarm(IntPtr cam, int open);


        /// Return Type: int
        ///cam: HA_Cam*
        ///index: int
        ///state: int
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_SetIOState", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_SetIOState(IntPtr cam, int index, int state);


        /// Return Type: int
        ///cam: HA_Cam*
        ///index: int
        ///timeDuration: int
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_SetAlarmAuto", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_SetAlarmAuto(IntPtr cam, int index, int timeDuration);


        /// Return Type: int
        ///cam: HA_Cam*
        ///inout: int
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_WhiteListAlarm", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_WhiteListAlarm(IntPtr cam, int inout, int onoff);


        /// Return Type: int
        ///cam: HA_Cam*
        ///inout: int
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_BlackListAlarm", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_BlackListAlarm(IntPtr cam, int inout, int onoff);


        /// Return Type: int
        ///cam: HA_Cam*
        ///port: int
        ///inout: int
        ///resv: char*
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_SetGPIO", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_SetGPIO(IntPtr cam, int port, int inout, int onoff, System.IntPtr resv);


        /// Return Type: int
        ///cam: HA_Cam*
        ///audio: char*
        ///len: int
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_PlayAudio", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_PlayAudio(IntPtr cam, [System.Runtime.InteropServices.InAttribute()] byte[] audio, int len);


        /// Return Type: int
        ///cb: HA_ReadTSerialCb_t
        ///usrParam: int
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_RegReadTSerialCb", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_RegReadTSerialCb(HA_ReadTSerialCb_t cb, int usrParam);


        /// Return Type: int
        ///cam: HA_Cam*
        ///cb: HA_ReadTSerialCb_t
        ///usrParam: int
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_RegReadTSerialCbEx", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_RegReadTSerialCbEx(IntPtr cam, HA_ReadTSerialCb_t cb, int usrParam);


        /// Return Type: int
        ///cam: HA_Cam*
        ///cb: HA_ReadGpioCb_t
        ///usrParam: int
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_RegReadGpioCbEx", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_RegReadGpioCbEx(IntPtr cam, HA_ReadGpioCb_t cb, int usrParam);


        /// Return Type: int
        ///cam: HA_Cam*
        ///index: int
        ///baudrate: int*
        ///parity: int*
        ///databit: int*
        ///stopbit: int*
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_GetTSerial", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_GetTSerial(IntPtr cam, int index, ref int baudrate, ref int parity, ref int databit, ref int stopbit);


        /// Return Type: int
        ///cam: HA_Cam*
        ///index: int
        ///baudrate: int
        ///parity: int
        ///databit: int
        ///stopbit: int
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_OpenTSerial", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_OpenTSerial(IntPtr cam, int index, int baudrate, int parity, int databit, int stopbit);


        /// Return Type: int
        ///cam: HA_Cam*
        ///index: int
        ///data: char*
        ///size: int
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_WriteTSerial", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_WriteTSerial(IntPtr cam, int index, IntPtr data, int size);


        /// Return Type: int
        ///cam: HA_Cam*
        ///index: int
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_CloseTSerial", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_CloseTSerial(IntPtr cam, int index);


        /// Return Type: int
        ///cam: HA_Cam*
        ///ctrl: CamCtrl*
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_GetCamParam", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_GetCamParam(IntPtr cam, ref CamCtrl ctrl);


        /// Return Type: void
        ///cam: HA_Cam*
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_RebootCam", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern void HA_RebootCam(IntPtr cam);


        /// Return Type: void
        ///cam: HA_Cam*
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_SaveCamParam", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern void HA_SaveCamParam(IntPtr cam);


        /// Return Type: void
        ///cam: HA_Cam*
        ///ctrl: CamCtrlAutoCtrl*
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_SetAutoCtrl", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern void HA_SetAutoCtrl(IntPtr cam, ref CamCtrlAutoCtrl ctrl);


        /// Return Type: void
        ///cam: HA_Cam*
        ///en: CamCtrlImageEnhance*
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_SetImageEnhance", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern void HA_SetImageEnhance(IntPtr cam, ref CamCtrlImageEnhance en);


        /// Return Type: void
        ///cam: HA_Cam*
        ///time: int
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_SetSysTime", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern void HA_SetSysTime(IntPtr cam, int time);


        /// Return Type: int
        ///cam: HA_Cam*
        ///time: int*
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_GetSysTime", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_GetSysTime(IntPtr cam, ref int time);


        /// Return Type: int
        ///cam: HA_Cam*
        ///year: int
        ///month: int
        ///day: int
        ///hour: int
        ///minute: int
        ///second: int
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_SetSysTimeEx", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_SetSysTimeEx(IntPtr cam, int year, int month, int day, int hour, int minute, int second);


        /// Return Type: int
        ///cam: HA_Cam*
        ///year: int*
        ///month: int*
        ///day: int*
        ///hour: int*
        ///minute: int*
        ///second: int*
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_GetSysTimeEx", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_GetSysTimeEx(IntPtr cam, ref int year, ref int month, ref int day, ref int hour, ref int minute, ref int second);


        /// Return Type: void
        ///cam: HA_Cam*
        ///q: int
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_SetJpegQ", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern void HA_SetJpegQ(IntPtr cam, int q);


        /// Return Type: void
        ///cam: HA_Cam*
        ///w: int
        ///h: int
        ///bitrate: int
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_SetH264", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern void HA_SetH264(IntPtr cam, int w, int h, int bitrate);


        /// Return Type: int
        ///cam: HA_Cam*
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_ZoomUpStart", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_ZoomUpStart(IntPtr cam);


        /// Return Type: int
        ///cam: HA_Cam*
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_ZoomUpStop", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_ZoomUpStop(IntPtr cam);


        /// Return Type: int
        ///cam: HA_Cam*
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_ZoomDownStart", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_ZoomDownStart(IntPtr cam);


        /// Return Type: int
        ///cam: HA_Cam*
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_ZoomDownStop", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_ZoomDownStop(IntPtr cam);


        /// Return Type: int
        ///cam: HA_Cam*
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_FocusUpStart", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_FocusUpStart(IntPtr cam);


        /// Return Type: int
        ///cam: HA_Cam*
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_FocusUpStop", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_FocusUpStop(IntPtr cam);


        /// Return Type: int
        ///cam: HA_Cam*
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_FocusDownStart", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_FocusDownStart(IntPtr cam);


        /// Return Type: int
        ///cam: HA_Cam*
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_FocusDownStop", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_FocusDownStop(IntPtr cam);


        /// Return Type: int
        ///cam: HA_Cam*
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_ZoomUp", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_ZoomUp(IntPtr cam);


        /// Return Type: int
        ///cam: HA_Cam*
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_ZoomDown", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_ZoomDown(IntPtr cam);


        /// Return Type: int
        ///cam: HA_Cam*
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_FocusUp", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_FocusUp(IntPtr cam);


        /// Return Type: int
        ///cam: HA_Cam*
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_FocusDown", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_FocusDown(IntPtr cam);

        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_LiveStreamCtl", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_LiveStreamCtl(IntPtr cam, int flag);

        /// Return Type: int
        ///cam: HA_Cam*
        ///sn: char*
        ///SNSize: int*
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_GetCustomerSN", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_GetCustomerSN(IntPtr cam, System.IntPtr sn, ref int SNSize);


        /// Return Type: int
        ///cam: HA_Cam*
        ///auth: char*
        ///size: int
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_WriteCustomerAuthCode", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_WriteCustomerAuthCode(IntPtr cam, byte[] auth, int size);


        /// Return Type: int
        ///cam: HA_Cam*
        ///auth: char*
        ///size: int*
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_ReadCustomerAuthCode", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_ReadCustomerAuthCode(IntPtr cam, [Out] byte[] auth, ref int size);


        /// Return Type: int
        ///pRgbBuffer: char*
        ///dwWidth: unsigned int
        ///dwHeight: unsigned int
        ///pJpgBuffer: unsigned char*
        ///dwJpgSize: unsigned int*
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_EncodeJpeg", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_EncodeJpeg([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string pRgbBuffer, uint dwWidth, uint dwHeight, System.IntPtr pJpgBuffer, ref uint dwJpgSize);


        /// Return Type: int
        ///srcJpg: char*
        ///srcJpgLen: int
        ///desRgb: unsigned char*
        ///jpgW: unsigned int*
        ///jpgH: unsigned int*
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_DecodeJpeg", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_DecodeJpeg([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string srcJpg, int srcJpgLen, System.IntPtr desRgb, ref uint jpgW, ref uint jpgH);


        /// Return Type: int
        ///cam: HA_Cam*
        ///sFileName: char*
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_SaveRealDate", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_SaveRealDate(IntPtr cam, System.IntPtr sFileName);


        /// Return Type: int
        ///cam: HA_Cam*
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_StopSaveRealDate", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_StopSaveRealDate(IntPtr cam);


        /// Return Type: int
        ///cam: HA_Cam*
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_BackupUserDefault", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_BackupUserDefault(IntPtr cam);


        /// Return Type: int
        ///cam: HA_Cam*
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_RestoreUserDefault", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_RestoreUserDefault(IntPtr cam);


        /// Return Type: int
        ///cam: HA_Cam*
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_RestorMannuFDefalut", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_RestorMannuFDefalut(IntPtr cam);


        /// Return Type: int
        ///cam: HA_Cam*
        ///hasSDCard: int*
        ///totalSize: int*
        ///usedSize: int*
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_QuerySDCardInfo", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_QuerySDCardInfo(IntPtr cam, ref int hasSDCard, ref int totalSize, ref int usedSize);


        /// Return Type: int
        ///cam: HA_Cam*
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_FormatSDCard", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_FormatSDCard(IntPtr cam);


       


        /// Return Type: int
        ///cam: HA_Cam*
        ///audioId: int
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_TestAudioItem", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_TestAudioItem(IntPtr cam, int audioId);


        /// Return Type: int
        ///inbuf: char*
        ///inlen: int
        ///outbuf: char*
        ///outlen: int
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_Gb23122Utf8", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_Gb23122Utf8(System.IntPtr inbuf, int inlen, System.IntPtr outbuf, int outlen);


        /// Return Type: int
        ///inbuf: char*
        ///inlen: int
        ///outbuf: char*
        ///outlen: int
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_Utf82Gb2312", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_Utf82Gb2312(System.IntPtr inbuf, int inlen, System.IntPtr outbuf, int outlen);


        /// Return Type: int
        ///cam: HA_Cam*
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_ClearAllCallbacks", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_ClearAllCallbacks(IntPtr cam);


        /// Return Type: int
        ///cam: HA_Cam*
        ///cb: HA_PlateInfoCb_t
        ///usrParam: int
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_SetQueryPlateInfoCb", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_SetQueryPlateInfoCb(IntPtr cam, HA_PlateInfoCb_t cb, int usrParam);


        /// Return Type: int
        ///cam: HA_Cam*
        ///pStartTime: char*
        ///pEndTime: char*
        ///keyword: char*
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_QueryCountByTimeAndPlate", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_QueryCountByTimeAndPlate(IntPtr cam, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string pStartTime, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string pEndTime, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string keyword);

        /// Return Type: int
        ///cam: void*
        ///ptzCtl: int
        ///ctlMode: int
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_FocusAndZoomCtl", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_FocusAndZoomCtl(System.IntPtr cam, int ptzCtl, int ctlMode);

        /// Return Type: int
        ///srcJpg: char*
        ///srcJpgLen: int
        ///jpgW: unsigned int*
        ///jpgH: unsigned int*
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_DecodeJpgSize", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_DecodeJpgSize(IntPtr srcJpg, int srcJpgLen, ref uint jpgW, ref uint jpgH);
    }

    public partial class NativeMethods
    {
        /// Return Type: int
        ///cam: HA_Cam*
        ///pStartTime: char*
        ///pEndTime: char*
        ///keyword: char*
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_QueryRecordByTimeAndPlate", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_QueryRecordByTimeAndPlate(IntPtr cam, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string pStartTime, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string pEndTime, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string keyword);


        /// Return Type: int
        ///cam: HA_Cam*
        ///pStartTime: char*
        ///pEndTime: char*
        ///keyword: char*
        ///start: int
        ///end: int
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_QueryPageRecordByTimeAndPlate", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_QueryPageRecordByTimeAndPlate(IntPtr cam, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string pStartTime, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string pEndTime, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string keyword, int start, int end);


        /// Return Type: int
        ///cam: HA_Cam*
        ///pStartTime: char*
        ///pEndTime: char*
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_QueryOfflineCountByTime", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_QueryOfflineCountByTime(IntPtr cam, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string pStartTime, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string pEndTime);


        /// Return Type: int
        ///cam: HA_Cam*
        ///pStartTime: char*
        ///pEndTime: char*
        ///start: int
        ///end: int
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_QueryPageOfflineRecordByTime", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_QueryPageOfflineRecordByTime(IntPtr cam, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string pStartTime, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string pEndTime, int start, int end);


        /// Return Type: int
        ///cam: HA_Cam*
        ///id: int
        ///img: unsigned char*
        ///imgLen: int*
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_QueryRecordById", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_QueryRecordById(IntPtr cam, int id, System.IntPtr img, ref int imgLen);


        /// Return Type: int
        ///cam: HA_Cam*
        ///id: int
        ///img: unsigned char*
        ///imgLen: int*
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_QueryOfflineRecordById", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_QueryOfflineRecordById(IntPtr cam, int id, System.IntPtr img, ref int imgLen);


        /// Return Type: void
        ///notify: boolean
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_SetNotifyConnected", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern void HA_SetNotifyConnected(int notify);


        /// Return Type: void
        ///cam: HA_Cam*
        ///callback: HA_IOStateCb_t
        ///userParm: void*
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_RegIOStateCb", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern void HA_RegIOStateCb(IntPtr cam, HA_IOStateCb_t callback, System.IntPtr userParm);


        /// Return Type: void
        ///dirFullPath: char*
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_SetPlateLogDirectory", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern void HA_SetPlateLogDirectory([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string dirFullPath);


        /// Return Type: void
        ///filename: char*
        ///imgData: char*
        ///width: int
        ///height: int
        ///cn: int
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_SaveBMP", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern void HA_SaveBMP([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string filename, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string imgData, int width, int height, int cn);


        /// Return Type: int
        ///filename: char*
        ///jpgBuf: char*
        ///len: int
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_SaveJpg", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_SaveJpg([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string filename, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string jpgBuf, int len);


        /// Return Type: int
        ///cam: HA_Cam*
        ///personID: char*
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_DeleteFaceDataByPersonID", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_DeleteFaceDataByPersonID(IntPtr cam, IntPtr personID);


        /// Return Type: int
        ///cam: HA_Cam*
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_DeleteFaceDataAll", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_DeleteFaceDataAll(IntPtr cam);


        /// Return Type: int
        ///cam: HA_Cam*
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_GetFaceIDTotal", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_GetFaceIDTotal(IntPtr cam);

        /// Return Type: int
        ///cam: HA_Cam*
        ///faceID: FaceFlags*
        ///jpg: char*
        ///len: int
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_AddJpgFace", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        //[Obsolete("use HA_AddFacesByJpg instead (请使用HA_AddFacesByJpg函数)", true)]
        public static extern int HA_AddJpgFace(IntPtr cam, ref FaceFlags faceID, IntPtr jpg, int len);



        /// <summary>
        /// Add face in jpg format (用jpg原图注册人脸)
        /// </summary>
        /// <param name="cam">handle to camera (相机句柄)</param>
        /// <param name="faceID"></param>
        /// <param name="imgs"></param>
        /// <param name="img_count">count of images, only 1 is supported (图片数量，仅支持1张图片)</param>
        /// <returns></returns>
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_AddFacesByJpg", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_AddFacesByJpg(IntPtr cam, ref FaceFlags faceID, ref FaceImage imgs, int img_count);


        /// <summary>
        /// 只添加人脸信息
        /// </summary>
        /// <param name="cam"></param>
        /// <param name="faceID"></param>
        /// <param name="mod">注册标记 1:注册 0:修改</param>
        /// <returns></returns>
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_AddFaceFlags", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_AddFaceFlags(IntPtr cam, ref FaceFlags faceID, byte mod);



        /// <summary>
        /// 单项修改
        /// </summary>
        /// <param name="cam"></param>
        /// <param name="faceID"></param>
        /// <param name="mod"></param>
        /// <returns></returns>
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_SeparateModifyFace", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_SeparateModifyFace(IntPtr cam, ref FaceFlags faceID, byte[] twist_imgs, uint twist_num, byte[] imgs, uint img_num, uint update_flags);


        /// Return Type: int
        ///cam: HA_Cam*
        ///faceID: FaceFlags*
        ///rgbimage: char*
        ///width: int
        ///height: int
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_AddFace", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_AddFace(IntPtr cam, ref FaceFlags faceID, IntPtr rgbimage, int width, int height);


        /// Return Type: int
        ///cam: HA_Cam*
        ///faceID: FaceFlags*
        ///jpg: char*
        ///len: int
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_ModifyJpgFace", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        [Obsolete("use HA_ModifyFacesByJpg instead (请使用HA_ModifyFacesByJpg函数)", true)]
        public static extern int HA_ModifyJpgFace(IntPtr cam, ref FaceFlags faceID, IntPtr jpg, int len);


       /// <summary>
       /// modify face by jpg image (原图修改注册的人像)
       /// </summary>
       /// <param name="cam"></param>
       /// <param name="faceID"></param>
       /// <param name="img"></param>
       /// <param name="len"></param>
       /// <returns></returns>
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_ModifyFacesByJpg", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_ModifyFacesByJpg(IntPtr cam, ref FaceFlags faceID, ref FaceImage img, int len);


        /// Return Type: int
        ///cam: HA_Cam*
        ///faceID: FaceFlags*
        ///rgbimage: char*
        ///width: int
        ///height: int
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_ModifyFace", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_ModifyFace(IntPtr cam, ref FaceFlags faceID, IntPtr rgbimage, int width, int height);


        /// Return Type: int
        ///cam: HA_Cam*
        ///result: QueryFaceFlags*
        ///record_no: int
        ///featureFlags: char
        ///imgFlags: char
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_QueryFaceID", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_QueryFaceID(IntPtr cam, ref QueryFaceFlags result, int record_no, [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.I1)] bool featureFlags, [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.I1)] bool imgFlags);
        
        /// Return Type: void
        ///cam: void*
        ///cb: HA_FaceQueryCb_t
        ///usrParam: void*
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_RegFaceQueryCb", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern void HA_RegFaceQueryCb(System.IntPtr cam, HA_FaceQueryCb_t cb, System.IntPtr usrParam);

        /// Return Type: int
        ///cam: void*
        ///sysTime: SystemTime*
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_GetSystemTime", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_GetSystemTime(System.IntPtr cam, ref SystemTime sysTime);


        /// Return Type: int
        ///cam: void*
        ///sysTime: SystemTime*
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_SetSystemTime", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_SetSystemTime(System.IntPtr cam, ref SystemTime sysTime);

        /// Return Type: int
        ///cam: void*
        ///enable: int
        ///timeout: int
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_SetDereplicationEnable", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_SetDereplicationEnable(System.IntPtr cam, int enable, int timeout);


        /*/// Return Type: int
        ///cam: void*
        ///UploadParam: ClientParam*
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_GetUploadConfig", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_GetUploadConfig(System.IntPtr cam, ref ClientParam UploadParam);


        /// Return Type: int
        ///cam: void*
        ///UploadParam: ClientParam*
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_SetUploadConfig", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_SetUploadConfig(System.IntPtr cam, ref ClientParam UploadParam);*/


        /// Return Type: int
        ///cam: void*
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_ResetFaceConfig", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_ResetFaceConfig(System.IntPtr cam);


        /// Return Type: int
        ///cam: void*
        ///max_exposure: short*
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_GetMaxExposure", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_GetMaxExposure(System.IntPtr cam, ref short max_exposure);


        /// Return Type: int
        ///cam: void*
        ///max_exposure: short
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_SetMaxExposure", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_SetMaxExposure(System.IntPtr cam, short max_exposure);


        /// Return Type: int
        ///cam: void*
        ///max_gain: short*
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_GetMaxGain", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_GetMaxGain(System.IntPtr cam, ref short max_gain);


        /// Return Type: int
        ///cam: void*
        ///max_gain: short
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_SetMaxGain", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_SetMaxGain(System.IntPtr cam, short max_gain);


        /// Return Type: int
        ///cam: void*
        ///contrast: short*
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_GetContrast", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_GetContrast(System.IntPtr cam, ref short contrast);


        /// Return Type: int
        ///cam: void*
        ///contrast: short
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_SetContrast", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_SetContrast(System.IntPtr cam, short contrast);


        /// Return Type: int
        ///cam: void*
        ///ntpInfo: NtpInfo*
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_GetNtpConfig", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_GetNtpConfig(System.IntPtr cam, ref NtpInfo ntpInfo);


        /// Return Type: int
        ///cam: void*
        ///ntpInfo: NtpInfo*
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_SetNtpConfig", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_SetNtpConfig(System.IntPtr cam, ref NtpInfo ntpInfo);


        /// Return Type: int
        ///cam: void*
        ///netInfo: SystemNetInfo*
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_GetNetConfig", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_GetNetConfig(System.IntPtr cam, ref SystemNetInfo netInfo);

        /// Return Type: int
        ///cam: void*
        ///netInfo: SystemNetInfo*
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_SetNetConfig", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_SetNetConfig(System.IntPtr cam, ref SystemNetInfo netInfo);

        /// <summary>
        /// 获取网络Ex
        /// </summary>
        /// <param name="cam"></param>
        /// <param name="netInfo"></param>
        /// <returns></returns>
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_GetNetConfigEx", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_GetNetConfigEx(System.IntPtr cam, ref SystemNetInfoEx netInfo);
        /// <summary>
        /// 设置网络Ex
        /// </summary>
        /// <param name="cam"></param>
        /// <param name="netInfo"></param>
        /// <returns></returns>
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_SetNetConfigEx", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_SetNetConfigEx(System.IntPtr cam, ref SystemNetInfoEx netInfo);
        /// <summary>
        /// 设置低温修正
        /// </summary>
        /// <param name="cam">相机句柄</param>
        /// <param name="enable">0关，1开</param>
        /// <param name="minTemp">最低人体温度</param>
        /// <param name="fix_rang">修正范围</param>
        /// <returns></returns>
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_SetMinTempFix", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_SetMinTempFix(System.IntPtr cam, bool enable, float minTemp, float fix_rang);

        /// Return Type: int
        ///cam: void*
        ///led_mode: char*
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_GetLedMode", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_GetLedMode(System.IntPtr cam, System.IntPtr led_mode);


        /// Return Type: int
        ///cam: void*
        ///led_mode: char
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_SetLedMode", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_SetLedMode(System.IntPtr cam, byte led_mode);


        


     


        /// Return Type: int
        ///cam: void*
        ///led_threshold: char*
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_GetLedThreshold", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_GetLedThreshold(System.IntPtr cam, System.IntPtr led_threshold);


        /// Return Type: int
        ///cam: void*
        ///led_threshold: char
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_SetLedThreshold", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_SetLedThreshold(System.IntPtr cam, byte led_threshold);

        /// Return Type: int
        ///cam: void*
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_SystemReboot", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_SystemReboot(System.IntPtr cam);


        /// Return Type: int
        ///cam: void*
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_AppReboot", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_AppReboot(System.IntPtr cam);

        /// Return Type: int
        ///jpg: char*
        ///len: int
        ///feature: float*
        ///feature_size: int*
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_GetJpgFaceFeature", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_GetJpgFaceFeature([System.Runtime.InteropServices.InAttribute()] System.IntPtr jpg, int len, ref float feature, ref int feature_size);


        /// Return Type: int
        ///rgbimage: char*
        ///width: int
        ///height: int
        ///feature: float*
        ///feature_size: int*
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_GetFaceFeature", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_GetFaceFeature([System.Runtime.InteropServices.InAttribute()] System.IntPtr rgbimage, int width, int height, ref float feature, ref int feature_size);

        /// Return Type: int
        ///cam: void*
        ///role: int
        ///page_no: int
        ///page_size: int
        ///featureFlags: char
        ///imgFlags: char
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_QueryByRole", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_QueryByRole(System.IntPtr cam, int role, int page_no, int page_size, [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.I1)] bool featureFlags, [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.I1)] bool imgFlags);

        /// Return Type: int
        ///jpg: char*
        ///len: int
        ///feature: float*
        ///feature_size: int*
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_GetJpgFaceFeature", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_GetJpgFaceFeature([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string jpg, int len, ref float feature, ref int feature_size);


        /// Return Type: int
        ///rgbimage: char*
        ///width: int
        ///height: int
        ///feature: float*
        ///feature_size: int*
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_GetFaceFeature", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_GetFaceFeature([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string rgbimage, int width, int height, ref float feature, ref int feature_size);


        /// Return Type: int
        ///f1: float*
        ///f2: float*
        ///feature_size: int
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_GetMatchScores", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_GetMatchScores(ref float f1, ref float f2, int feature_size);


        /// Return Type: int
        ///jpg: char*
        ///len: int
        ///feature: float*
        ///feature_size: int*
        ///faceRect: void*
        ///faceImgJpg: unsigned char*
        ///faceJpgLen: int*
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_GetJpgFaceRectAndFeature", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_GetJpgFaceRectAndFeature(IntPtr jpg, int len, IntPtr feature, ref int feature_size, ref ha_rect faceRect, System.IntPtr faceImgJpg, ref int faceJpgLen);


        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_GetJpgFaceTwist", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_GetJpgFaceTwist(IntPtr jpg, int len, IntPtr twist_image, ref int twist_size, ref int twist_width, ref int twist_height);
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct ha_rect
    {

        /// short
        public short x;

        /// short
        public short y;

        /// short
        public short width;

        /// short
        public short height;
    }

    public partial class NativeMethods
    {
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_GetDetectRect", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_GetDetectRect(IntPtr cam, ref ha_rect rect);

        /// Return Type: void
        ///cam: HA_Cam*
        ///rect: ha_rect*
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_SetDrawRect", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern void HA_SetDrawRect(IntPtr cam, ref ha_rect rect);


        /// Return Type: void
        ///cam: HA_Cam*
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_StartDrawRect", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern void HA_StartDrawRect(IntPtr cam);


        /// Return Type: void
        ///cam: HA_Cam*
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_StopDrawRect", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern void HA_StopDrawRect(IntPtr cam);
    }

    /// Return Type: SystemNetInfo
    ///cam: void*
    ///enable: int*
    ///timeout: int*
   // public delegate SystemNetInfo HA_GetDereplicationgConfig(System.IntPtr cam, ref int enable, ref int timeout);

    /// Return Type: void
    ///cam: HA_Cam*
    ///ip: char*
    ///port: unsigned short
    ///event: int
    ///usrParam: int
    [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute(System.Runtime.InteropServices.CallingConvention.StdCall)]
    public delegate void HA_ConnectEventCb_t(IntPtr cam, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string ip, ushort port, int @event, int usrParam);

    /// Return Type: void
    ///cam: HA_Cam*
    ///ip: char*
    ///stream: HA_LiveStream*
    ///usrParam: int
    [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute(System.Runtime.InteropServices.CallingConvention.StdCall)]
    public delegate void HA_LiveStreamCb_t(IntPtr cam, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string ip, System.IntPtr stream, int usrParam);

    /// Return Type: void
    ///cam: HA_Cam*
    ///ip: char*
    ///port: unsigned short
    ///dataType: int
    ///data: char*
    ///dataLen: unsigned int
    ///usrParam: int
    [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute(System.Runtime.InteropServices.CallingConvention.StdCall)]
    public delegate void HA_DataReadCb_t(IntPtr cam, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string ip, ushort port, int dataType, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string data, uint dataLen, int usrParam);

    /// Return Type: void
    ///cam: HA_Cam*
    ///rgb: unsigned char*
    ///width: int
    ///height: int
    ///usrParam: int
    [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute(System.Runtime.InteropServices.CallingConvention.StdCall)]
    public delegate void HA_DecodeImageCb_t(IntPtr cam, System.IntPtr rgb, int width, int height, int usrParam);

    /// Return Type: void
    ///cam: HA_Cam*
    ///index: int
    ///data: char*
    ///size: int
    ///usrParam: int
    [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute(System.Runtime.InteropServices.CallingConvention.StdCall)]
    public delegate void HA_ReadTSerialCb_t(IntPtr cam, int index, IntPtr data, int size, int usrParam);

    /// Return Type: void
    ///cam: HA_Cam*
    ///port: int
    ///inout: int
    ///state: int
    ///errNum: int
    ///resv: char*
    [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute(System.Runtime.InteropServices.CallingConvention.StdCall)]
    public delegate void HA_ReadGpioCb_t(IntPtr cam, int port, int inout, int state, int errNum, System.IntPtr resv);

    /// Return Type: void
    ///cam: HA_Cam*
    ///vehicle: pkg_vehicle*
    ///usrParam: int
    [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute(System.Runtime.InteropServices.CallingConvention.StdCall)]
    public delegate void HA_PlateInfoCb_t(IntPtr cam, System.IntPtr vehicle, int usrParam);

    /// Return Type: void
    ///cam: HA_Cam*
    ///index: int
    ///state: int
    ///usrParam: void*
    [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute(System.Runtime.InteropServices.CallingConvention.StdCall)]
    public delegate void HA_IOStateCb_t(IntPtr cam, int index, int state, System.IntPtr usrParam);

    /// Return Type: void
    ///cam: HA_Cam*
    ///pFeeInfo: FeeInfo*
    ///usrParam: void*
    [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute(System.Runtime.InteropServices.CallingConvention.StdCall)]
    public delegate void HA_OfflineFeeData_t(IntPtr cam, System.IntPtr pFeeInfo, System.IntPtr usrParam);

    /// Return Type: void
    ///cam: HA_Cam*
    ///plate: char*
    ///timeIn: timeval
    ///flag: int
    ///usrParam: void*
    [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute(System.Runtime.InteropServices.CallingConvention.StdCall)]
    public delegate void HA_OfflineQueriedEntryInfoCb_t(IntPtr cam, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string plate, timeval timeIn, int flag, System.IntPtr usrParam);

    /// Return Type: void
    ///cam: HA_Cam*
    ///validCount: int
    ///pFeeInfo: FeeInfoEx*
    ///startPos: int
    ///endPos: int
    ///usrParam: void*
    [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute(System.Runtime.InteropServices.CallingConvention.StdCall)]
    public delegate void HA_OfflineFeeDataQueriedByPageCb_t(IntPtr cam, int validCount, ref FeeInfoEx pFeeInfo, int startPos, int endPos, System.IntPtr usrParam);

    /// Return Type: void
    ///cam: HA_Cam*
    ///faceRecoInfo: FaceRecoInfo*
    ///usrParam: void*
    [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute(System.Runtime.InteropServices.CallingConvention.StdCall)]
    public delegate void HA_FaceRecoCb_t(IntPtr cam, System.IntPtr faceRecoInfo, System.IntPtr usrParam);

    /// <summary>
    /// GPIO输入信号
    /// </summary>
    /// <param name="cam"></param>
    /// <param name="type"></param>
    /// <param name="data"></param>
    /// <param name="usrParam"></param>
    [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute(System.Runtime.InteropServices.CallingConvention.StdCall)]
    public delegate void HA_GpioInputCb_t(IntPtr cam,int type,uint data, System.IntPtr usrParam);

    /// <summary>
    /// 获取二维码回调
    /// </summary>
    /// <param name="cam"></param>
    /// <param name="code"></param>
    /// <param name="usrParam"></param>
    /// <param name="usrParam"></param>
    [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute(System.Runtime.InteropServices.CallingConvention.StdCall)]
    public unsafe delegate  void HA_QRCodeCb_t(IntPtr cam, byte* code, byte[] res, System.IntPtr usrParam);

    /// Return Type: void
    ///cam: HA_Cam*
    ///faceRecoInfo: QueryFaceInfo*
    ///usrParam: void*
    [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute(System.Runtime.InteropServices.CallingConvention.StdCall)]
    public delegate void HA_FaceQueryCb_t(IntPtr cam, System.IntPtr faceQueryInfo, System.IntPtr usrParam);

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct timeval
    {

        /// int
        public int tv_sec;

        /// int
        public int tv_usec;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
    public struct QueryFaceInfo
    {

        /// int
        public int record_count;

        /// int
        public int record_no;

        /// char[20]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 20)]
        public byte[] personID;

        /// char[16]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 16)]
        public byte[] personName;

        /// int
        public int role;

        /// short
        public short feature_count;

        /// short
        public short feature_size;

        /// unsigned char*
        public System.IntPtr feature;

        /// int
        public int imgNum;

        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 5)]
        public int[] imgSize;

        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 4)]
        public string imgFmt1;

        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 4)]
        public string imgFmt2;

        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 4)]
        public string imgFmt3;

        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 4)]
        public string imgFmt4;

        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 4)]
        public string imgFmt5;

        public System.IntPtr imgBuff1;
        public System.IntPtr imgBuff2;
        public System.IntPtr imgBuff3;
        public System.IntPtr imgBuff4;
        public System.IntPtr imgBuff5;

        /// unsigned int
        public uint wgCardNO;

        /// unsigned int
        public uint effectTime;
        public uint effectStartTime;
        public short version;                 //非0:当前特征数据版本 0:不支持版本查询
        public byte ScheduleMode;  //调度模式 0:不使用调度模式  1~5 对应 Struct KindSchedule->ScheduleNameCode模式
        public byte resv;
        public int twistImgNum;//归一化图像数量
        [MarshalAs(UnmanagedType.ByValArray,  SizeConst =5)]
        public short[] twistwidth;                    //归一化图像宽度
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)]
        public short[] twistheight;                   //归一化图像高度
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)]
        public int[] twischannel;                   //归一化图像通道
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)]
        public IntPtr[] twistimgBuff;          //归一化图像第i张图片给数据首地址
        public UInt64 wgCardNOLong;   // 韦根门禁卡号加长 在wgCardNO长度不满足时使用此成员
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 68)]
        public byte[] userParam;  //用户自定义文本内容，可用于相机TTS播放、LCD显示，也可作为用户平台自定义属性使用
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
        public byte[] faceNameEx; //用户名拓展 当用户名不字段长于15字节使用此字段
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 372)]
        public byte[] resv1;

    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
    public struct NtpInfo
    {

        /// short
        public short enable_state;

        /// short
        public short update_cycle;

        /// char[16]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 16)]
        public byte[] ntp_server;

        /// char[12]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 12)]
        public byte[] resv;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
    public struct SystemTime
    {

        /// char
        public byte time_zone;

        /// char[11]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 11)]
        public byte[] date;

        /// char[9]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 9)]
        public byte[] time;

        /// char[11]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 11)]
        public byte[] resv;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
    public struct SystemNetInfo
    {

        /// char[18]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 18)]
        public byte[] mac_addr;

        /// char[16]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 16)]
        public byte[] ip_addr;

        /// char[16]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 16)]
        public byte[] netmask;

        /// char[16]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 16)]
        public byte[] gateway;

        /// char[14]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 14)]
        public byte[] resv;
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
    public struct SystemNetInfoEx
    {
        //char[20]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 20)]
        public byte[] mac;
        //char[20]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 20)]
        public byte[] ip;
        //char[20]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 20)]
        public byte[] netmask;
        //char[20]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 20)]
        public byte[] gateway;
        //char [16]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 16)]
        public byte[] manufacturer;
        //char[32]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 32)]
        public byte[] platform;
        //char[32]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 32)]
        public byte[] system;
        //char [64]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 64)]
        public byte[] version;
        //char [16]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 16)]
        public byte[] ip_2;
        //char [16]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 16)]
        public byte[] netmask_2;
        //char [16]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 16)]
        public byte[] dns;
        //char [1]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.U1)]
        public bool dhcp_enable;
        //char [64]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 64)]
        public byte[] resv;
    };

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
    public struct SystemVersionInfo
    {

        /// char[32]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 32)]
        public byte[] dev_id;

        /// char[8]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 8)]
        public byte[] protocol_ver;

        /// char[16]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 16)]
        public byte[] firmware_ver;

        /// char[8]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 8)]
        public byte[] code_ver;

        /// char[20]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 20)]
        public byte[] build_time;
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 16)]
        public byte[] resv;
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 16)]
        public byte[] systemp_type;  //系统类型   
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 16)]
        public byte[] plateform;     //硬件平台
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 16)]
        public byte[] sensor_type;   //传感器型号
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 16)]
        public string algorithm_ver; //算法版本

        /// char[16]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 944)]
        public byte[] resv1;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct FaceImage
    {

        /// int
        public int img_seq;

        /// int
        public int img_fmt;

        public IntPtr img;

        /// int
        public int img_len;

        /// int
        public int width;

        /// int
        public int height;
    }

    public partial class NativeMethods
    {
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_AddJpgFaces", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_AddJpgFaces(System.IntPtr cam, ref FaceFlags faceID, FaceImage[] imgs, int img_count, int picture_flags);

        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_AddFaces", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_AddFaces(System.IntPtr cam, ref FaceFlags faceID, FaceImage[] imgs, int img_count, int picture_flags);

        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_ModifyJpgFaces", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_ModifyJpgFaces(System.IntPtr cam, ref FaceFlags faceID, FaceImage[] imgs, int img_count, int picture_flags);

        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_ModifyFaces", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_ModifyFaces(System.IntPtr cam, ref FaceFlags faceID, FaceImage[] imgs, int img_count, int picture_flags);
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
    public struct AuthParam
    {

        /// unsigned char
        public byte enable;

        /// char[16]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 16)]
        public string user_name;

        /// char[17]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 17)]
        public string passwd;

        /// char[14]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 14)]
        public byte[] resv;
    }

    public partial class NativeMethods
    {

        /// Return Type: int
        ///cam: void*
        ///user_name: char*
        ///passwd: char*
        ///authInfo: AuthParam*
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_GetAuthInfo", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_GetAuthInfo(System.IntPtr cam, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string user_name, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string passwd, ref AuthParam authInfo);


        /// Return Type: int
        ///cam: void*
        ///user_name: char*
        ///passwd: char*
        ///authInfo: AuthParam*
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_SetAuthInfo", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_SetAuthInfo(System.IntPtr cam, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string user_name, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string passwd, ref AuthParam authInfo);

    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
    public struct FaceAppParam
    {

        /// char[32]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 32)]
        public byte[] dev_no;

        /// char[32]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 32)]
        public byte[] point_no;

        /// char[96]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 96)]
        public byte[] point_name;

        /// char[32]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 32)]
        public byte[] resv1;

        /// unsigned char
        public byte heart_beat_interval;

        /// char
        public byte extranet_enale;

        /// unsigned short
        public ushort extranet_port;

        /// char[16]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 16)]
        public byte[] extranet_ip;

        /// unsigned char
        public byte verify_enable;

        /// char[15]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 15)]
        public byte[] user_name;

        /// char[16]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 16)]
        public byte[] passwd;

        /// unsigned char[12]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 12)]
        public byte[] resv2;

        /// unsigned short
        public ushort upload_mode;

        /// unsigned short
        public ushort upload_port;

        /// char[16]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 16)]
        public byte[] upload_ip;

        /// char[102]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 102)]
        public byte[] upload_info;

        /// unsigned char
        public byte cam_mode;

        /// char[17]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 17)]
        public byte[] resv3;

        /// int
        public int match_enable;

        /// int
        public int match_score;

        /// int
        public int dereplication_enable;

        /// int
        public int dereplication_interval;

        /// unsigned short
        public ushort output_mode;

        /// char[256]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 256)]
        public byte[] resv4;
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
    public struct FtpInfo { 
    [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 15)]
    public string    user_name;     //用户名
    [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 15)]
    public string passwd;        //密码
    [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 70)]
    public string path;          //路径
    [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 12)]
    public string resv;           //空闲
    }


    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
    public struct AlarmInfoRecord
    {

        /// char[32]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 32)]
        public string cameraID;

        /// char[20]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 20)]
        public string alarmTime;

        /// unsigned char
        public byte alarmDeviceType;

        /// char[3]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 3)]
        public string resv;

        /// char[20]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 20)]
        public string personID;

        /// unsigned int
        public uint alarmDeviceId;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
    public struct AlarmRequest
    {

        /// char[32]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 32)]
        public string cameraID;

        /// char[20]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 20)]
        public string personID;

        /// char[20]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 20)]
        public string requestTime;

        /// unsigned char
        public byte alarmDeviceType;

        /// unsigned char
        public byte alarmDeviceState;

        /// char[2]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 2)]
        public string resv;

        /// unsigned int
        public uint alarmDeviceId;
        /// <summary>
        /// 韦根门禁卡号加长 在alarmDeviceId长度不满足时使用此成员
        /// </summary>
        public long wgCardNOLong;

        public int type;
        /// <summary>
        /// 体温
        /// </summary>
        public float body_temp;
    }

    /// Return Type: void
    ///cam: void*
    ///alarmRecord: AlarmInfoRecord*
    ///usrParam: void*
    [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute(System.Runtime.InteropServices.CallingConvention.StdCall)]
    public delegate void HA_AlarmRecordCb_t(System.IntPtr cam, ref AlarmInfoRecord alarmRecord, System.IntPtr usrParam);

    /// Return Type: void
    ///cam: void*
    ///alarmRequest: AlarmRequest*
    ///usrParam: void*
    [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute(System.Runtime.InteropServices.CallingConvention.StdCall)]
    public delegate void HA_AlarmRequestCb_t(System.IntPtr cam, ref AlarmRequest alarmRequest, System.IntPtr usrParam);

    public partial class NativeMethods
    {

        /// Return Type: int
        ///cam: void*
        ///param: FaceAppParam*
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_GetFaceAppParam", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_GetFaceAppParam(System.IntPtr cam, ref FaceAppParam param);


        /// Return Type: int
        ///cam: void*
        ///param: FaceAppParam*
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_SetFaceAppParam", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_SetFaceAppParam(System.IntPtr cam, ref FaceAppParam param);


        /// Return Type: void
        ///cam: void*
        ///cb: HA_AlarmRecordCb_t
        ///usrParam: void*
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_RegAlarmRecordCb", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern void HA_RegAlarmRecordCb(System.IntPtr cam, HA_AlarmRecordCb_t cb, System.IntPtr usrParam);


        /// Return Type: void
        ///cam: void*
        ///cb: HA_AlarmRequestCb_t
        ///usrParam: void*
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_RegAlarmRequestCb", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern void HA_RegAlarmRequestCb(System.IntPtr cam, HA_AlarmRequestCb_t cb, System.IntPtr usrParam);

        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_WiegandAlarm", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_WiegandAlarm(System.IntPtr cam, uint wiegand_no);

    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct ErrorFaceImage
    {

        /// int
        public int img_seq;

        /// int
        public int err_code;
    }

    public partial class NativeMethods
    {

        /// Return Type: int
        ///cam: void*
        ///type: int
        ///faceID: FaceFlags*
        ///imgs: FaceImage*
        ///img_count: int
        ///picture_flags: int
        ///err_imgs: ErrorFaceImage*
        ///err_imgs_count: int*
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_JpgFacesEx", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        [Obsolete("use HA_AddFacesByJpg instead (请使用HA_AddFacesByJpg函数)", true)]
        public static extern int HA_JpgFacesEx(System.IntPtr cam, int type, ref FaceFlags faceID, FaceImage[] imgs, int img_count, int picture_flags,[Out] ErrorFaceImage[] err_imgs, ref int err_imgs_count);

        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_AddFacePacket", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_AddFacePacket(IntPtr cam, ref FaceFlags faceID, FaceImage[] features, int features_size, int features_num, ref FaceImage imgs, int img_num);

        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_ModifyFacePacket", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_ModifyFacePacket(IntPtr cam, ref FaceFlags faceID, FaceImage[] features, int features_size, int features_num, ref FaceImage imgs, int img_num);

        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_SetFaceCheckEnable", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_SetFaceCheckEnable(int img_num);
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
    public struct RecordData
    {

        /// int
        public int record_count;

        /// int
        public int record_no;

        /// unsigned int
        public uint sequence;

        /// unsigned int
        public uint tvSec;

        /// unsigned int
        public uint tvUsec;

        /// short
        public short matched;

        /// unsigned char
        public byte sex;

        /// unsigned char
        public byte age;

        /// char[20]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 20)]
        public byte[] person_id;

        /// char[16]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 16)]
        public byte[] person_name;

        /// int
        public int face_image_len;

        /// unsigned char*
        public System.IntPtr face_image;

        /// unsigned short
        public ushort faceXInFaceImg;

        /// unsigned short
        public ushort faceYInFaceImg;

        /// unsigned short
        public ushort faceWInFaceImg;

        /// unsigned short
        public ushort faceHInFaceImg;

        /// int
        public int reg_image_len;

        /// unsigned char*
        public System.IntPtr reg_image;

        /// unsigned char
        public byte qvalue;

        /// char
        public byte is_upload;

        public sbyte role;

        public byte resv;

        /// <summary>
        /// 比对类型 参见MatchType
        /// </summary>
        public uint match_type;
         [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 64)]
        public byte[] customer_txt;

         [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 64)]
         public byte[] person_name_ext;
        /// <summary>
        /// 体温
        /// </summary>
         public float temperature;
    }


    [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute(System.Runtime.InteropServices.CallingConvention.StdCall)]
    public delegate void HA_FaceRecordCb_t(System.IntPtr cam, IntPtr recordInfo, System.IntPtr usrParam);

    public enum QueryMode:ushort
    {

        /// QUERY_EXACT -> 0x0
        QUERY_EXACT = 0,

        /// QUERY_FUZZY -> 0x1
        QUERY_FUZZY = 1,
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
    public struct RecordCondition
    {

        /// char
        public byte img_flag;

        /// char
        public byte reg_img_flag;

        /// char[2]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 2)]
        public byte[] resv1;

        /// unsigned short
        public QueryMode query_mode;

        /// unsigned short
        public RecordQueryFlag condition_flag;

        /// unsigned int
        public uint time_start;

        /// unsigned int
        public uint time_end;

        /// short
        public short score_start;

        /// short
        public short score_end;

        /// unsigned char
        public byte sex;

        /// unsigned char
        public byte age_start;

        /// unsigned char
        public byte age_end;

        /// char[17]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 17)]
        public byte[] resv2;

        /// char[20]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 20)]
        public byte[] person_id;

        /// char[16]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 16)]
        public byte[] person_name;

        /// unsigned char
        public byte qvalue_start;

        /// unsigned char
        public byte qvalue_end;

        /// char
        public sbyte upload_state;

        /// char[65]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 65)]
        public byte[] resv3;
    }

    [Flags]
    public enum RecordQueryFlag : ushort
    {
        NONE = 0,
        /// RECORD_QUERY_FLAG_TIME -> 0x1
        RECORD_QUERY_FLAG_TIME = 1,

        /// RECORD_QUERY_FLAG_SCORE -> 0x1<<1
        RECORD_QUERY_FLAG_SCORE = (1) << (1),

        /// RECORD_QUERY_FLAG_SEX -> 0x1<<2
        RECORD_QUERY_FLAG_SEX = (1) << (2),

        /// RECORD_QUERY_FLAG_AGE -> 0x1<<3
        RECORD_QUERY_FLAG_AGE = (1) << (3),

        /// RECORD_QUERY_FLAG_ID -> 0x1<<4
        RECORD_QUERY_FLAG_ID = (1) << (4),

        /// RECORD_QUERY_FLAG_NAME -> 0x1<<5
        RECORD_QUERY_FLAG_NAME = (1) << (5),

        /// RECORD_QUERY_FLAG_QVALUE -> 0x1<<6
        RECORD_QUERY_FLAG_QVALUE = (1) << (6),

        /// RECORD_QUERY_FLAG_UPLOAD -> 0x1<<7
        RECORD_QUERY_FLAG_UPLOAD = (1) << (7),

        /// RECORD_QUERY_FLAG_SEQUENCE -> 0x1<<8
        RECORD_QUERY_FLAG_SEQUENCE = (1) << (8),
    }


    public partial class NativeMethods
    {

        /// Return Type: int
        ///cam: void*
        ///page_no: int
        ///page_size: int
        ///condition: RecordCondition*
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_QueryFaceRecord", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_QueryFaceRecord(System.IntPtr cam, int page_no, int page_size, ref RecordCondition condition);

        /// Return Type: int
        ///cam: void*
        ///sequence: unsigned int
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_DeleteFaceRecordBySequence", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_DeleteFaceRecordBySequence(System.IntPtr cam, uint sequence);


        /// Return Type: int
        ///cam: void*
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_DeleteFaceRecordAll", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_DeleteFaceRecordAll(System.IntPtr cam);


        /// Return Type: void
        ///cam: void*
        ///cb: HA_FaceRecordCb_t
        ///usrParam: void*
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_RegFaceRecordQueryCb", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern void HA_RegFaceRecordQueryCb(System.IntPtr cam, HA_FaceRecordCb_t cb, System.IntPtr usrParam);

        /// Return Type: int
        ///cam: void*
        ///enable: char*
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_GetRecorderEnable", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_GetRecorderEnable(System.IntPtr cam, ref byte enable);


        /// Return Type: int
        ///cam: void*
        ///enable: char
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_SetRecorderEnable", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_SetRecorderEnable(System.IntPtr cam, byte enable);


        /// Return Type: int
        ///cam: void*
        ///enable: char*
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_GetRecorderResumeEnable", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_GetRecorderResumeEnable(System.IntPtr cam, ref byte enable);


        /// Return Type: int
        ///cam: void*
        ///enable: char
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_SetRecorderResumeEnable", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_SetRecorderResumeEnable(System.IntPtr cam, byte enable);

    }

    public partial class NativeMethods
    {

        /// Return Type: int
        ///jpg: char*
        ///len: int
        ///twist_image: unsigned char*
        ///twist_size: int*
        ///twist_width: int*
        ///twist_height: int*
        ///faceImgJpg: unsigned char*
        ///faceJpgLen: int*
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_GetJpgFeatureImage", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_GetJpgFeatureImage([In] byte[] jpg, int len, [Out] byte[] twist_image, ref int twist_size, ref int twist_width, ref int twist_height, [Out] byte[] faceImgJpg, ref int faceJpgLen);
        
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_GetAllPersonId", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_GetAllPersonId(System.IntPtr cam,[Out] byte[] PersonIdBuff,int Buffsize,ref int count,ref int total);
        //public static extern int HA_GetAllPersonId(System.IntPtr cam, IntPtr PersonIdBuff, int Buffsize, ref int count, ref int total);
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct SnapshotImage
    {

        /// unsigned int
        public uint timeStamp_s;

        /// unsigned int
        public uint timeStamp_u;

        /// int
        public int snapImageSize;

        /// unsigned char*
        //[System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray)]
        //public byte[] snapImage;
        public IntPtr snapImage;

        public int infraredImageSize;

        public IntPtr infraredImage;
    }

    /// Return Type: void
    ///cam: void*
    ///snapImage: SnapshotImage*
    ///usrParam: void*
    [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute(System.Runtime.InteropServices.CallingConvention.StdCall)]
    public delegate void HA_SnapshotCb_t(System.IntPtr cam, ref SnapshotImage snapImage, System.IntPtr usrParam);

    public partial class NativeMethods
    {

        /// Return Type: void
        ///cam: void*
        ///cb: HA_SnapshotCb_t
        ///usrParam: void*
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_RegSnapshotCb", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern void HA_RegSnapshotCb(System.IntPtr cam, HA_SnapshotCb_t cb, System.IntPtr usrParam);


        /// Return Type: int
        ///cam: void*
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_Snapshot", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_Snapshot(System.IntPtr cam);

        /// Return Type: int
        ///password: char*
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_SetSDKPassword", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_SetSDKPassword([In] [MarshalAs(UnmanagedType.LPStr)] string password);
        
        /// Return Type: int
        ///cam: void*
        ///password: char*
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_SetCamSDKPassword", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_SetCamSDKPassword(System.IntPtr cam, [In] [MarshalAs(UnmanagedType.LPStr)] string password);
    }

    public partial class NativeMethods
    {

        /// Return Type: int
        ///cam: void*
        ///mode: unsigned char*
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_GetMatchMode", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_GetMatchMode(System.IntPtr cam, ref byte mode);


        /// Return Type: int
        ///cam: void*
        ///mode: unsigned char
        [System.Runtime.InteropServices.DllImportAttribute("libHasdk.dll", EntryPoint = "HA_SetMatchMode", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int HA_SetMatchMode(System.IntPtr cam, byte mode);

        [DllImport("libHasdk.dll", EntryPoint = "HA_GetAliveDetectEnable", CallingConvention = CallingConvention.StdCall)]
        public static extern int HA_GetAliveDetectEnable(IntPtr cam, [MarshalAs(UnmanagedType.Bool)] ref bool enabled);

        [DllImport("libHasdk.dll", EntryPoint = "HA_SetAliveDetectEnable", CallingConvention = CallingConvention.StdCall)]
        public static extern int HA_SetAliveDetectEnable(IntPtr cam, [MarshalAs(UnmanagedType.Bool)] bool enabled);
    }


    public partial class NativeMethods
    {

        [DllImport("libHasdk.dll", EntryPoint = "HA_GetHatDetectEnable", CallingConvention = CallingConvention.StdCall)]
        public static extern int HA_GetHatDetectEnable(IntPtr cam, [MarshalAs(UnmanagedType.Bool)] ref bool enabled);

        [DllImport("libHasdk.dll", EntryPoint = "HA_SetHatDetectEnable", CallingConvention = CallingConvention.StdCall)]
        public static extern int HA_SetHatDetectEnable(IntPtr cam, [MarshalAs(UnmanagedType.Bool)] bool enabled);
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct QueryCondition
    {

        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 20)]
        public byte[] faceID;//人员ID

        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 16)]
        public byte[] faceName;//人员姓名

         public uint wgCardNO;  //韦根协议门禁卡号
         public uint timeStart; //有效期截止时间的查询起点
         public uint timeEnd;   //有效期截止d时间的查询终点
         public uint time1Start; //有效期起始时间的查询起点
         public uint time1End;   //有效期起始时间的查询终点
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 256)]
         public byte[] resv;
    
    }

    public partial class NativeMethods
    {



        [DllImport("libHasdk.dll", EntryPoint = "HA_QueryFaceEx", CallingConvention = CallingConvention.StdCall)]
        public static extern int HA_QueryFaceEx(IntPtr cam, int role, int page_no, int page_size, [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.I1)] bool featureFlags, [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.I1)] bool imgFlags, short condition_flag, short query_mode, ref QueryCondition querycondition);
    }

   




    [Flags]
    public enum ConditionFlag : ushort
    {
        


        //通过ID查询
        QUERY_BY_ID = 0x1,

        //通过姓名查询
        QUERY_BY_NAME = 0x2,

        //通过韦根卡号查询
        QUERY_BY_WGNO = 0x4,

        //通过有效期截止时间范围查询
        QUERY_BY_EFFECT_TIME = 0x8,

        //通过有效期起始时间范围查询
        QUERY_BY_EFFECT_START_TIME = 0x10

    }



     public partial class NativeMethods
    {



          [DllImport("libHasdk.dll", EntryPoint = "HA_GetScheduleModeCfgEx", CallingConvention = CallingConvention.StdCall)]
         public static extern int HA_GetScheduleModeCfgEx(IntPtr cam,  IntPtr cfg, ref  int ScheduleCount);

          [DllImport("libHasdk.dll", EntryPoint = "HA_SetScheduleModeCfg", CallingConvention = CallingConvention.StdCall)]
          public static extern int HA_SetScheduleModeCfg(IntPtr cam, IntPtr cfg, int ScheduleCount);

    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
     public struct KindSchedule
    {

     public    ScheduleMode Mode; //调度模式 
     [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 16)]
	 public byte[] ScheduleName;  //类别名称  自定义
	public ushort ScheduleNameCode; //类别代码  取值 [1~5] 不能重复   
	/*调度模式为 SCHEDULE_MODE_DAILY 时 只读取Schedule[0] 配置  
	为 SCHEDULE_MODE_WEEKLY 时周一 周日按Schedule[0]-Schedule[7] 配置 */
    [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 7, ArraySubType = System.Runtime.InteropServices.UnmanagedType.Struct)] 
	 public DailySchedule[] Schedule;  //调度时间 
     [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 32)]
	 public byte[] recv; //保留 
    
    }


    
    public enum ScheduleMode 
    {
        


        /*! 禁用。 */
	SCHEDULE_MODE_NONE = 0,

	/*! 按天调度。 周1-周7 都按照此设置运行  */
	SCHEDULE_MODE_DAILY = 1,   

	/*! 按周调度。 周1-周7分别设置*/
	SCHEDULE_MODE_WEEKLY = 2

    }


    public struct DailySchedule{
	public uint Sector; // 一天内时间总段数 最大支持6段   设置Schedule[0]--Schedule[1].......Schedule[Sector] 内为开闸时间
    [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = System.Runtime.InteropServices.UnmanagedType.Struct)]
	public HourSchedule[] SchTime;  // 调度时间 在此时间段为开闸时间
    [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 16)]
	public byte[] recv; //保留 
    }


    public struct HourSchedule{
	/*! 起始时间。闭区间（包含该值）。 */
	public MinuteSchedule start;

	/*! 结束时间。开区间（不包含该值）。 */
	public MinuteSchedule end;
    }


     public struct MinuteSchedule{
	/*! 时。取值范围：0~24。 */
	public byte hour;

	/*! 分。取值范围：0~59。 */
    public byte minute;
    }



     public partial class NativeMethods
     {

         /**
 * @brief   查看过期自动清理开关
 * @param   cam[in]   相机句柄
 * @param   enable[out] 清理开关:关 1:开
 * @return  0 获取成功              
 * @return  <0 获取失败  参考错误码
 */

         [DllImport("libHasdk.dll", EntryPoint = "HA_GetAutoCleanEnable", CallingConvention = CallingConvention.StdCall)]
         public static extern int HA_GetAutoCleanEnable(IntPtr cam, ref  int enable);

         [DllImport("libHasdk.dll", EntryPoint = "HA_SetAutoCleanEnable", CallingConvention = CallingConvention.StdCall)]
         public static extern int HA_SetAutoCleanEnable(IntPtr cam, int enable);




     }


    //安全帽枚举

     public enum HatDetectResult
     {
         /*! 未检测到安全帽 */
         NO_HAT = 0,
         /*! 蓝色安全帽 */
         HAVE_BLUE_HAT= 1,
         /*! 橙色安全帽 */
         HAVE_ORANGE_HAT= 2,
         /*! 红色安全帽 */
         HAVE_RED_HAT= 3,
         /*! 白色安全帽 */
         HAVE_WHITE_HAT= 4,
         /*! 黄色安全帽 */
         HAVE_YELLOW_HAT= 5,
     };


     public enum MatchType
     {
         /*! 未知 */
         MATCH_TYPE_NULL = 0x0,

         /*! 刷脸比对成功 */

         MATCH_TYPE_NORMAL = 0x1,

         /*! 人证比对成功 */

         MATCH_TYPE_IDCARD_1TO1 = 0x1 << 1,

         /*! 刷身份证比对 */

         MATCH_TYPE_IDCARD = 0x1 << 2,

         /*! 刷卡比对成功 */

         MATCH_TYPE_WGCARD = 0x1 << 3,

         /*! 过人开闸 */

         MATCH_TYPE_ANY_FACE = 0x1 << 4
     };

     /// LCD显示项
     public enum LcdDisplayItem
     {
         /*! 显示标题 */
         LCD_DISPLAY_ITEM_TITILE = 0x1,

         /*! 显示时间 */
         LCD_DISPLAY_ITEM_TIME = 0x1 << 1,

         /*! 显示IP */
         LCD_DISPLAY_ITEM_IP = 0x1 << 2,

         /*! 显示人脸库数量 */
         LCD_DISPLAY_ITEM_PERSON_NUM = 0x1 << 3
     };


    /// <summary>
    /// 安全帽禁止通行
    /// </summary>
     public partial class NativeMethods
     {



         [DllImport("libHasdk.dll", EntryPoint = "HA_GetProhibitSafetyhat", CallingConvention = CallingConvention.StdCall)]
         public static extern int HA_GetProhibitSafetyhat(IntPtr cam, ref  int pro);

         [DllImport("libHasdk.dll", EntryPoint = "HA_SetProhibitSafetyhat", CallingConvention = CallingConvention.StdCall)]
         public static extern int HA_SetProhibitSafetyhat(IntPtr cam, int pro);


         /// <summary>
         /// 获取相机宽动态
         /// </summary>
         /// <param name="cam"></param>
         /// <param name="pro"></param>
         /// <returns></returns>
         [DllImport("libHasdk.dll", EntryPoint = "HA_GetWDR", CallingConvention = CallingConvention.StdCall)]
         public static extern int HA_GetWDR(IntPtr cam,ref byte enable,ref HourSchedule t_wdr);
         /// <summary>
         ///   设置相机宽动态
         /// </summary>
         /// <param name="cam"></param>
         /// <param name="pro"></param>
         /// <returns></returns>
         [DllImport("libHasdk.dll", EntryPoint = "HA_SetWDR", CallingConvention = CallingConvention.StdCall)]
         public static extern int HA_SetWDR(IntPtr cam, byte enable, HourSchedule t_wdr);
         /// <summary>
         /// 设置屏幕显示
         /// </summary>
         /// <param name="cam"></param>
         /// <param name="screen_title"></param>
         /// <returns></returns>
         [DllImport("libHasdk.dll", EntryPoint = "HA_SetScreenOsdTitle", CallingConvention = CallingConvention.StdCall)]
         public static extern int HA_SetScreenOsdTitle(IntPtr cam, byte[] screen_title);


         /// <summary>
         /// 语音播放
         /// </summary>
         /// <param name="cam"></param>
         /// <param name="screen_title"></param>
         /// <returns></returns>
         [DllImport("libHasdk.dll", EntryPoint = "HA_TTSPlayAudio", CallingConvention = CallingConvention.StdCall)]
         public static extern int HA_TTSPlayAudio(IntPtr cam, byte[] txt);

         /// <summary>
         /// 获取上传数据
         /// </summary>
         /// <param name="cam"></param>
         /// <param name="UploadParam"></param>
         /// <returns></returns>
         [DllImport("libHasdk.dll", EntryPoint = "HA_GetUploadConfig", CallingConvention = CallingConvention.StdCall)]
         public static extern int HA_GetUploadConfig(IntPtr cam,ref ClientParam UploadParam);

         /// <summary>
         /// 设置上传数据
         /// </summary>
         /// <param name="cam"></param>
         /// <param name="UploadParam"></param>
         /// <returns></returns>
         [DllImport("libHasdk.dll", EntryPoint = "HA_SetUploadConfig", CallingConvention = CallingConvention.StdCall)]
         public static extern int HA_SetUploadConfig(IntPtr cam, ref ClientParam UploadParam);

         /// <summary>
         /// 获取相机设备信息
         /// </summary>
         /// <param name="cam"></param>
         /// <param name="UploadParam"></param>
         /// <returns></returns>
         [DllImport("libHasdk.dll", EntryPoint = "HA_GetFaceSystemVersionEx", CallingConvention = CallingConvention.StdCall)]
         public static extern int HA_GetFaceSystemVersionEx(IntPtr cam, ref SystemVersionInfo version);


         /// <summary>
         /// 检测图片
         /// </summary>
         /// <param name="jpg"></param>
         /// <param name="len"></param>
         /// <returns></returns>
         [DllImport("libHasdk.dll", EntryPoint = "HA_FaceJpgLegal", CallingConvention = CallingConvention.StdCall)]
         public static extern int HA_FaceJpgLegal(IntPtr jpg, int len);

         /// <summary>
         /// 获得去重复
         /// </summary>
         /// <param name="cam"></param>
         /// <param name="enable"></param>
         /// <param name="timeout"></param>
         /// <returns></returns>
          [DllImport("libHasdk.dll", EntryPoint = "HA_GetDereplicationgConfig", CallingConvention = CallingConvention.StdCall)]
         public static extern int HA_GetDereplicationgConfig(System.IntPtr cam, ref int enable, ref int timeout);

         /// <summary>
         /// 设置去重复
         /// </summary>
         /// <param name="cam"></param>
         /// <param name="enable"></param>
         /// <param name="timeout"></param>
         /// <returns></returns>
          [DllImport("libHasdk.dll", EntryPoint = "HA_SetDereplicationEnable", CallingConvention = CallingConvention.StdCall)]
          public static extern int HA_SetDereplicationEnable(System.IntPtr cam, ref int enable, ref int timeout);

         /// <summary>
         /// 获取外网穿透
         /// </summary>
         /// <param name="cam"></param>
         /// <param name="extr"></param>
         /// <returns></returns>
          [DllImport("libHasdk.dll", EntryPoint = "HA_GetExtranetParam", CallingConvention = CallingConvention.StdCall)]
          public static extern int HA_GetExtranetParam(System.IntPtr cam, ref ExtranetParam extr);

         /// <summary>
         /// 设置外网穿透
         /// </summary>
         /// <param name="cam"></param>
         /// <param name="extr"></param>
         /// <returns></returns>
          [DllImport("libHasdk.dll", EntryPoint = "HA_SetExtranetParam", CallingConvention = CallingConvention.StdCall)]
          public static extern int HA_SetExtranetParam(System.IntPtr cam,  ExtranetParam extr);
         /// <summary>
         /// 获取设备音量
         /// </summary>
         /// <param name="cam"></param>
         /// <param name="audio_volume"></param>
         /// <returns></returns>
          [DllImport("libHasdk.dll", EntryPoint = "HA_GetAudioVolume", CallingConvention = CallingConvention.StdCall)]
          public static extern int HA_GetAudioVolume(System.IntPtr cam, ref int audio_volume);
         /// <summary>
         /// 设置设备音量
         /// </summary>
         /// <param name="cam"></param>
         /// <param name="audio_volume"></param>
         /// <returns></returns>
          [DllImport("libHasdk.dll", EntryPoint = "HA_SetAudioVolume", CallingConvention = CallingConvention.StdCall)]
          public static extern int HA_SetAudioVolume(System.IntPtr cam,  int audio_volume);


          /// <summary>
          /// 获取音频
          /// </summary>
          /// <param name="cam"></param>
          /// <param name="items"></param>
          /// <param name="itemBufNum"></param>
          /// <param name="itemNum"></param>
          /// <returns></returns>
          [DllImport("libHasdk.dll", EntryPoint = "HA_GetAudioList", CallingConvention = CallingConvention.StdCall)]
          public static extern int HA_GetAudioList(IntPtr cam, IntPtr items, int itemBufNum, ref int itemNum);
          /// <summary>
          /// 播放音频
          /// </summary>
          /// <param name="cam"></param>
          /// <param name="items"></param>
          /// <returns></returns>
          [DllImport("libHasdk.dll", EntryPoint = "HA_TestAudioItemByName", CallingConvention = CallingConvention.StdCall)]
          public static extern int HA_TestAudioItemByName(IntPtr cam, ref AudioItem items);

         /// <summary>
          /// 设置LCD显示屏显示项
         /// </summary>
         /// <param name="cam"></param>
         /// <param name="itme"></param>
         /// <returns></returns>
          [DllImport("libHasdk.dll", EntryPoint = "HA_SetLcdDisplayItems", CallingConvention = CallingConvention.StdCall)]
          public static extern int HA_SetLcdDisplayItems(IntPtr cam, int itme);
         /// <summary>
          /// 获取LCD显示屏显示项
         /// </summary>
         /// <param name="cam"></param>
         /// <param name="itme"></param>
         /// <returns></returns>
          [DllImport("libHasdk.dll", EntryPoint = "HA_GetLcdDisplayItems", CallingConvention = CallingConvention.StdCall)]
          public static extern int HA_GetLcdDisplayItems(IntPtr cam,ref int itme);

         /// <summary>
         /// 获取比对成功显示项
         /// </summary>
         /// <param name="cam"></param>
         /// <param name="itme"></param>
         /// <returns></returns>
          [DllImport("libHasdk.dll", EntryPoint = "HA_GetPersonDisplayOptions", CallingConvention = CallingConvention.StdCall)]
          public static extern int HA_GetPersonDisplayOptions(IntPtr cam, ref int Options);

         /// <summary>
         /// 设置比对成功显示项
         /// </summary>
         /// <param name="cam"></param>
         /// <param name="Options"></param>
         /// <returns></returns>
          [DllImport("libHasdk.dll", EntryPoint = "HA_SetPersonDisplayOptions", CallingConvention = CallingConvention.StdCall)]
          public static extern int HA_SetPersonDisplayOptions(IntPtr cam,  int Options);
         /// <summary>
         /// 获取镜像显示开关
         /// </summary>
         /// <param name="cam"></param>
         /// <param name="Options"></param>
         /// <returns></returns>
          [DllImport("libHasdk.dll", EntryPoint = "HA_GetflipEnable", CallingConvention = CallingConvention.StdCall)]
          public static extern int HA_GetflipEnable(IntPtr cam, ref byte Enable);

         /// <summary>
         /// 设置镜像显示开关
         /// </summary>
         /// <param name="cam"></param>
         /// <param name="Options"></param>
         /// <returns></returns>
          [DllImport("libHasdk.dll", EntryPoint = "HA_SetflipEnable", CallingConvention = CallingConvention.StdCall)]
          public static extern int HA_SetflipEnable(IntPtr cam, byte Enable);

         /// <summary>
         /// 获取显示屏亮度
         /// </summary>
         /// <param name="cam"></param>
         /// <param name="led_level"></param>
         /// <returns></returns>
          [DllImport("libHasdk.dll", EntryPoint = "HA_GetLedLevel", CallingConvention = CallingConvention.StdCall)]
          public static extern int HA_GetLedLevel(IntPtr cam,ref byte led_level);

         /// <summary>
         /// 设置屏幕亮度
         /// </summary>
         /// <param name="cam"></param>
         /// <param name="led_level"></param>
         /// <returns></returns>
          [DllImport("libHasdk.dll", EntryPoint = "HA_SetLedLevel", CallingConvention = CallingConvention.StdCall)]
          public static extern int HA_SetLedLevel(IntPtr cam,  byte led_level);
         /// <summary>
         /// 获取上传方式域名
         /// </summary>
         /// <param name="cam"></param>
         /// <param name="domain"></param>
         /// <returns></returns>
          [DllImport("libHasdk.dll", EntryPoint = "HA_GetUploadDomain", CallingConvention = CallingConvention.StdCall)]
          public static extern int HA_GetUploadDomain(IntPtr cam, byte[] domain);

         /// <summary>
         /// 设置长传方式域名
         /// </summary>
         /// <param name="cam"></param>
         /// <param name="domain"></param>
         /// <returns></returns>
          [DllImport("libHasdk.dll", EntryPoint = "HA_SetUploadDomain", CallingConvention = CallingConvention.StdCall)]
          public static extern int HA_SetUploadDomain(IntPtr cam,  byte[] domain);

          /// <summary>
          /// 获取外网穿透域名
          /// </summary>
          /// <param name="cam"></param>
          /// <param name="domain"></param>
          /// <returns></returns>
          [DllImport("libHasdk.dll", EntryPoint = "HA_GetExtranetDomain", CallingConvention = CallingConvention.StdCall)]
          public static extern int HA_GetExtranetDomain(IntPtr cam, byte[] domain);

          /// <summary>
          /// 设置外网穿透域名
          /// </summary>
          /// <param name="cam"></param>
          /// <param name="domain"></param>
          /// <returns></returns>
          [DllImport("libHasdk.dll", EntryPoint = "HA_SetExtranetDomain", CallingConvention = CallingConvention.StdCall)]
          public static extern int HA_SetExtranetDomain(IntPtr cam, byte[] domain);
         /// <summary>
          /// 获取体温检测开关
         /// </summary>
         /// <param name="cam"></param>
          /// <param name="enable">0:关 1:开</param>
         /// <returns></returns>
          [DllImport("libHasdk.dll", EntryPoint = "HA_GetTemperaturEnable", CallingConvention = CallingConvention.StdCall)]
          public static extern int HA_GetTemperaturEnable(IntPtr cam, ref int enable);

         /// <summary>
          /// 设置体温检测开关
         /// </summary>
         /// <param name="cam"></param>
         /// <param name="enable"></param>
         /// <returns></returns>
          [DllImport("libHasdk.dll", EntryPoint = "HA_SetTemperaturEnable", CallingConvention = CallingConvention.StdCall)]
          public static extern int HA_SetTemperaturEnable(IntPtr cam, int enable);


          [DllImport("libHasdk")]
          public unsafe static extern int HA_GetFaceSystemCfgEx(void* cam, void* cfg);
          [DllImport("libHasdk")]
          public unsafe static extern int HA_SetFaceSystemCfgEx(void* cam, void* cfg);


         /// <summary>
          /// 设置是否限制体温
         /// </summary>
         /// <param name="cam"></param>
          /// <param name="temperatur">高于此温度不开闸</param>
          /// <param name="enable">0:关 1:开 打开后体温高于temperatur不开闸</param>
         /// <returns></returns>
          [DllImport("libHasdk.dll", EntryPoint = "HA_SetTemperaturLimit", CallingConvention = CallingConvention.StdCall)]
          public static extern int HA_SetTemperaturLimit(IntPtr cam, float temperatur, int enable);


          /// <summary>
          /// 获取是否限制体温
          /// </summary>
          /// <param name="cam"></param>
          /// <param name="temperatur">高于此温度不开闸</param>
          /// <param name="enable">0:关 1:开 打开后体温高于temperatur不开闸</param>
          /// <returns></returns>
          [DllImport("libHasdk.dll", EntryPoint = "HA_GetTemperaturLimit", CallingConvention = CallingConvention.StdCall)]
          public static extern int HA_GetTemperaturLimit(IntPtr cam,ref float temperatur,ref int enable);
         /// <summary>
          /// 发送json命令到相机
         /// </summary>
         /// <param name="cam"></param>
         /// <param name="cmd"></param>
         /// <param name="json"></param>
         /// <param name="jsonSize"></param>
         /// <param name="replyJson"></param>
         /// <param name="buffSize"></param>
         /// <returns></returns>
          [DllImport("libHasdk.dll", EntryPoint = "HA_SendJson", CallingConvention = CallingConvention.StdCall)]
          public static extern int HA_SendJson(IntPtr cam, byte[] cmd,byte[] json, int jsonSize,  byte[] replyJson , int buffSize);

        /// <summary>
        /// 功能授权
        /// </summary>
        /// <param name="cam"></param>
        /// <param name="number"></param>
        /// <param name="data"></param>
        /// <param name="size"></param>
        /// <returns></returns>
        [DllImport("libHasdk.dll", EntryPoint = "HA_FunctionAuth", CallingConvention = CallingConvention.StdCall)]
        public static extern int HA_FunctionAuth(IntPtr cam, short number, byte[] data,short size);

          /// <summary>
          /// 获取口罩检查开关
          /// </summary>
          /// <param name="cam"></param>
          /// <param name="enable"></param>
          /// <returns></returns>
          [DllImport("libHasdk.dll", EntryPoint = "HA_GetMaskInspectEnable", CallingConvention = CallingConvention.StdCall)]
          public static extern int HA_GetMaskInspectEnable(IntPtr cam, ref int enable);

         /// <summary>
         /// 设置口罩检查开关
         /// </summary>
         /// <param name="cam"></param>
         /// <param name="enable"></param>
         /// <returns></returns>
          [DllImport("libHasdk.dll", EntryPoint = "HA_SetMaskInspectEnable", CallingConvention = CallingConvention.StdCall)]
          public static extern int HA_SetMaskInspectEnable(IntPtr cam,  int enable);

         /// <summary>
          /// 获取相机gpio工作状态  gpio状态。1：常开模式 0：常闭模式
         /// </summary>
         /// <param name="cam"></param>
         /// <param name="enable"></param>
         /// <returns></returns>
          [DllImport("libHasdk.dll", EntryPoint = "HA_GetGpioWorkState", CallingConvention = CallingConvention.StdCall)]
          public static extern int HA_GetGpioWorkState(IntPtr cam,ref byte enable);

         /// <summary>
          /// 设置相机gpio工作状态  gpio状态。1：常开模式 0：常闭模式
         /// </summary>
         /// <param name="cam"></param>
         /// <param name="enable"></param>
         /// <returns></returns>
          [DllImport("libHasdk.dll", EntryPoint = "HA_SetGpioWorkState", CallingConvention = CallingConvention.StdCall)]
          public static extern int HA_SetGpioWorkState(IntPtr cam, byte enable);


         /// <summary>
         /// 获取应用参数
         /// </summary>
         /// <param name="cam"></param>
         /// <param name="conf"></param>
         /// <returns></returns>
          [DllImport("libHasdk.dll", EntryPoint = "HA_GetFaceSystemCfgEx", CallingConvention = CallingConvention.StdCall)]
          public static extern int HA_GetFaceSystemCfgEx(IntPtr cam,ref FaceSystemConfigex conf);

         /// <summary>
         /// 设置应用参数
         /// </summary>
         /// <param name="cam"></param>
         /// <param name="conf"></param>
         /// <returns></returns>
          [DllImport("libHasdk.dll", EntryPoint = "HA_SetFaceSystemCfgEx", CallingConvention = CallingConvention.StdCall)]
          public static extern int HA_SetFaceSystemCfgEx(IntPtr cam,ref  FaceSystemConfigex conf);

         /// <summary>
          /// 打开检测旋转人脸 打开后自动修正旋转方向错误的图片 注:打开后会影响检测速度
         /// </summary>
         /// <param name="cam"></param>
          /// <param name="enable">enable 开关 0:关 !0:开</param>
         /// <returns></returns>
          [DllImport("libHasdk.dll", EntryPoint = "HA_SetFaceCheckRotate", CallingConvention = CallingConvention.StdCall)]
          public static extern int HA_SetFaceCheckRotate( int enable);

         /// <summary>
         /// 获取版本信息
         /// </summary>
         /// <param name="cam"></param>
         /// <param name="version"></param>
         /// <returns></returns>
          [DllImport("libHasdk.dll", EntryPoint = "HA_GetVersion", CallingConvention = CallingConvention.StdCall)]
          public static extern int HA_GetVersion(ref HaSdkVersion version);


          /**
 *  @brief  新算法提取归一化图像和人脸略缩图像 提取成功后需调用 HA_FeatureConvert转换为可注册数据
 *  @param  [IN] jpg 图片数据 支持bmp,jpg,png
 *  @param  [IN] len 图片数据长度
 *  @param  [OUT] feature_image 新归一化图像数据 注:至少分配110K
 *  @param  [IN|OUT] feature_size in:twist_image内存大小 out:归一化数据大小
 *  @param  [OUT] faceImgJpg 抠出的人脸略缩图像 注:建议分配 10K 以上
 *  @param  [IN|OUT] faceJpgLen in: faceImgJpg 分配的内存大小 out:抠出的人脸略缩图像长度
 *  @param  [IN] twist_version 算法版本可为NULL 为NULL时会提取所有版本
 *  @return 返回值为0表示成功，返回负数表示失败，具体参考错误码
 */
          [DllImport("libHasdk.dll", EntryPoint = "HA_GetJpgFeatureImageNew", CallingConvention = CallingConvention.StdCall)]
          public static extern int HA_GetJpgFeatureImageNew(byte[] jpg, int len, byte[] feature_image,ref int feature_size, byte[] faceImgJpg,ref int faceJpgLen, byte[] twist_version);

         /**
*  @brief  转换新算法归一化数据
*  @param  [IN] cam 相机句柄 可为NULL 为NULL时通过[twist_version]判断要准换的版本
*  @param  [IN] feature_image 新归一化图像数据
*  @param  [IN] feature_size 归一化图像数据长度
*  @param  [OUT] twist_image 归一化数据
*				struct FaceImage
*				{
*					int img_seq;    //图片编号 填0
*					int img_fmt;    //图片格式 填1
*					unsigned char *img; // 归一化数据 需自行分配内存 建议至少70K
*					int img_len;    //in:img 分配的内存长度 out:归一化数据长度
*					int width;      //图像宽度 输出
*					int height;     //图像高度 输出
*				};
*  @param  [IN] twist_version 算法版本 可为NULL 为NULL时通过[cam]判断要转换的版本 
*  @return 返回值为0表示成功，返回负数表示失败，具体参考错误码
*/
    [DllImport("libHasdk.dll", EntryPoint = "HA_FeatureConvert", CallingConvention = CallingConvention.StdCall)]
    public static extern int HA_FeatureConvert(IntPtr cam, byte[] feature_image, int feature_size,ref FaceImage twist_image, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string twist_version);




     }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
    public struct HaSdkVersion
{
    [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 64)]
    public string sdk_version;       //sdk版本
    [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 64)]
    public string protocl_version;   //协议类型
    [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 64)]
    public string sdk_code_version;  //sdk源代码版本

    [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 64)]
    public string min_firmware_ver;  //支持的最低固件版本

    [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 64)]
    public string algorithm_version; //sdk使用得算法版本
};


     public enum LcdPersonDisplayItem
     {
         /*! 显示比对成功的人员姓名 */
         LCD_PERSON_DISPLAY_ITEM_PERSON_NAME = 0x1 << 1,

         /*! 显示比对成功的人员图像 */
         LCD_PERSON_DISPLAY_ITEM_PERSON_IMAGE = 0x1 << 2,

         /*! 显示比对成功的人员比对时间 */
         LCD_PERSON_DISPLAY_ITEM_PERSON_MATCH_TIME = 0x1 << 3,

         /*! 显示比对成功的人员自定义字段 */
         LCD_PERSON_DISPLAY_ITEM_PERSON_TEXT = 0x1 << 4
     };



     [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
     public struct ClientParam { 
     public byte mode; /*0 未初始化。 1 TCP协议上传。 2 FTP协议上传。 3 HTTP协议上传。4 WebService上传 5 mqtt上传*/

     public byte  enable_heart; //心跳开关 目前只控制http

     /*! 保留。 */
     [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 2)]
     public string resv;
     [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 120)]
     public byte[] ClientParams;
     
     }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
    public struct ExtranetParam {
  /*! 以TCP客户端方式直达外网。 */
  [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 120)]
     public byte[] ExtranetParams;

     public byte enable;//使能

  /*! 穿透模式，0：以TCP客户端方式直达外网。1：以 comet长轮询模式直达外网 2：以comet流模式直达外网 */
     public byte mode;

      /*! 保留。 */
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 6)]
      public string resv;
};




    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
     public struct FtpClientParam1 { 
     /*! 服务器IP地址。 */
       [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 16)]
      public string  ip;

      /*! 服务器端口。 */
      public int port;

      /*! 登录用户名。 */
       [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 15)]
       public string user;

       /*! 登录密码。 */
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 15)]
       public string password;

  /*! 上传目录。 */
         [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 70)]
       public string pattern;
     
     
     }


    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
    public struct TcpClientParam1
    {
        /*! 服务器IP地址。 */
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 16)]
        public string ip;

        /*! 服务器端口。 */
        public int port;
        /*! 使能开关（未使用，该字段仅为兼容旧协议而加入）。 */
        public byte enable;

        /*! 登录验证开关。 */
        public byte enable_verify;

        /*! 登录用户名。 */
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 16)]
        public string user_name;

        /*! 登录密码。 */
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 17)]
        public string passwd;

        /*! 上传目录。 */
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 65)]
        public string resv;


    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
    public struct HttpClientParam1{
    
    /*! 服务器IP地址。 */
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 16)]
      public string ip;

  /*! 服务器端口。 */
      public ushort port;

  /*! 服务URL。 */
         [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 102)]
      public string url;
    
    
    
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
    public struct FaceSystemConfigex {


        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 28)]
        public byte[] TemporaryParam;

        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 640)]
        public byte[] PlatformParam;

        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 64)]
        public byte[] StreamParam;

        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 512)]
        public byte[] AppCommonParam;

        /// <summary>
        /// 私有参数保留字段1
        /// </summary>
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 18)]
        public byte[] FacePrivateParam1;

        /// <summary>
        /// 白名单GPIO输出开关（端口1）。1：开 0：关
        /// </summary>
        public byte gpio_enable_white;

        /// <summary>
        /// 私有参数保留字段1.2
        /// </summary>
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 58)]
        public byte[] FacePrivateParam1_2;
        /* 过滤未比对上的抓拍数据 0 不过滤 非0过滤  */
        public byte filter_not_match;

        /// <summary>
        /// 私有参数保留字段2
        /// </summary>
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 434)]
        public byte[] FacePrivateParam2;



        /// <summary>
        /// 剩下所有保留字段
        /// </summary>
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 2176)]
        public byte[] revs;
    
    }

  




}