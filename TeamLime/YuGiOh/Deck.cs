namespace YuGiOh
{
    using System;
    using System.Collections.Generic;

    using YuGiOh.Interfaces;

    public class Deck : IDeck
    {
        private readonly IList<ICard> theDeck = new List<ICard>();

        public ICard DrawCard()
        {
            var topCard = this.theDeck[0];
            this.theDeck.RemoveAt(0);
            return topCard;
        }

        public void AddCardOnTop(ICard card)
        {
            this.theDeck.Insert(0, card);
        }

        public void Shuffle()
        {

            // TODO: Implement this method
            throw new NotImplementedException();
        }
        public int CardsLeft()
        {
            // TODO: Implement this method
            throw new NotImplementedException();
        }
    }
}