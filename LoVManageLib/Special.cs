using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LoVManageLib
{
    /// <summary>
    /// 特殊技クラス
    /// </summary>
    public class Special
    {
        private string _name;
        /// <summary>
        /// 特殊技名
        /// </summary>
        public string Name
        {
            set
            {
                if (this._name != value)
                    this._name = value;
            }
            get { return this._name; }
        }

        private Enum.SpecialTarget _target;
        /// <summary>
        /// 効果対象
        /// </summary>
        public Enum.SpecialTarget Target
        {
            set
            {
                if (this._target != value)
                    this._target = value;
            }
            get { return this._target; }
        }

        private Enum.SpecialType _type;
        /// <summary>
        /// 特殊技種別
        /// </summary>
        public Enum.SpecialType Type
        {
            set
            {
                if (this._type != value)
                    this._type = value;
            }
            get { return this._type; }
        }

        private string _text1;
        /// <summary>
        /// テキスト1
        /// </summary>
        public string Text1
        {
            set
            {
                if (this._text1 != value)
                    this._text1 = value;
            }
            get { return this._text1; }
        }

        private string _text2;
        /// <summary>
        /// テキスト2
        /// </summary>
        public string Text2
        {
            set
            {
                if (this._text2 != value)
                    this._text2 = value;
            }
            get { return this._text2; }
        }
    }
}
