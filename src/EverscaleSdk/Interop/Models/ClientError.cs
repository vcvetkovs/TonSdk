using System.Text.Json;
using EverscaleSdk.Interop.Enums;

namespace EverscaleSdk.Interop.Models
{
    public struct ClientError
    {
        public ErrorCode Code { get; set; }
        public string Message { get; set; }
        public JsonElement Data { get; set; }
    }
}
