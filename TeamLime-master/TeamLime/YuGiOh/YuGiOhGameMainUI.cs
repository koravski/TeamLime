namespace YuGiOh
{
    using YuGiOh.Cards;
    using YuGiOh.Cards.Monsters;
    using YuGiOh.Players;
    using System.Collections.Generic;
    using System;
    using System.Threading;
    using System.Globalization;

    public class YuGiOhGameMainUI
    {
        
        public static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            FirstHero playerOne = new FirstHero();
            SecondHero playerTwo = new SecondHero();

            playerOne.DrawPlayCardsFromYuGiOhDeck(7);
            playerTwo.DrawPlayCardsFromYuGiOhDeck(7);


            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("FIRST HERO << 2000 Health >>\n");

            Console.WriteLine("------First Hero cards in hand-------\n");
            playerOne.VisionCardInHand();

            Console.WriteLine("\nSECOND HERO << 2000 Health >>\n");

            Console.WriteLine("\n------Second Hero cards in hand-------\n");
            playerTwo.VisionCardInHand();

        }
      
    }
}
