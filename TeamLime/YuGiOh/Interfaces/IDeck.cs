
namespace YuGiOh.Interfaces
{
    using YuGiOh.Cards;

    interface IDeck
    {
        Card DrawCard();

        int CardsLeft { get; }
    }
}
