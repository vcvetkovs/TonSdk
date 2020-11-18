using System.Text.Json;
using TonSdk.Interop.Enums;

namespace TonSdk.Interop.Models
{
    public struct ClientError
    {
        public ErrorCode Code { get; set; }
        public string Message { get; set; }
        public JsonElement Data { get; set; }
    }
}
