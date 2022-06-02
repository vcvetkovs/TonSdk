using System;

namespace EverscaleSdk.Exceptions
{
    public class EverscaleClientException : Exception
    {
        public EverscaleClientException(string message) : base(message) {}
    }
}
