using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LoVManageLib
{
    /// <summary>
    /// サポートスキルを扱うクラス
    /// </summary>
    public class SupportSkill
    {
        public SupportSkill()
        {
            this.Skill1 = LoVManageLib.Enum.SupportSkill.NOTING;
            this.Skill2 = LoVManageLib.Enum.SupportSkill.NOTING;
        }

        private Enum.SupportSkill _skill1;
        public Enum.SupportSkill Skill1
        {
            set
            {
                if (this._skill1 != value)
                    this._skill1 = value;
            }
            get { return this._skill1; }
        }

        private Enum.SupportSkill _skill2;
        public Enum.SupportSkill Skill2
        {
            set
            {
                if (this._skill2 != value)
                    this._skill2 = value;
            }
            get { return this._skill2; }
        }

        public bool HasSkill
        {
            get
            {
                return
                (
                this.Skill1 != LoVManageLib.Enum.SupportSkill.NOTING ||
                this.Skill2 != LoVManageLib.Enum.SupportSkill.NOTING
                );
            }
        }
    }
}
