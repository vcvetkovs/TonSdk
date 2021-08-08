using System.Text.Json.Serialization;
using TonSdk.Common.Converters;

namespace TonSdk.Modules.Abi.Models
{
    public struct ParamsOfDecodeMessage
    {
        /// <summary>
        ///     Contract ABI.
        /// </summary>
        [JsonConverter(typeof(PolymorphicTypeJsonConverter))]
        public Abi Abi { get; set; }

        /// <summary>
        ///     Message BOC.
        /// </summary>
        public string Message { get; set; }
    }
}
