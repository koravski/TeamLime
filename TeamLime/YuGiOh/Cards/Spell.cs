namespace YuGiOh.Cards
{
    using System;
    using YuGiOh.Interfaces;
    using YuGiOh.Misc;

    public  class Spell : Card, ISpell
    {
        private SpellTypes spellType;

        public Spell(string name, SpellTypes spellType, string infoText, string pathToImage)
            : base(name, infoText, pathToImage)
        {
            this.SpellType = spellType;
        }

        public SpellTypes SpellType
        {
            get
            {
                return this.spellType;
            }
            set
            {
                this.spellType = value;
            }
        }

        public void CastAreaOfEffect(IHand playerHand, IHand enemyHand)
        {
            // TODO: Implement this method
            throw new NotImplementedException();
        }

        public void CastSingleTarget(ICard target)
        {
            // TODO: Implement this method
            throw new NotImplementedException();
        }
    }
}