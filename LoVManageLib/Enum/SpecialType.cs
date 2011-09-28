using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LoVManageLib.Enum
{
    /// <summary>
    /// 特殊技種別
    /// </summary>
    public enum SpecialType
    {
        /// <summary>
        /// 攻撃
        /// </summary>
        ATTACK = 1,
        /// <summary>
        /// 強化
        /// </summary>
        STRENGTHENING = 2,
        /// <summary>
        /// 解除
        /// </summary>
        CANCEL = 3,
        /// <summary>
        /// 回復
        /// </summary>
        HEAL = 4,
        /// <summary>
        /// 移動
        /// </summary>
        MOVE = 5,
        /// <summary>
        /// 罠
        /// </summary>
        TRAP = 6,
        /// <summary>
        /// 妨害
        /// </summary>
        DISTURB = 7,
        /// <summary>
        /// 特殊
        /// </summary>
        SPECIAL = 8,
        /// <summary>
        /// 弱体
        /// </summary>
        WEAK = 9
    }
}
