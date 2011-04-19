
namespace LoVManageLib
{
    public class Card
    {
        private string _name;
        /// <summary>
        /// カード名
        /// </summary>
        public string Name
        {
            private set
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
    }
}
