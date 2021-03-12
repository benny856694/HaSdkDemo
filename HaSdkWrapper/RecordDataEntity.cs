using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace HaSdkWrapper
{
    public class RecordDataEntity
    {
        /// <summary>
        /// 抓拍序号，从1开始，每产生一组抓拍数据增加1。
        /// </summary>
        public uint SequenceID { internal set; get; }
        /// <summary>
        /// 抓拍时间
        /// </summary>
        public DateTime CaptureTime { internal set; get; }
        /// <summary>
        /// <para>是否对比到库中的模板</para>
        /// <para>true表示对比到库中的人 false表示当前抓拍未比中库中模板</para>
        /// </summary>
        public bool IsPersonMatched { internal set; get; }
        /// <summary>
        /// 相似度
        /// </summary>
        public int MatchScore { internal set; get; }
        /// <summary>
        /// <para>人物编号</para>
        /// <para>只有对比到人脸才有值</para>
        /// </summary>
        public string PersonID { internal set; get; }
        /// <summary>
        /// <para>人物姓名</para>
        /// <para>只有对比到人脸才有值</para>
        /// </summary>
        public string PersonName { internal set; get; }
        /// <summary>
        /// <para>特写图数据（JPEG格式图片的全部数据，包括文件头），可能为空表示没有传输特写图</para>
        /// <para>一般来说特写图就是人脸图，不过不排除是头肩部的截取</para>
        /// </summary>
        public byte[] FeatureImageData { internal set; get; }
        /// <summary>
        /// 人脸在特写图中的区域（没有特写图时这个值可能是空值或者默认值）
        /// </summary>
        public Rectangle FaceInFeature { internal set; get; }
        /// <summary>
        /// 性别 0：未知 1：男 2：女
        /// </summary>
        public byte Sex { internal set; get; }
        /// <summary>
        /// 年龄 0：未知
        /// </summary>
        public byte Age { internal set; get; }
        /// <summary>
        /// 比中的模板图（JPEG格式图片的全部数据，包括文件头）
        /// </summary>
        public byte[] ModelFaceImageData { internal set; get; }
        /// <summary>
        /// 纪录是否已上传 1:表示已经上传 0：表示未上传
        /// </summary>
        public bool IsUpload { internal set; get; }
        /// <summary>
        /// 角色 0：普通人员。 1：白名单人员。 2：黑名单人员 -2：无此信息
        /// </summary>
        public int PersonRole { internal set; get; }

        /// <summary>
        /// 体温
        /// </summary>
        public float temperature { internal set; get; }
    }
}
