namespace YuGiOh.Interfaces
{
<<<<<<< HEAD
    public interface ISpell
    {

=======
    interface ISpell : ICard
    {
        void CastAreaOfEffect(IHand playerHand, IHand enemyHand);

        void CastSingleTarget(ICard target);
>>>>>>> origin/master
    }
}
