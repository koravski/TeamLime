namespace YuGiOh.Cards
{
<<<<<<< HEAD
    using YuGiOh.Interfaces;

    public  class Trap : Card,ITrap
    {
=======
    using System;
    using YuGiOh.Interfaces;
    using YuGiOh.Misc;

    public  class Trap : Card, ITrap
    {        
>>>>>>> origin/master
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

        public void ReactToAction(ICard target, IHand playerHand, IHand enemyHand)
        {
            // TODO: Implement this method
            throw new NotImplementedException();
        }
    }
}