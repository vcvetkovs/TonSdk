using System;
using System.Text.Json;
using TonSdk.Interop.Enums;

namespace TonSdk.Exceptions
{
    public class InvalidFunctionCallException : Exception
    {
        public InvalidFunctionCallException(string message, ErrorCode code, JsonElement errorData)
            : base(message)
        {
            Code = code;
            ErrorData = errorData;
        }

        public ErrorCode Code { get; }

        public object ErrorData { get; }
    }
}
