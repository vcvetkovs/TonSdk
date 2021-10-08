using System.Text.Json.Serialization;
using TonSdk.Common.Converters;

namespace TonSdk.Modules.Boc.Models
{
    public struct ParamsOfEncodeTvc
    {
        /// <summary>
        ///     Contract code BOC encoded as base64 or BOC handle.
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        ///     Contract data BOC encoded as base64 or BOC handle.
        /// </summary>
        public string Data { get; set; }

        /// <summary>
        ///     Contract library BOC encoded as base64 or BOC handle.
        /// </summary>
        public string Library { get; set; }

        /// <summary>
        ///     Specifies the contract ability to handle tick transactions.
        /// </summary>
        public bool? Tick { get; set; }

        /// <summary>
        ///     Specifies the contract ability to handle tock transactions.
        /// </summary>
        public bool? Tock { get; set; }

        /// <summary>
        ///     Is present and non-zero only in instances of large smart contracts.
        /// </summary>
        public uint? SplitDepth { get; set; }

        /// <summary>
        ///     Cache type to put the result.
        ///     The BOC itself returned if no cache type provided.
        /// </summary>
        [JsonConverter(typeof(PolymorphicTypeJsonConverter))]
        public BocCacheType BocCache { get; set; }
    }
}
