using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YuGiOh.Engine
{
    using Extensions;
    using YuGiOh.Players;

    public class FieldManager: IFieldManager
    {
        private FirstHero playerOne;
        private SecondHero playerTwo;
        private BattleField battlefield;

        public FieldManager(FirstHero playerOne, SecondHero playerTwo)
        {
            this.playerOne = playerOne;
            this.playerTwo = playerTwo;
            this.battlefield = new BattleField();
        }

        public void Attack(CardId atackingCard, Extensions.CardId defendingCard)
        {
            throw new NotImplementedException();
        }

        public void Play(CardId atackingCard)
        {
            string cardName = atackingCard.CardName;
            PlayerIndentifier choosenPlayer = atackingCard.PlayerIdentifier;

            if ((int)choosenPlayer == 1)
            {
                foreach (var card in playerOne.YuGiOhCardInHand)
                {
                    if (card.GetType().Name == cardName)
                    {
                        playerOne.SendCardToField(card);
                        this.battlefield.cardsOnField.Add(card);
                    }
                }
            }
            else
            {
                foreach (var card in playerTwo.YuGiOhCardInHand)
                {
                    if (card.GetType().Name == cardName)
                    {
                        playerTwo.SendCardToField(card);
                        this.battlefield.cardsOnField.Add(card);
                    }
                }
            }
            
        }

        public void Switch(CardId atackingCard)
        {
            throw new NotImplementedException();
        }
    }
}
