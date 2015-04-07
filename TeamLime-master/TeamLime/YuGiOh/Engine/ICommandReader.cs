namespace YuGiOh.Engine
{
    public interface  ICommandReader
    {
        void RunCommand(BattleManager battleManager, string command);
    }
}