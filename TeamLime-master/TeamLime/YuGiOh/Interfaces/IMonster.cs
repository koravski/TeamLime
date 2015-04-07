namespace YuGiOh.Players
{
    interface IMonster
    {
        int Attack { get; set; }

        int Defence { get; set; }

        int Level { get; set; }

        Cards.MonsterAttribute Attribute { get; set; }
    }
}