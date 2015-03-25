namespace YuGiOh
{
    using System;
    using YuGiOh.Cards;
    using System.Collections.Generic;
    public abstract class Graveyard
    {
        private List<Card> cardsInGraveyard = new List<Card>();
        private int numberOfCardsInGraveyard;

        public List<Card> CardsInGraveyard
        {
            get
            {
                return this.cardsInGraveyard;
            }
            set
            {
                this.CardsInGraveyard = value;
            }
        }
        public int NumberOfCardsInGraveyard
        {
            get
            {
                return CardsInGraveyard.Count;
            }
        }

        public void SendCardToGraveyard(Card card)
        {
            CardsInGraveyard.Add(card);
        }
        public void RemoveCardFromGraveyard(Card card)
        {
            CardsInGraveyard.Remove(card);
        }
    }
}