using System.Text.Json.Serialization;
using EverscaleSdk.Common.Converters;
using EverscaleSdk.Modules.Boc.Models;

namespace EverscaleSdk.Modules.Abi.Models
{
    public struct ParamsOfEncodeAccount
    {
        /// <summary>
        ///     Source of the account state init.
        /// </summary>
        [JsonConverter(typeof(PolymorphicTypeJsonConverter))]
        public StateInitSource StateInit { get; set; }

        /// <summary>
        ///     Initial balance.
        /// </summary>
        public ulong? Balance { get; set; }

        /// <summary>
        ///     Initial value for the <c>last_trans_lt</c>.
        /// </summary>
        public ulong? LastTransLt { get; set; }

        /// <summary>
        ///     Initial value for the <c>last_paid</c>.
        /// </summary>
        public uint? LastPaid { get; set; }

        /// <summary>
        ///     Cache type to put the result.
        /// </summary>
        /// <remarks>
        ///     The BOC itself returned if no cache type provided.
        /// </remarks>
        [JsonConverter(typeof(PolymorphicTypeJsonConverter))]
        public BocCacheType BocCache { get; set; }
    }
}
