
namespace LoVManageLib
{
    public class Card
    {
        private uint _id;
        /// <summary>
        /// ID
        /// </summary>
        public uint Id
        {
            set
            {
                if (this._id != value)
                    this._id = value;
            }
            get { return this._id; }
        }
        private string _name;
        /// <summary>
        /// カード名
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

        public Card(string name)
        {
            this.Name = name;
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
                    this._no = value;
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
                    this._species = value;
            }
            get { return this._species; }
        }
    }
}
