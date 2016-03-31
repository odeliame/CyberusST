using System;

namespace LogicsLayer.LogicExceptions
{
    public class BadNewPasswordException : Exception
    {
        public BadNewPasswordException()
            : base("Your new password doesn't meet the standarts. All passwords in the system must be 8 characters long and include at least one number.")
        {
        }
    }
}
