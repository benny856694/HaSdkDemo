using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HaSdkWrapper
{
    /// <summary>
    /// <para>设备抓拍记录查询条件</para>
    /// <EN>Face Search Criteria</EN>
    /// </summary>
    public struct RecordQueryCondition
    {
        /// <summary>
        /// <para>是否按抓拍时间</para>
        /// <EN>Flag to enable TimeStart and TimeEnd field</EN>
        /// </summary>
        public bool ByCaptureTime { get; set; }
        /// <summary>
        /// <para>抓拍起始时间</para>
        /// <EN>Starting point of time range, this is used to query offline face capture record</EN>
        /// </summary>
        public DateTime TimeStart { get; set; }
        /// <summary>
        /// <para>抓拍结束时间</para>
        /// <EN>End point of time range, this is used to query offline face capture record</EN>
        /// </summary>
        public DateTime TimeEnd { get; set; }

        /// <summary>
        /// <para>是否按结束时间区间查询</para>
        /// <EN>Flag to enable TimeStart2 and TimeEnd2</EN>
        /// </summary>
        public bool ByCaptureTime2 { get; set; }
        /// <summary>
        /// <para>有效期结束起始时间</para>
        /// <EN>Starting point of time range, this is used to query valid to time of face database</EN>
        /// </summary>
        public DateTime TimeStart2 { get; set; }
        /// <summary>
        /// <para>有效期结束结束时间</para>
        /// <EN>End point of time range, this is used to query valid to time of face database</EN>
        /// </summary>
        public DateTime TimeEnd2 { get; set; }



        /// <summary>
        /// <para>是否按起始区间查询</para>
        /// <EN>Flag to enable TimeStart1 and TimeEnd1</EN>
        /// </summary>
        public bool ByCaptureTime1 { get; set; }
        /// <summary>
        /// <para>有效期起始时间</para>
        /// <EN>Start point of time range, this is used to query valid from time of face database</EN>
        /// </summary>
        public DateTime Time1Start { get; set; }
        /// <summary>
        /// <para>有效期结束时间</para>
        /// <EN>End point of time range, this is used to query valid from time of face database</EN>
        /// </summary>
        public DateTime Time1End { get; set; }





        /// <summary>
        /// <para>是否通过匹配分数查询</para>
        /// <EN>Flag to enable MatchScoreStart and MatchScoreEnd field</EN>
        /// </summary>
        public bool ByMatchScore { get; set; }
        /// <summary>
        /// <para>匹配分数区间起始值</para>
        /// <EN>Lower bound of score match range</EN>
        /// </summary>
        public int MatchScoreStart { get; set; }
        /// <summary>
        /// <para>匹配分数区间结束值</para>
        /// <EN>Upper bound of score match range</EN>
        /// </summary>
        public int MatchScoreEnd { get; set; }
        /// <summary>
        /// <para>是否按照性别查询</para>
        /// <EN>Flag to enable Sex field</EN>
        /// </summary>
        public bool BySex { get; set; }
        /// <summary>
        /// <para>性别查询条件</para> 1:男 2:女
        /// <EN>Gender - 1：Male, 2: Female</EN>
        /// </summary>
        public int Sex { get; set; }
        /// <summary>
        /// <para>是否按照年龄查询</para>
        /// <EN>Flag to enable Age Range</EN>
        /// </summary>
        public bool ByAge { get; set; }
        /// <summary>
        /// <para>年龄起始值</para>
        /// <EN>Lower bound of age range</EN>
        /// </summary>
        public int AgeStart { get; set; }
        /// <summary>
        /// <para>年轻结束值</para>
        /// <EN>Upper bound of age range</EN>
        /// </summary>
        public int AgeEnd { get; set; }
        /// <summary>
        /// <para>是否按人脸标准度查询</para>
        /// <EN>Flag to enable quality of image</EN>
        /// </summary>
        public bool ByQValue { get; set; }
        /// <summary>
        /// <para>标准度起始值</para>
        /// <EN>Lower bound of range for quality of image </EN>
        /// </summary>
        public int QValueStart { get; set; }
        /// <summary>
        /// <para>标准度结束值</para>
        /// <EN>Upper bound of range for quality of image</EN>
        /// </summary>
        public int QValueEnd { get; set; }
        /// <summary>
        /// <para>是否按上传状态查询</para>
        /// <EN>Flag to enable UploadState field</EN>
        /// </summary>
        public bool ByUploadState { get; set; }
        /// <summary>
        /// <para>上传状态过滤条件</para> 1 已上传 2 未上传
        /// <EN>Upload state - 1: uploaded, 2: not uploaded</EN>
        /// </summary>
        public int UploadState { get; set; }
        /// <summary>
        /// <para>是否开启模糊查询</para>（只支持用户编号和姓名）
        /// <EN>Flag to enable fuzzy matching mode (only face id and name are supported)</EN>
        /// </summary>
        public bool FuzzyMode { get; set; }
        /// <summary>
        /// <para>是否按用户编号查询</para>
        /// <EN>Flag to enable PersonId field</EN>
        /// </summary>
        public bool ById { get; set; }
        /// <summary>
        /// <para>用户编号查询内容</para>
        /// <EN>Id</EN>
        /// </summary>
        public string PersonId { get; set; }
        /// <summary>
        /// <para>是否按用户姓名查询</para>
        /// <EN>Flag to enable PersonName field</EN>
        /// </summary>
        public bool ByName { get; set; }
        /// <summary>
        /// <para>用户姓名查询内容</para>
        /// <EN>Name</EN>
        /// </summary>
        public string PersonName { get; set; }


        /// <summary>
        /// <para>通过韦根卡号查询查询</para>
        /// <EN>Flag to enable WgNoc field</EN>
        /// </summary>
        public bool WgNo { get; set; }
        /// <summary>
        /// <para>韦根卡号查询内容</para>
        /// <EN>Wiegand Card Number</EN>
        /// </summary>
        public int WgNoc { get; set; }







    }
}
