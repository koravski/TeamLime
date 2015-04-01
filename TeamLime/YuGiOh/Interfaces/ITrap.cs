namespace YuGiOh.Interfaces
{
<<<<<<< HEAD
    public interface ITrap
    {

=======
    interface ITrap : ICard
    {
        void ReactToAction(ICard target, IHand playerHand, IHand enemyHand);
>>>>>>> origin/master
    }
}
