using System.Text.Json.Serialization;
using EverscaleSdk.Common.Converters;

namespace EverscaleSdk.Modules.Boc.Models
{
    public struct ParamsOfBocCacheSet
    {
        /// <summary>
        ///     BOC encoded as base64 or BOC reference.
        /// </summary>
        public string Boc { get; set; }

        /// <summary>
        ///     Cache type.
        /// </summary>
        [JsonConverter(typeof(PolymorphicTypeJsonConverter))]
        public BocCacheType CacheType { get; set; }
	}
}
