using System.Text.Json.Serialization;
using TonSdk.Common.Converters;

namespace TonSdk.Modules.Boc.Models
{
    public struct ParamsOfGetCodeSalt
    {
        /// <summary>
        ///     Contract code BOC encoded as base64 or code BOC handle.
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        ///     Cache type to put the result.
        ///     The BOC itself returned if no cache type provided.
        /// </summary>
        [JsonConverter(typeof(PolymorphicTypeJsonConverter))]
        public BocCacheType BocCache { get; set; }
    }
}
