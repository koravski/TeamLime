namespace YuGiOh.Cards
{
    using System;
    using System.Collections.Generic;

    using YuGiOh.Interfaces;

    class Deck: IDeck
    {
        private IList<Card> yoGiOhCards;

        public Card DrawCard()
        {
            throw new NotImplementedException();
        }

        public int CardsLeft
        {
            get { throw new NotImplementedException(); }
        }
    }
}