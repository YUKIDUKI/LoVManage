using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LoVManageLib
{
    /// <summary>
    /// 使い魔カードクラス
    /// </summary>
    class ServantCard : Card
    {
        public ServantCard(string name, uint id)
            : base(name, id)
        {
            this.FieldSkill = new FieldSkill();
            this.SupportSkill = new SupportSkill();
            this.Special = new Special();
        }

        private FieldSkill _fieldSkill;
        /// <summary>
        /// フィールドスキル
        /// </summary>
        public FieldSkill FieldSkill
        {
            set
            {
                if (this._fieldSkill != value)
                {
                    this._fieldSkill = value;
                    OnPropertyChanged("FieldSkill");
                }
            }
            get { return this._fieldSkill; }
        }

        private SupportSkill _supportSkill;
        /// <summary>
        /// サポートスキル
        /// </summary>
        public SupportSkill SupportSkill
        {
            set
            {
                if (this._supportSkill != value)
                {
                    this._supportSkill = value;
                    OnPropertyChanged("SupportSkill");
                }
            }
            get { return this._supportSkill; }
        }

        private Special _special;
        /// <summary>
        /// 特殊技
        /// </summary>
        public Special Special
        {
            set
            {
                if (this._special != value)
                {
                    this._special = value;
                    OnPropertyChanged("Special");
                }
            }
            get { return this._special; }
        }

        private string _no;
        /// <summary>
        /// No
        /// </summary>
        public string No
        {
            set
            {
                if (this._no != value)
                {
                    this._no = value;
                    OnPropertyChanged("No");
                }
            }
            get { return this._no; }
        }

        private Enum.Species _species;
        /// <summary>
        /// 種族
        /// </summary>
        public Enum.Species Species
        {
            set
            {
                if (this._species != value)
                {
                    this._species = value;
                    OnPropertyChanged("Species");
                }
            }
            get { return this._species; }
        }

        private Enum.Rarity _rearity;
        /// <summary>
        /// レアリティ
        /// </summary>
        public Enum.Rarity Rearity
        {
            set
            {
                if (this._rearity != value)
                {
                    this._rearity = value;
                    OnPropertyChanged("Rearity");
                }
            }
            get { return this._rearity; }
        }

        private float _speed;
        /// <summary>
        /// スピード
        /// </summary>
        public float Speed
        {
            set
            {
                if (this._speed != value)
                {
                    this._speed = value;
                    OnPropertyChanged("Speed");
                }
            }
            get { return this._speed; }
        }

        private byte _cost;
        /// <summary>
        /// コスト
        /// </summary>
        public byte Cost
        {
            set
            {
                if (this._cost != value)
                {
                    this._cost = value;
                    OnPropertyChanged("Cost");
                }
            }
            get { return this._cost; }
        }

        private ushort _hp;
        /// <summary>
        /// HP
        /// </summary>
        public ushort HP
        {
            set
            {
                if (this._hp != value)
                {
                    this._hp = value;
                    OnPropertyChanged("HP");
                }
            }
            get { return this._hp; }
        }

        private byte _atk;
        /// <summary>
        /// 攻撃力
        /// </summary>
        public byte ATK
        {
            set
            {
                if (this._atk != value)
                {
                    this._atk = value;
                    OnPropertyChanged("ATK");
                }
            }
            get { return this._atk; }
        }

        private byte _def;
        /// <summary>
        /// 守備力
        /// </summary>
        public byte DEF
        {
            set
            {
                if (this._def != value)
                {
                    this._def = value;
                    OnPropertyChanged("DEF");
                }
            }
            get { return this._def; }
        }

        private Enum.Attribute _attribute;
        /// <summary>
        /// 属性
        /// </summary>
        public Enum.Attribute Attribute
        {
            set
            {
                if (this._attribute != value)
                {
                    this._attribute = value;
                    OnPropertyChanged("Attribute");
                }
            }
            get { return this._attribute; }
        }

        private Enum.AtkStyle _atkStyle;
        /// <summary>
        /// 攻撃形式
        /// </summary>
        public Enum.AtkStyle AtkStyle
        {
            set
            {
                if (this._atkStyle != value)
                {
                    this._atkStyle = value;
                    OnPropertyChanged("AtkStyle");
                }
            }
            get { return this._atkStyle; }
        }

        private Enum.Weakness _weakness;
        /// <summary>
        /// 弱点
        /// </summary>
        public Enum.Weakness Weakness
        {
            set
            {
                if (this._weakness != value)
                {
                    this._weakness = value;
                    OnPropertyChanged("Weakness");
                }
            }
            get { return this._weakness; }
        }

        private string _illust;
        /// <summary>
        /// イラストレータ
        /// </summary>
        public string Illust
        {
            set
            {
                if (this._illust != value)
                {
                    this._illust = value;
                    OnPropertyChanged("Illust");
                }
            }
            get { return this._illust; }
        }

        private Enum.Version _version;
        /// <summary>
        /// バージョン
        /// </summary>
        public Enum.Version Version
        {
            set
            {
                if (this._version != value)
                {
                    this._version = value;
                    OnPropertyChanged("Version");
                }
            }
            get { return this._version; }
        }

        private Nullable<ushort> _characterId;
        /// <summary>
        /// キャラクターID
        /// </summary>
        public Nullable<ushort> CharacterId
        {
            set
            {
                if (this._characterId != value)
                {
                    this._characterId = value;
                    OnPropertyChanged("CharacterId");
                }
            }
            get { return this._characterId; }
        }
    }
}
