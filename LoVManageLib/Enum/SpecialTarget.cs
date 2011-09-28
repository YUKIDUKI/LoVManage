using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LoVManageLib.Enum
{
    /// <summary>
    /// 特殊技の効果対象
    /// </summary>
    public enum SpecialTarget
    {
        /// <summary>
        /// 単数
        /// </summary>
        SINGLE = 1,
        /// <summary>
        /// 複数
        /// </summary>
        WIDE = 2,
        /// <summary>
        /// 自身
        /// </summary>
        SELF = 3,
        /// <summary>
        /// 施設
        /// </summary>
        FACILITIES = 4,
        /// <summary>
        /// 2体
        /// </summary>
        DOUBLE = 5,
        /// <summary>
        /// その他
        /// </summary>
        OTHER = 6,
        /// <summary>
        /// 主
        /// </summary>
        MASTER = 7
    }
}
