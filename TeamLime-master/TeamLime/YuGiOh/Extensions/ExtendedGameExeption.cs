namespace YuGiOh
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
