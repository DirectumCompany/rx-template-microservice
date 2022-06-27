using System;

namespace CustomWebAPI.IntegrationServicesClient.Exceptions
{
    public class FoundMatchesException : Exception
    {
        public FoundMatchesException(string message) : base(message) { }
    }
}
