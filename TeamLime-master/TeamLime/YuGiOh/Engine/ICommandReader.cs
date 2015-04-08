namespace YuGiOh.Engine
{
    using System;

    public interface ICommandReader
    {
        void RunCommand(BattleManager battleManager, string command);
    }
}
