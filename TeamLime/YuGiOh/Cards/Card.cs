namespace YuGiOh.Cards
{
    using System;
    using YuGiOh.Interfaces;

    public abstract class Card : ICard
    {
        private string infoText;
        private string pathToImage;

        public Card(string infoText, string pathToImage)
        {
            this.InfoText = infoText;
            this.PathToImage = pathToImage;
        }
        public string InfoText
        {
            get
            {
                return this.infoText;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("The card must have info text");
                }

                this.infoText = value;
            }
        }

        public string PathToImage
        {
            get
            {
                return this.pathToImage;
            }
            set
            {
                this.pathToImage = value;
            }
        }
    }
}