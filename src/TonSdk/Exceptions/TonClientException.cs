using System;

namespace TonSdk.Exceptions
{
    public class TonClientException : Exception
    {
        public TonClientException(string message) : base(message) {}
    }
}
