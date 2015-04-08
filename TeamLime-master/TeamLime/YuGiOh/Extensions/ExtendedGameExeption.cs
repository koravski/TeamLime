namespace YuGiOh.Extensions
{
    using System;

    public class ExtendedGameExeption : ApplicationException
    {
        public ExtendedGameExeption(string message)
            : base(message)
        {

        }
    }
}
