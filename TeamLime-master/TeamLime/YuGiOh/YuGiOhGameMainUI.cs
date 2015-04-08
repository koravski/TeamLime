namespace YuGiOh
{
    using System;
    using System.Threading;
    using System.Globalization;

    using YuGiOh.Cards;
    using YuGiOh.Engine;
    using YuGiOh.Cards.Monsters;
    using YuGiOh.Players;
    using System.Collections.Generic;
    using YuGiOh.Extensions.Helper;

    public class YuGiOhGameMainUI
    {       
        public static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Constants.GameSound(Constants.PlaySound);

            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("Enter name of first player:\n");
            FirstHero playerOne = new FirstHero(YuGiOhGameMainUI.EnterName());
            Console.Clear();

            Console.WriteLine("Enter name of second player:\n");
            SecondHero playerTwo = new SecondHero(YuGiOhGameMainUI.EnterName());

            playerOne.DrawPlayCardsFromYuGiOhDeck(7);
            playerTwo.DrawPlayCardsFromYuGiOhDeck(7);

            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("HERO {0} << 2000 Health >>\n",playerOne.Name);

            Console.WriteLine("------First Hero cards in hand-------\n");
            playerOne.VisionCardInHand();

            Console.WriteLine("\nHERO {0} << 2000 Health >>\n", playerTwo.Name);

            Console.WriteLine("\n------Second Hero cards in hand-------\n");
            playerTwo.VisionCardInHand();

            // Processing commands
            ICommandReader commandReader = new CommandReader();

            // Processing actions on the field
            FieldManager fieldManager = new FieldManager();
            
            
            while (true)
            {
                var commandLine = Console.ReadLine();
                commandReader.RunCommand(fieldManager, commandLine);

                playerOne.DrawNextCardInHand();
                playerTwo.DrawNextCardInHand();

                if (playerOne.GeneralHealth <= 0 || playerOne.YuGiOhCardInHand.Count == 0 )
                {
                    Console.WriteLine("{0} is destoyed!/n------GAME OVER-----", playerOne.Name);
                }
                if (playerTwo.GeneralHealth <= 0 || playerTwo.YuGiOhCardInHand.Count == 0)
                {
                    Console.WriteLine("{0} is destoyed!/n------GAME OVER-----", playerTwo.Name);

                }
            }
        }

        public static string EnterName()
        {
            string name = string.Empty;
            name = Console.ReadLine();

            while (string.IsNullOrEmpty(name) || name.Length < 2 || name.Length > 25)
            {
                Console.WriteLine("Too strange name! Try again.");
                name = Console.ReadLine();
            }

            return name;
        }
      
    }
}
