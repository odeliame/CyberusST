using System;

namespace LogicsLayer.LogicExceptions
{
    public class NewDoesntMatchException : Exception
    {
        public NewDoesntMatchException()
            : base("Your second password doesn't match the first")
        {
        }
    }
}
