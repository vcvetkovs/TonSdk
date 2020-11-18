using System.Text.Json;

namespace TonSdk.Modules.Abi.Models
{
    public struct StateInitParams<T>
    {
        public Abi Abi { get; set; }
        public JsonElement Value { get; set; }
    }
}
