﻿namespace YuGiOh.Interfaces
{
    interface ICard
    {
        string Name { get; set; }

        string InfoText { get; set; }

        string PathToImage { get; set; }
    }
}