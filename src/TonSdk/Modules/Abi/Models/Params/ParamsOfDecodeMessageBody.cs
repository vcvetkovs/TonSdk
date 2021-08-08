using System.Text.Json.Serialization;
using TonSdk.Common.Converters;

namespace TonSdk.Modules.Abi.Models
{
    public struct ParamsOfDecodeMessageBody
    {
        /// <summary>
        ///     Contract ABI used to decode.
        /// </summary>
        [JsonConverter(typeof(PolymorphicTypeJsonConverter))]
        public Abi Abi { get; set; }

        /// <summary>
        ///     Message body BOC encoded in <c>base64</c>.
        /// </summary>
        public string Body { get; set; }

        /// <summary>
        ///     True if the body belongs to the internal message.
        /// </summary>
        public bool IsInternal { get; set; }
    }
}
