using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LoVManageLib
{
    /// <summary>
    /// フィールドスキルを扱うクラス
    /// </summary>
    public class FieldSkill : NotifyPropertyChangedBase
    {
        public FieldSkill()
        {
            this.Skill1 = LoVManageLib.Enum.FieldSkill.NOTING;
            this.Skill2 = LoVManageLib.Enum.FieldSkill.NOTING;
            this.Skill3 = LoVManageLib.Enum.FieldSkill.NOTING;
        }

        private Enum.FieldSkill _skill1;
        public Enum.FieldSkill Skill1
        {
            set
            {
                if (this._skill1 != value)
                {
                    this._skill1 = value;
                    OnPropertyChanged("Skill1");
                    OnPropertyChanged("HasSkill");
                }
            }
            get { return this._skill1; }
        }

        private Enum.FieldSkill _skill2;
        public Enum.FieldSkill Skill2
        {
            set
            {
                if (this._skill2 != value)
                {
                    this._skill2 = value;
                    OnPropertyChanged("Skill2");
                    OnPropertyChanged("HasSkill");
                }
            }
            get { return this._skill2; }
        }

        private Enum.FieldSkill _skill3;
        public Enum.FieldSkill Skill3
        {
            set
            {
                if (this._skill3 != value)
                {
                    this._skill3 = value;
                    OnPropertyChanged("Skill3");
                    OnPropertyChanged("HasSkill");
                }
            }
            get { return this._skill3; }
        }

        /// <summary>
        /// スキルがあるかどうか
        /// 読み取り専用
        /// </summary>
        public bool HasSkill
        {
            get
            {
                return 
                    (
                    this.Skill1 != LoVManageLib.Enum.FieldSkill.NOTING ||
                    this.Skill2 != LoVManageLib.Enum.FieldSkill.NOTING ||
                    this.Skill3 != LoVManageLib.Enum.FieldSkill.NOTING
                    );
            }
        }
    }
}
