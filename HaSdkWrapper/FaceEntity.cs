using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HaSdkWrapper
{
    public class FaceEntity
    {
        /// <summary>
        /// 人员编号
        /// </summary>
        public string PersonID { get; internal set; }
        /// <summary>
        /// 人员姓名
        /// </summary>
        public string PersonName { get; internal set; }
        /// <summary>
        /// 人员角色，0：普通人员。 1：白名单人员。 2：黑名单人员。
        /// </summary>
        public int PersonRole { get; internal set; }
        /// <summary>
        /// 特征值数据
        /// </summary>
        public float[][] FeatureData { get; internal set; }
        /// <summary>
        /// 模板图数据
        /// </summary>
        public byte[][] ImageData { get; internal set; }
        /// <summary>
        /// 韦根门禁卡号
        /// </summary>
        public uint WiegandNo { get; internal set; }
        /// <summary>
        /// 有效期止
        /// </summary>
        public uint EffectTime { get; internal set; }

        /// <summary>
        /// 有效起始
        /// </summary>
        public uint EffectStartTime { get; internal set; }

        public FaceEntity()
        {
            PersonRole = -1;
        }
    }
}
