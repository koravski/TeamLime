namespace YuGiOh.Cards
{
    public abstract class Trap : Card
    {
        public Trap(string name, string infoText, string pathToImage)
            : base(name, infoText, pathToImage)
        { 
        }
    }
}