﻿namespace YuGiOh.Extensions
{
    struct CardId
    {
        public string CardName;
        public PlayerIndentifier PlayerIdentifier;

        public CardId(string cardName, PlayerIndentifier playerIdentifier)
        {
            this.CardName = cardName;
            this.PlayerIdentifier = playerIdentifier;
        }
    }
}