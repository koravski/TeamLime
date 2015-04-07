namespace YuGiOh.Cards
{
    using YuGiOh.Interfaces;

    public  abstract class Trap : Card,ITrap
    {
        private TrapTypes trapType;

        public Trap(TrapTypes trapType, string infoText, string pathToImage)
            : base(infoText, pathToImage)
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