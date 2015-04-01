namespace YuGiOh.Interfaces
{
<<<<<<< HEAD
    using YuGiOh.Cards;
    using System.Collections.Generic;

    interface IDeck
    {
        Card DrawNextCard();

        IList<Card> InitializeYuGiOhCards();
=======
    interface IDeck
    {
        ICard DrawCard();

        void AddCardOnTop(ICard card);

        void Shuffle();
>>>>>>> origin/master

        int CardsLeft();
    }
}
