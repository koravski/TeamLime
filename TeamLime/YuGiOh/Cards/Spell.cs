namespace YuGiOh.Cards
{
    public abstract class Spell : Card
    {
        public Spell(string name, string infoText, string pathToImage)
            : base(name, infoText, pathToImage)
        { 
        }
    }
}