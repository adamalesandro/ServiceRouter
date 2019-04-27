using System;

namespace ServiceRouter.Exceptions
{
    public class DuplicateRegistrationException : Exception
    {
        public DuplicateRegistrationException()
            : base()
        {
        }

        public DuplicateRegistrationException(string message)
            : base(message)
        {
        }

        public DuplicateRegistrationException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}