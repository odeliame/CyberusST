using System;

namespace LogicsLayer.LogicExceptions
{
    public class OldDoesntMatchException : Exception
    {
        public OldDoesntMatchException()
            : base("Your old password doesn't match your new ones.")
        {
        }
    }
}
