namespace YuGiOh.Interfaces
{
    interface IDeck
    {
        ICard DrawCard();

        void AddCardOnTop(ICard card);

        void Shuffle();

        int CardsLeft();
    }
}