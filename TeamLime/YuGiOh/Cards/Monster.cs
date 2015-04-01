﻿namespace YuGiOh.Cards
{
    using System;

    public class Monster : Card
    {
        private int attack;
        private int defence;
        private int level;
        private MonsterAttribute attribute;

        public Monster(string name, MonsterAttribute attribute, int attack, int defence, int level, string infoText, string pathToImage)
            : base(name, infoText, pathToImage)
        {
            this.Attack = attack;
            this.Defence = defence;
            this.Level = level;
            this.Attribute = attribute;
        }

        public int Attack
        {
            get
            {
                return this.attack;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Attack must be positive");
                }

                this.attack = value;
            }
        }

        public int Defence
        {
            get
            {
                return this.defence;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Defence must be possitive");
                }

                this.defence = value;
            }
        }

        public int Level 
        {
            get
            {
                return this.level;
            }
            set
            { 
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Card level must be possitive");
                }

                this.level = value;
            }
        }

        public MonsterAttribute Attribute
        {
            get
            {
                return this.attribute;
            }
            set
            {
                this.attribute = value;
            }
        }
    }
}