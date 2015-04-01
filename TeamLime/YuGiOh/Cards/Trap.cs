namespace YuGiOh.Cards
{
    using YuGiOh.Interfaces;

    public  class Trap : Card,ITrap
    {
        private TrapTypes trapType;

        public Trap(string name, TrapTypes trapType, string infoText, string pathToImage)
            : base(name, infoText, pathToImage)
        {
            this.trapType = trapType;
        }

        public TrapTypes Traptype
        {
            get
            {
                return this.trapType;
            }
            set
            {
                this.trapType = value;
            }
        }
    }
}