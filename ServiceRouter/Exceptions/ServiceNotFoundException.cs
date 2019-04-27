using System;

namespace ServiceRouter.Exceptions
{
    public class ServiceNotFoundException : Exception
    {
        public ServiceNotFoundException()
            : base()
        {
        }

        public ServiceNotFoundException(string message)
            : base(message)
        {
        }

        public ServiceNotFoundException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}