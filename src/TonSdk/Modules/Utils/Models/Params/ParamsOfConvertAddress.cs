using System.Text.Json.Serialization;
using TonSdk.Common.Converters;

namespace TonSdk.Modules.Utils.Models
{
    public struct ParamsOfConvertAddress
    {
        /// <summary>
        ///     Account address in any TON format.
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        ///     Specify the format to convert to.
        /// </summary>
        [JsonConverter(typeof(PolymorphicTypeJsonConverter))]
        public AddressStringFormat OutputFormat { get; set; }
    }
}
