using System.Text.Json.Serialization;
using EverscaleSdk.Common.Converters;
using EverscaleSdk.Modules.Boc.Models;

namespace EverscaleSdk.Modules.Abi.Models
{
    public struct ParamsOfUpdateInitialData
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

        /// <summary>
        ///    <see cref="Abi"/> parameter should be provided to set initial data.
        /// </summary>
        public dynamic InitialData { get; set; }

        /// <summary>
        ///     Initial account owner's public key to set into account data.
        /// </summary>
        public string InitialPubkey { get; set; }

        /// <summary>
        ///     Cache type to put the result. The BOC itself returned if no cache type provided.
        /// </summary>
        [JsonConverter(typeof(PolymorphicTypeJsonConverter))]
        public BocCacheType BocCache { get; set; }
    }
}
