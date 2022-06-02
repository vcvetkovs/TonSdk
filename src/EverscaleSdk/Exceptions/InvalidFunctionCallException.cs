using System;
using System.Text.Json;
using EverscaleSdk.Interop.Enums;

namespace EverscaleSdk.Exceptions
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
