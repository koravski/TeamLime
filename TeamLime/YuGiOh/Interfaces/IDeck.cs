
namespace YuGiOh.Interfaces
{
    using YuGiOh.Cards;
    using System.Collections.Generic;

    interface IDeck
    {
        Card DrawNextCard();

        IList<Card> InitializeYuGiOhCards();

        int CardsLeft { get; }
    }
}
