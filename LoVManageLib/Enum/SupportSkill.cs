using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LoVManageLib.Enum
{
    /// <summary>
    /// サポートスキル
    /// </summary>
    [Flags]
    public enum SupportSkill
    {
        /// <summary>
        /// 無し
        /// </summary>
        NOTING = 0,
        /// <summary>
        /// ゲージ
        /// </summary>
        GAUGE = 1,
        /// <summary>
        /// Wゲージ
        /// </summary>
        W_GAUGE = 2,
        /// <summary>
        /// リジェネ
        /// </summary>
        REGEN = 4,
        /// <summary>
        /// Wリジェネ
        /// </summary>
        W_REGEN = 8,
        /// <summary>
        /// レジスト
        /// </summary>
        RESIST = 16,
        /// <summary>
        /// Wレジスト
        /// </summary>
        W_RESIST = 32,
        /// <summary>
        /// 単スマ
        /// </summary>
        SMASH = 64,
        /// <summary>
        /// W単スマ
        /// </summary>
        W_SMASH = 128,
        /// <summary>
        /// 複スマ
        /// </summary>
        WIDE_SMASH = 256,
        /// <summary>
        /// W複スマ
        /// </summary>
        W_WIDE_SMASH = 512,
        /// <summary>
        /// 散スマ
        /// </summary>
        SPREAD_SMASH = 1024,
        /// <summary>
        /// W散スマ
        /// </summary>
        W_SPREAD_SMASH = 2048

    }
}
