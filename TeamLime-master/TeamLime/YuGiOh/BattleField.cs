namespace YuGiOh
{
    using System;
    using System.Collections.Generic;
    using YuGiOh.Players;

    using YuGiOh.Interfaces;

    public class BattleField
    {
        IList<ICard> cardsOnField;

        public BattleField()
        {
            this.cardsOnField = new List<ICard>();
        }
    }
}
