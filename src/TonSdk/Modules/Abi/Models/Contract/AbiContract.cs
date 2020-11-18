using System.Text.Json.Serialization;

namespace TonSdk.Modules.Abi.Models
{
    public class AbiContract
    {
        [JsonPropertyName("ABI version")]
        public uint? ABIVersion { get; set; }

        public string[] Header { get; set; }

        public AbiFunction[] Functions { get; set; }

        public AbiEvent[] Events { get; set; }

        public AbiData[] Data { get; set; }
    }
}
