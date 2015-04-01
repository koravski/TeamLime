namespace YuGiOh.Cards
{
    public abstract class Spell : Card
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
    }
}