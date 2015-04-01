using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YuGiOh
{
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
        }
    }
}
