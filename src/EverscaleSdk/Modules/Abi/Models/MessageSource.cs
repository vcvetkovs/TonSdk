using System.Text.Json.Serialization;
using EverscaleSdk.Common.Converters;

namespace EverscaleSdk.Modules.Abi.Models
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