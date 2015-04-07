namespace YuGiOh.Players
{
    using YuGiOh.Cards;

    public interface IGraveyard
    {
       void SendCardToGraveyard(Card card);

       void RemoveCardFromGraveyard(Card card);
    }
}
