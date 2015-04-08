
//// It should be in its own solution - but for the moment
namespace YuGiOh.Extensions.Helper
{
    using System;

    using System.Linq;

    public abstract class Constants
    {
        public const string CardFilePathMonster = "../CardsPhoto/Monster/";
        public const string CardFilePathSpell = "../CardsPhoto/Spell/";
        public const string CardFilePathTrap = "../CardsPhoto/Trap/";

        public const string CardFileExtension = ".jpg";

        public const string HighScoreFilePath = " ";
        public const string PlayerOneMoves = "../Extensions/PlayersMoves/PlayerOneMoves.txt";
        public const string PlayerTwoMoves = "../Extensions/PlayersMoves/PlayerTwoMoves.txt";

        public const string GameIntro = " ";
        public const string GameBoard = " ";
        public const string GameMenuIntro = " ";
        public const string GameRules = " ";
    }
}
