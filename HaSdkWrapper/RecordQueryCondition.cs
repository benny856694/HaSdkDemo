using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HaSdkWrapper
{
    /// <summary>
    /// 设备抓拍记录查询条件
    /// </summary>
    public struct RecordQueryCondition
    {
        /// <summary>
        /// 是否按抓拍时间
        /// </summary>
        public bool ByCaptureTime { get; set; }
        /// <summary>
        /// 抓拍起始时间
        /// </summary>
        public DateTime TimeStart { get; set; }
        /// <summary>
        /// 抓拍结束时间
        /// </summary>
        public DateTime TimeEnd { get; set; }

        /// <summary>
        /// 是否按结束时间区间查询
        /// </summary>
        public bool ByCaptureTime2 { get; set; }
        /// <summary>
        /// 有效期结束起始时间
        /// </summary>
        public DateTime TimeStart2 { get; set; }
        /// <summary>
        /// 有效期结束结束时间
        /// </summary>
        public DateTime TimeEnd2 { get; set; }



        /// <summary>
        /// 是否按起始区间查询
        /// </summary>
        public bool ByCaptureTime1 { get; set; }
        /// <summary>
        /// 有效期起始时间
        /// </summary>
        public DateTime Time1Start { get; set; }
        /// <summary>
        /// 有效期结束时间
        /// </summary>
        public DateTime Time1End { get; set; }





        /// <summary>
        /// 是否通过匹配分数查询
        /// </summary>
        public bool ByMatchScore { get; set; }
        /// <summary>
        /// 匹配分数区间起始值
        /// </summary>
        public int MatchScoreStart { get; set; }
        /// <summary>
        /// 匹配分数区间结束值
        /// </summary>
        public int MatchScoreEnd { get; set; }
        /// <summary>
        /// 是否按照性别查询
        /// </summary>
        public bool BySex { get; set; }
        /// <summary>
        /// 性别查询条件 1:男 2:女
        /// </summary>
        public int Sex { get; set; }
        /// <summary>
        /// 是否按照年龄查询
        /// </summary>
        public bool ByAge { get; set; }
        /// <summary>
        /// 年龄起始值
        /// </summary>
        public int AgeStart { get; set; }
        /// <summary>
        /// 年轻结束值
        /// </summary>
        public int AgeEnd { get; set; }
        /// <summary>
        /// 是否按人脸标准度查询
        /// </summary>
        public bool ByQValue { get; set; }
        /// <summary>
        /// 标准度起始值
        /// </summary>
        public int QValueStart { get; set; }
        /// <summary>
        /// 标准度结束值
        /// </summary>
        public int QValueEnd { get; set; }
        /// <summary>
        /// 是否按上传状态查询
        /// </summary>
        public bool ByUploadState { get; set; }
        /// <summary>
        /// 上传状态过滤条件 1 已上传 2 未上传
        /// </summary>
        public int UploadState { get; set; }
        /// <summary>
        /// 是否开启模糊查询（只支持用户编号和姓名）
        /// </summary>
        public bool FuzzyMode { get; set; }
        /// <summary>
        /// 是否按用户编号查询
        /// </summary>
        public bool ById { get; set; }
        /// <summary>
        /// 用户编号查询内容
        /// </summary>
        public string PersonId { get; set; }
        /// <summary>
        /// 是否按用户姓名查询
        /// </summary>
        public bool ByName { get; set; }
        /// <summary>
        /// 用户姓名查询内容
        /// </summary>
        public string PersonName { get; set; }


        /// <summary>
        /// 通过韦根卡号查询查询
        /// </summary>
        public bool WgNo { get; set; }
        /// <summary>
        /// 韦根卡号查询内容
        /// </summary>
        public int WgNoc { get; set; }







    }
}
