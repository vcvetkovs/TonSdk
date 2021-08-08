using System.Text.Json.Serialization;
using TonSdk.Common.Converters;

namespace TonSdk.Modules.Abi.Models
{
    public abstract class MessageSource
    {
        public class Encoded : MessageSource
        {
            public string Message { get; set; }

            [JsonConverter(typeof(PolymorphicTypeJsonConverter))]
            public Abi Abi { get; set; }
        }

        public ParamsOfEncodeMessage EncodingParams { get; set; }
    }
}