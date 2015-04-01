namespace YuGiOh
{
<<<<<<< HEAD
    using YuGiOh.Interfaces;
    using YuGiOh.Extensions;
    using YuGiOh.Cards;

    public class Deck:IDeck
    {

        private IList<Card> allYuGiOhCards;

        public Deck()
        {
            this.allYuGiOhCards = InitializeYuGiOhCards();
        }

        public Cards.Card DrawNextCard()
        {
            throw new NotImplementedException();
        }

        public int CardsLeft
        {
            get { throw new NotImplementedException(); }
        }


        public IList<Card> InitializeYuGiOhCards()
        {
            return new List<Card>
            {
                new Monster("Ekzodia",MonsterAttribute.Dark,10000,200,19,"God","33"),
                new Monster("Ekzodia",MonsterAttribute.Dark,10000,200,19,"God","33"),
                new Monster("Ekzodia",MonsterAttribute.Dark,10000,200,19,"God","33"),
                new Monster("Ekzodia",MonsterAttribute.Dark,10000,200,19,"God","33"),
                new Monster("Ekzodia",MonsterAttribute.Dark,10000,200,19,"God","33"),

            };
=======
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
>>>>>>> origin/master
        }
    }
}
