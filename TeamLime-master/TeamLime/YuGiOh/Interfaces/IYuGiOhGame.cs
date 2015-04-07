namespace YuGiOh.Players
{
    public interface IYuGiOhGame
    {
        void Start();

        int FirstPlayerTotalPoints { get; }

        int SecondPlayerTotalPoints { get; }

    }
}
