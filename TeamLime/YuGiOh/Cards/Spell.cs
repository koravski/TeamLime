namespace YuGiOh.Cards
{
    using YuGiOh.Interfaces;

    public  abstract class Spell : Card,ISpell
    {
        private SpellTypes spellType;

        public Spell(SpellTypes spellType, string infoText, string pathToImage)
            : base(infoText, pathToImage)
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
    }
}