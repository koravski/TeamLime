namespace YuGiOh
{
    using YuGiOh.Cards;
    using System.Collections.Generic;
    using System;

    public class CardFactory
    {
        public static void Main()
        {
            Monster ekzodia = new Monster("ekzodiq",MonsterAttribute.Dark,1000,200,10,"GOd","dsfsf");
            Spell mirror = new Spell("mirror",SpellTypes.Normal,"ggg","434");

            var deck = new List<Card>{ekzodia, mirror};
        }
    }
}
