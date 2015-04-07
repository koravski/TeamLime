using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YuGiOh
{
    using YuGiOh.Interfaces;
    using YuGiOh.Extensions;
    using YuGiOh.Cards;
    using YuGiOh.Cards.Monsters;
    using YuGiOh.Cards.SpellCards;
    using YuGiOh.Cards.TrapCards;

    public class Deck : IDeck
    {

        private IList<ICard> allYuGiOhCards;

        public Deck()
        {
            this.allYuGiOhCards = InitializeYuGiOhCards();
        }

        public ICard DrawNextCard()
        {
            ICard drawCard = this.allYuGiOhCards[0];
            this.allYuGiOhCards.RemoveAt(0);
            return drawCard;
        }

        public int CardsLeft
        {
            get { return this.allYuGiOhCards.Count(); }
        }


        public IList<ICard> InitializeYuGiOhCards()
        {
            return new List<ICard>
            {
                //Monsters - 15
                new ArchfiendSoldier(),
                new ArchfiendSoldier(),
                new ArchfiendSoldier(),
                new GeminiElf(),
                new GeminiElf(),
                new GeminiElf(),
                new VorseRaider(),
                new VorseRaider(),
                new VorseRaider(),
                new GeneWarpedWarwolf(),
                new GeneWarpedWarwolf(),
                new GeneWarpedWarwolf(),
                new MadDogOfDarkness(),
                new MadDogOfDarkness(),
                new MadDogOfDarkness(),
              
                //Spells - 11
                new DoubleSummon(),
                new DoubleSummon(),
                new Raigeki(),
                new Raigeki(),
                new Raigeki(),
                new PotOfGreed(),
                new PotOfGreed(),
                new SwordsOfRevealingLight(),
                new SwordsOfRevealingLight(),
                new MysticalSpaceTyphoon(),
                new LightningVortex(),
               
                //Traps -15
               new MirrorForce(),
               new MirrorForce(),
               new MirrorForce(),
               new DivineWrath(),
               new DivineWrath(),
               new DivineWrath(),
               new WallOfRevealingLight(),
               new WallOfRevealingLight(),
               new WallOfRevealingLight(),
               new NegateAttack(),
               new NegateAttack(),
               new NegateAttack()
            };
        }
    }
}
