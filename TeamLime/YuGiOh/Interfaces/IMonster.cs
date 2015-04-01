namespace YuGiOh.Interfaces
{
    using YuGiOh.Misc;

    interface IMonster : ICard
    {
        int Attack { get; set; }

        int Defence { get; set; }

        int Level { get; set; }

        MonsterAttribute Attribute { get; set; }

        void ProcessInteraction(IMonster enemy);
    }
}