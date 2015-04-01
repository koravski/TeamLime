namespace YuGiOh.Interfaces
{
    interface ITrap : ICard
    {
        void ReactToAction(ICard target, IHand playerHand, IHand enemyHand);
    }
}