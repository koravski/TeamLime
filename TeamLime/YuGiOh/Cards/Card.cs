namespace YuGiOh.Cards
{
    using System;

    public abstract class Card
    {
        private string name;
        private string infoText;
        private string pathToImage;

        public Card(string name, string infoText, string pathToImage)
        {
            this.Name = name;
            this.InfoText = infoText;
            this.PathToImage = pathToImage;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("The card must have a name");
                }
                this.name = value;
            }
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