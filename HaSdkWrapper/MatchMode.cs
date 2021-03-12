using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HaSdkWrapper
{
    /// <summary>
    /// 比对模式
    /// </summary>
    public enum MatchMode
    {

        /// <summary>
        /// 未初始化
        /// </summary>
        MATCH_MODE_NULL = 0,

        /// <summary>
        /// 刷脸+白名单开闸
        /// </summary>
        MATCH_MODE_NORMAL = 1,

        /// <summary>
        /// 刷脸+刷身份证开闸
        /// </summary>
        MATCH_MODE_IDCARD_1TO1 = 2,

        /// <summary>
        /// 刷脸+刷身份证+白名单开闸
        /// </summary>
        MATCH_MODE_FACE_IDCARD = 3,

        /// <summary>
        /// 刷卡+白名单开闸
        /// </summary>
        MATCH_MODE_WGCARD = 4,

        /// <summary>
        /// 刷脸+刷卡+白名单开闸
        /// </summary>
        MATCH_MODE_FACE_WGCARD = 5,

        /// <summary>
        /// 过人开闸
        /// </summary>
        MATCH_MODE_ANY_FACE = 6,

        /// <summary>
        /// 刷脸+白名单开闸或者刷卡+白名单开闸
        /// </summary>
        MATCH_MODE_NORMAL_OR_WGCARD = 7,

         /// <summary>
        /// /*! 对应--刷脸或刷身份证。 */
         /// </summary>
	MATCH_MODE_NORMAL_OR_IDCARD_1TO1 = 8,

	/// <summary>
    /// /*! 对应--刷脸或RFID全景快照。 */
	/// </summary>
	MATCH_MODE_NORMAL_OR_SNAPSHOT    = 20
    }
}
