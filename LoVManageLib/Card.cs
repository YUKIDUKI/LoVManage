
namespace LoVManageLib
{
    /// <summary>
    /// カード基本クラス
    /// </summary>
    public class Card
    {
       public Card(string name, uint id)
        {
            this.Name = name;
        }


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

    }
}
