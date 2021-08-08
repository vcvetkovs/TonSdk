using System.Text.Json.Serialization;
using TonSdk.Common.Converters;

namespace TonSdk.Modules.Abi.Models
{
	public struct ParamsOfDecodeAccountData
    {
        /// <summary>
        ///     Contract ABI.
        /// </summary>
        [JsonConverter(typeof(PolymorphicTypeJsonConverter))]
        public Abi Abi { get; set; }

        /// <summary>
        ///     Data BOC or BOC handle.
        /// </summary>
        public string Data { get; set; }
    }
}
