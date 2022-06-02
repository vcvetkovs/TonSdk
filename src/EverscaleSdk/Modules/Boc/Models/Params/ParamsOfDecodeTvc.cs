using System.Text.Json.Serialization;
using EverscaleSdk.Common.Converters;

namespace EverscaleSdk.Modules.Boc.Models
{
    public struct ParamsOfDecodeTvc
    {
        /// <summary>
        ///     Contract TVC image BOC encoded as base64 or BOC handle.
        /// </summary>
        public string Tvc { get; set; }

        /// <summary>
        ///     Cache type to put the result.
        ///     The BOC itself returned if no cache type provided.
        /// </summary>
        [JsonConverter(typeof(PolymorphicTypeJsonConverter))]
        public BocCacheType BocCache { get; set; }
    }
}
