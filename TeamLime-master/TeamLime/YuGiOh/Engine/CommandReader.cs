namespace YuGiOh.Engine
{
    using System;
    using System.Globalization;
    using System.Linq;

    using YuGiOh.Extensions;
    using YuGiOh.Players;

    class CommandReader : ICommandReader
    {
        // направих структ който да ползваме за идентификация на картите по име и собственик, така ше ги подаваме между енджина и инпута
        // ще ти ги подавам така и ти ще ги търсиш в енджина на борда, защото иначе ще се вържа към енджина, а мисля че не е добре.
        // направих и още един енум за плейърите
        // командите са във формат :
        //  attack ИмеНаКАрта(собственик-цифра) ИмеНаКАрта(собственик-цифра)
        //  play ИмеНаКАрта(собственик-цифра)
        //  switch ИмеНаКАрта(собственик-цифра)

        // също така мисля че трябва да извадиш CommandReader от енджина, трябва да я разделим на три:
        // input, engine и output и да са възможно най-независими
        // премести ги в друга папка, consoleReader или там каквото ти се стори подходящо

        private readonly string[] possibleComands = new string[] { "play", "attack", "switch" };

        public void RunCommand(BattleManager battleManager, string commandString)
        {      
            if (commandString == null)
            {
                throw new ArgumentNullException("no command");
            }            

            ProcessCommand(battleManager, commandString);
        }

        private void ProcessCommand(BattleManager battleManager, string commandString)
        {
            var commandSplitters = new char[] { ' ', '(', ')' };
            var commandArguments = commandString.Split(commandSplitters, StringSplitOptions.RemoveEmptyEntries);
            var command = commandArguments[0];
            if (!this.possibleComands.Contains(command))
            {
                throw new ArgumentException(string.Format("Invalid command name \"{0}\"", command));
            }

            if (command == "play")
            {
                ProcessPlayCommand(battleManager, commandArguments.Skip(1).ToArray());
            }
            else if (command == "attack")
            {
                ProcessAttackCommand(battleManager, commandArguments.Skip(1).ToArray());
            }
            
            else if (command == "switch")
            {
                ProcessSwitchCommand(battleManager, commandArguments.Skip(1).ToArray());
            }
        }

        private void ProcessPlayCommand(BattleManager battleManager, string[] commandArguments)
        {
            CardId cardToPlay = new CardId(commandArguments[0], (PlayerIndentifier)int.Parse(commandArguments[1]));

            battleManager.Play(cardToPlay);
        }

        private void ProcessAttackCommand(BattleManager battleManager, string[] commandArguments)
        {
            if (battleManager == null)
            {
                throw new ArgumentNullException("battleManager");
            }

            if (commandArguments == null)
            {
                throw new ArgumentNullException(" no arguments");
            }

            if (commandArguments.Length < 4)
            {
                throw new ArgumentException("Invalid number of arguments for attack command");
            }

            CardId atackingCard = new CardId(commandArguments[0], (PlayerIndentifier)int.Parse(commandArguments[1]));
            CardId defendingCard = new CardId(commandArguments[2], (PlayerIndentifier)int.Parse(commandArguments[3]));

            battleManager.Attack(atackingCard, defendingCard);
        }

        private void ProcessSwitchCommand(BattleManager battleManager, string[] commandArguments)
        {
            CardId cardToSwitch = new CardId(commandArguments[0], (PlayerIndentifier)int.Parse(commandArguments[1]));

            battleManager.Switch(cardToSwitch);
        }     
    }
}