namespace YuGiOh.Interfaces
{
    interface ISpell : ICard
    {
        void CastAreaOfEffect(IHand playerHand, IHand enemyHand);

        void CastSingleTarget(ICard target);
    }
}