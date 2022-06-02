using System.Text.Json.Serialization;
using EverscaleSdk.Common.Converters;

namespace EverscaleSdk.Modules.Boc.Models
{
    public struct ParamsOfSetCodeSalt
    {
        /// <summary>
        ///     Contract code BOC encoded as base64 or code BOC handle.
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        ///     BOC encoded as base64 or BOC handle.
        /// </summary>
        public string Salt { get; set; }

        /// <summary>
        ///     Cache type to put the result.
        ///     The BOC itself returned if no cache type provided.
        /// </summary>
        [JsonConverter(typeof(PolymorphicTypeJsonConverter))]
        public BocCacheType BocCache { get; set; }
    }
}
