using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace HaSdkWrapper
{
    public class FaceCapturedEventArgs : EventArgs
    {
        /// <summary>
        /// <para>抓拍序号，从1开始，每产生一组抓拍数据增加1。</para>
        /// <EN>The sequence number of the captured face, increased by 1 for every capture</EN>
        /// </summary>
        public uint SequenceID { internal set; get; }
        /// <summary>
        /// <para>相机编号</para>
        /// <EN>Camera id</EN>
        /// </summary>
        public string CameraID { internal set; get; }
        /// <summary>
        /// <para>点位编号</para>
        /// <EN>Position id</EN>
        /// </summary>
        public string AddrID { internal set; get; }
        /// <summary>
        /// <para>点位名称</para>
        /// <EN>Position name</EN>
        /// </summary>
        public string AddrName { internal set; get; }
        /// <summary>
        /// <para>抓拍时间</para>
        /// <EN>Capture time</EN>
        /// </summary>
        public DateTime CaptureTime { internal set; get; }
        /// <summary>
        /// <para>实时抓拍标志，true表示是实时数据，false表示历史数据</para>
        /// <EN>Realtime data flag, true: realtime data, false: history data</EN>
        /// </summary>
        public bool IsRealTimeData { internal set; get; }
        /// <summary>
        /// <para>是否对比到库中的模板, true表示对比到库中的人 false表示当前抓拍未比中库中模板</para>
        /// <EN>Whether the captured face matches the face database - True: matches, False: doesn't match</EN>
        /// </summary>
        public bool IsPersonMatched { internal set; get; }
        /// <summary>
        /// <para>相似度</para>
        /// <EN>The matching score</EN>
        /// </summary>
        public int MatchScore { internal set; get; }
        /// <summary>
        /// <para>人物编号，只有对比到人脸才有值</para>
        /// <EN>Face id if any matches found, null if none</EN>
        /// </summary>
        public string PersonID { internal set; get; }
        /// <summary>
        /// <para>人物姓名, 只有对比到人脸才有值</para>
        /// <EN>Name of the face if match found, null if none</EN>
        /// </summary>
        public string PersonName { internal set; get; }
        /// <summary>
        /// <para>角色0：普通人员。 1：白名单人员。 2：黑名单人员</para>
        /// <EN>Type of the face - 0：normal, 1：white name, 2：black name</EN>
        /// </summary>
        public int PersonRole { internal set; get; }
        /// <summary>
        /// <para>大图数据（JPEG格式图片的全部数据，包括文件头），可能为空表示没有传输大图</para>
        /// <EN>The full image in jpeg format, null if not configured to transfer</EN>
        /// </summary>
        public byte[] EnvironmentImageData { internal set; get; }
        /// <summary>
        /// <para>人脸在大图中的区域（没有大图时这个值可能是空值或者默认值）</para>
        /// <EN>The face part of the image</EN>
        /// </summary>
        public Rectangle FaceInEnvironment { internal set; get; }
        /// <summary>
        /// <para>特写图数据（JPEG格式图片的全部数据，包括文件头），可能为空表示没有传输特写图，一般来说特写图就是人脸图，不过不排除是头肩部的截取</para>
        /// <EN>Close-up face image</EN>
        /// </summary>
        public byte[] FeatureImageData { internal set; get; }
        /// <summary>
        /// <para>人脸在特写图中的区域（没有特写图时这个值可能是空值或者默认值）</para>
        /// <EN>Face bound in the close-up image</EN>
        /// </summary>
        public Rectangle FaceInFeature { internal set; get; }
        /// <summary>
        /// <para>视频数据（可能为空表示没有视频数据）</para>
        /// <EN>video data</EN>
        /// </summary>
        public byte[] VideoData { internal set; get; }
        /// <summary>
        /// <para>视频开始时间</para>
        /// <EN>Video start time</EN>
        /// </summary>
        public DateTime VideoStartTime { internal set; get; }
        /// <summary>
        /// <para>视频结束时间</para>
        /// <EN>Video end time</EN>
        /// </summary>
        public DateTime VideoEndTime { internal set; get; }
        /// <summary>
        /// <para>性别 0：未知 1：男 2：女</para>
        /// <EN>Gender - 0: unknown, 1: male, 2: female</EN>
        /// </summary>
        public byte Sex { internal set; get; }
        /// <summary>
        /// <para>年龄 0：未知</para>
        /// <EN>Age - 0: unknown</EN>
        /// </summary>
        public byte Age { internal set; get; }
        /// <summary>
        /// <para>人脸标准度 0：未计算 1~100：一个表示人脸角度和光线/噪点等质量因素的值，越大越好（即越大角度越正，光线越均匀，像素越平坦）</para>
        /// <EN>The quality of the image, the bigger the better</EN>
        /// </summary>
        public byte QValue { internal set; get; }
        /// <summary>
        /// <para>抓拍图特征值数据</para>
        /// <EN>The feature data of the image</EN>
        /// </summary>
        public float[] FeatureData { internal set; get; }
        /// <summary>
        /// <para>比中的模板图（JPEG格式图片的全部数据，包括文件头）</para>
        /// <EN>Matched face image from face database in jpeg format</EN>
        /// </summary>
        public byte[] ModelFaceImageData { internal set; get; }


        /// <summary>
        /// <para>安全帽 1蓝 2橙色 3红色 4白色 5黄色</para>
        /// <EN>Safety helmet color - 1: blue 2: orange 3: red 4: white 5: yellow</EN>
        /// </summary>
        public byte hatColour { internal set; get; }

        /// <summary>
        /// <para>是否活体 0：无此信息 1：活体 2：非活体</para>
        /// <EN>Liveness detected - 0: unknown, 1: yes, 2: no</EN>
        /// </summary>
        public byte living { internal set; get; }

        /// <summary>
        /// <para>设备序列号</para>
        /// <EN>SN of the device</EN>
        /// </summary>
        public string dev_id { internal set; get; }

        /// <summary>
        /// <para>是否存在身份证信息</para>
        /// <EN>Has id card info</EN>
        /// </summary>
        public int existIDCard { internal set; get; }

        /// <summary>
        /// <para>身份证号</para>
        /// <EN>Id card number</EN>
        /// </summary>
        public string IDCardnumber { internal set; get; }
        /// <summary>
        /// <para>姓名</para>
        /// <EN>Id card name</EN>
        /// </summary>
        public string IDCardname { internal set; get; }
        /// <summary>
        /// <para>性别</para>
        /// <EN>Id card gender</EN>
        /// </summary>
        public byte IDCardsex;
        /// <summary>
        /// <para>民族</para>
        /// <EN>Id card nationality</EN>
        /// </summary>
        public string IDCardnational { internal set; get; }
        /// <summary>
        /// <para>出生日期</para>
        /// <EN>Id card birthday</EN>
        /// </summary>
        public string IDCardbirth { internal set; get; }
        /// <summary>
        /// <para>地址</para>
        /// <EN>Id card address</EN>
        /// </summary>
        public string IDCardresidence_address { internal set; get; }
        /// <summary>
        /// <para>签发机关</para>
        /// <EN>Id card issued by</EN>
        /// </summary>
        public string IDCardorgan_issue { internal set; get; }
        /// <summary>
        /// <para>有效期起始时间</para>
        /// <EN>Id card valid from</EN>
        /// </summary>
        public string IDCardvalid_date_start { internal set; get; }

        /// <summary>
        ///有效期截止时间
        ///<EN>Id card valid to</EN>
        /// </summary>
        public string IDCardvalid_date_end { internal set; get; }
        /// <summary>
        /// <para>自定义字段</para>
        /// <EN>User defined data</EN>
        /// </summary>
        public string userParam { internal set; get; }

        /// <summary>
        /// <para>抓拍类型</para>
        /// <EN>Match type</EN>
        /// </summary>
        public MatchType matchtype { internal set; get; }

        /// <summary>
        /// <para>32位伟根</para>
        /// <EN>32-bit Wiegand No.</EN>
        /// </summary>
        public int wgCardNO { internal set; get; }
        /// <summary>
        /// <para>64位伟根</para>
        /// <EN>64-bit Wiegand No.</EN>
        /// </summary>
        public long wgCardNOLong { internal set; get; }
        /// <summary>
        /// <para>体温</para>
        /// <EN>Temperature</EN>
        /// </summary>
        public float temperature { internal set; get; }
        /// <summary>
        /// <para>是否佩戴口罩 0:无此信息 1:已佩戴口罩 2:未佩戴口罩</para>
        /// <EN>Wears mask - 0: unknown, 1: wears, 2: doesn't wear</EN>
        /// </summary>
        public float hasMask { internal set; get; }
      
    }
}
