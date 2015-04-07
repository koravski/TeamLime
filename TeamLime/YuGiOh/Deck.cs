using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YuGiOh
{
    using YuGiOh.Interfaces;
    using YuGiOh.Extensions;
    using YuGiOh.Cards;

    public class Deck : IDeck
    {

        private IList<Card> allYuGiOhCards;

        public Deck()
        {
            this.allYuGiOhCards = InitializeYuGiOhCards();
        }

        public Cards.Card DrawNextCard()
        {
            Card drawCard = this.allYuGiOhCards[0];
            this.allYuGiOhCards.RemoveAt(0);
            return drawCard;
        }

        public int CardsLeft
        {
            get { return this.allYuGiOhCards.Count(); }
        }


        public IList<Card> InitializeYuGiOhCards()
        {
            return new List<Card>
            {
                //Monsters - 15
                new Monster("Archfiend Soldier", MonsterAttribute.Dark, 1900, 1500, 4, "An expert at battle who belongs to a crack diabolical unit. He's famous because he always gets the job done.", "../../CardsPhoto/Monster/ArchfiendSoldier.jpg"),
                new Monster("Archfiend Soldier", MonsterAttribute.Dark, 1900, 1500, 4, "An expert at battle who belongs to a crack diabolical unit. He's famous because he always gets the job done.", "../../CardsPhoto/Monster/ArchfiendSoldier.jpg"),
                new Monster("Archfiend Soldier", MonsterAttribute.Dark, 1900, 1500, 4, "An expert at battle who belongs to a crack diabolical unit. He's famous because he always gets the job done.", "../../CardsPhoto/Monster/ArchfiendSoldier.jpg"),
                new Monster("Gemini Elf", MonsterAttribute.Earth, 1900, 900, 4, "Elf twins that alternate their attacks.","../../CardsPhoto/Monster/GeminiElf.jpg"),
                new Monster("Gemini Elf", MonsterAttribute.Earth, 1900, 900, 4, "Elf twins that alternate their attacks.","../../CardsPhoto/Monster/GeminiElf.jpg"),
                new Monster("Gemini Elf", MonsterAttribute.Earth, 1900, 900, 4, "Elf twins that alternate their attacks.","../../CardsPhoto/Monster/GeminiElf.jpg"),
                new Monster("Vorse Raider", MonsterAttribute.Dark, 1900, 1200, 19, "This wicked Beast-Warrior does every horrid thing imaginable, and loves it! His axe bears the marks of his countless victims.", "../../CardsPhoto/Monster/VorseRaider.jpg"),
                new Monster("Vorse Raider", MonsterAttribute.Dark, 1900, 1200, 19, "This wicked Beast-Warrior does every horrid thing imaginable, and loves it! His axe bears the marks of his countless victims.", "../../CardsPhoto/Monster/VorseRaider.jpg"),
                new Monster("Vorse Raider", MonsterAttribute.Dark, 1900, 1200, 19, "This wicked Beast-Warrior does every horrid thing imaginable, and loves it! His axe bears the marks of his countless victims.", "../../CardsPhoto/Monster/VorseRaider.jpg"),
                new Monster("Gene-Warped Warwolf", MonsterAttribute.Dark, 2000, 100, 4, "This warwolf was given incalculable strength through horrific genetic manipulation. Its gentle nature was completely wiped out, and it now lives only to unleash destruction.", "../../CardsPhoto/Monster/GeneWarpedWarwolf.jpg"),
                new Monster("Gene-Warped Warwolf", MonsterAttribute.Dark, 2000, 100, 4, "This warwolf was given incalculable strength through horrific genetic manipulation. Its gentle nature was completely wiped out, and it now lives only to unleash destruction.", "../../CardsPhoto/Monster/GeneWarpedWarwolf.jpg"),
                new Monster("Gene-Warped Warwolf", MonsterAttribute.Dark, 2000, 100, 4, "This warwolf was given incalculable strength through horrific genetic manipulation. Its gentle nature was completely wiped out, and it now lives only to unleash destruction.", "../../CardsPhoto/Monster/GeneWarpedWarwolf.jpg"),
                new Monster("Mad Dog of Darkness", MonsterAttribute.Dark, 1900, 1400, 4, "He used to be a normal dog who played around in a park, but was corrupted by the powers of darkness.", "../../CardsPhoto/Monster/MadDogofDarkness.jpg"),
                new Monster("Mad Dog of Darkness", MonsterAttribute.Dark, 1900, 1400, 4, "He used to be a normal dog who played around in a park, but was corrupted by the powers of darkness.", "../../CardsPhoto/Monster/MadDogofDarkness.jpg"),
                new Monster("Mad Dog of Darkness", MonsterAttribute.Dark, 1900, 1400, 4, "He used to be a normal dog who played around in a park, but was corrupted by the powers of darkness.", "../../CardsPhoto/Monster/MadDogofDarkness.jpg"),
              
                //Spells - 11
                new Spell("Double Summon", SpellTypes.Normal, "You can conduct 2 Normal Summons/Sets this turn, not just 1.", "../../CardsPhoto/Spell/DoubleSummon.jpg"),
                new Spell("Double Summon", SpellTypes.Normal, "You can conduct 2 Normal Summons/Sets this turn, not just 1.", "../../CardsPhoto/Spell/DoubleSummon.jpg"),
                new Spell("Raigeki", SpellTypes.Normal, "Destroy all monsters your opponent controls.", "../../CardsPhoto/Spell/Raigeki.jpg"),
                new Spell("Raigeki", SpellTypes.Normal, "Destroy all monsters your opponent controls.", "../../CardsPhoto/Spell/Raigeki.jpg"),
                new Spell("Raigeki", SpellTypes.Normal, "Destroy all monsters your opponent controls.", "../../CardsPhoto/Spell/Raigeki.jpg"),
                new Spell("Pot of Greed", SpellTypes.Normal, "Draw 2 cards.", "../../CardsPhoto/Spell/PotofGreed.jpg"),
                new Spell("Pot of Greed", SpellTypes.Normal, "Draw 2 cards.", "../../CardsPhoto/Spell/PotofGreed.jpg"),
                new Spell("Swords of Revealing Light", SpellTypes.Normal, "Flip all monsters your opponent controls face-up. This card remains on the field for 3 of your opponent's turns. While this card is face-up on the field, monsters your opponent controls cannot declare an attack.", "../../CardsPhoto/Spell/SwordsofRevealingLight.jpg"),
                new Spell("Swords of Revealing Light", SpellTypes.Normal, "Flip all monsters your opponent controls face-up. This card remains on the field for 3 of your opponent's turns. While this card is face-up on the field, monsters your opponent controls cannot declare an attack.", "../../CardsPhoto/Spell/SwordsofRevealingLight.jpg"),
                new Spell("Mystical Space Typhoon", SpellTypes.QuickPlay, "Target 1 Spell/Trap Card on the field; destroy that target.", "../../CardsPhoto/Spell/MysticalSpaceTyphoon.jpg"),
                new Spell("Lightning Vortex", SpellTypes.Normal, "Discard 1 card; destroy all face-up monsters your opponent controls.", "../../CardsPhoto/Spell/LightningVortex.jpg"),
               
                //Traps -15
                new Trap("Mirror Force", TrapTypes.Normal, "When an opponent's monster declares an attack: Destroy all Attack Position monsters your opponent controls.", "../../CardsPhoto/Trap/MirrorForce.jpg"),
                new Trap("Mirror Force", TrapTypes.Normal, "When an opponent's monster declares an attack: Destroy all Attack Position monsters your opponent controls.", "../../CardsPhoto/Trap/MirrorForce.jpg"),
                new Trap("Mirror Force", TrapTypes.Normal, "When an opponent's monster declares an attack: Destroy all Attack Position monsters your opponent controls.", "../../CardsPhoto/Trap/MirrorForce.jpg"),
                new Trap("Divine Wrath", TrapTypes.Counter, "When a monster effect is activated: Discard 1 card; negate the activation, and if you do, destroy that monster.", "../../CardsPhoto/Trap/DivineWrath.jpg"),
                new Trap("Divine Wrath", TrapTypes.Counter, "When a monster effect is activated: Discard 1 card; negate the activation, and if you do, destroy that monster.", "../../CardsPhoto/Trap/DivineWrath.jpg"),
                new Trap("Divine Wrath", TrapTypes.Counter, "When a monster effect is activated: Discard 1 card; negate the activation, and if you do, destroy that monster.", "../../CardsPhoto/Trap/DivineWrath.jpg"),
                new Trap("Wall of Revealing Light", TrapTypes.Continuous, "Activate by paying any multiple of 1000 Life Points. Monsters your opponent controls cannot attack if their ATK is less than or equal to the amount you paid.", "../../CardsPhoto/Trap/WallofRevealingLight.jpg"),
                new Trap("Wall of Revealing Light", TrapTypes.Continuous, "Activate by paying any multiple of 1000 Life Points. Monsters your opponent controls cannot attack if their ATK is less than or equal to the amount you paid.", "../../CardsPhoto/Trap/WallofRevealingLight.jpg"),
                new Trap("Wall of Revealing Light", TrapTypes.Continuous, "Activate by paying any multiple of 1000 Life Points. Monsters your opponent controls cannot attack if their ATK is less than or equal to the amount you paid.", "../../CardsPhoto/Trap/WallofRevealingLight.jpg"),
                new Trap("Negate Attack", TrapTypes.Counter, "Activate only when a target opponent's monster declares an attack. Negate the attack and end the Battle Phase.", "../../CardsPhoto/Trap/NegateAttack.jpg"),
                new Trap("Negate Attack", TrapTypes.Counter, "Activate only when a target opponent's monster declares an attack. Negate the attack and end the Battle Phase.", "../../CardsPhoto/Trap/NegateAttack.jpg"),
                new Trap("Negate Attack", TrapTypes.Counter, "Activate only when a target opponent's monster declares an attack. Negate the attack and end the Battle Phase.", "../../CardsPhoto/Trap/NegateAttack.jpg"),
            };
        }
    }
}
