using System.Text.Json.Serialization;
using TonSdk.Common.Converters;
using TonSdk.Modules.Boc.Models;

namespace TonSdk.Modules.Tvm.Models
{
    public struct ParamsOfRunTvm
    {
        /// <summary>
        ///     Input message BOC.
        /// </summary>
        /// <remarks>
        ///     Must be encoded as base64.
        /// </remarks>
        public string Message { get; set; }

        /// <summary>
        ///     Account BOC.
        /// </summary>
        /// <remarks>
        ///     Must be encoded as base64.
        /// </remarks>
        public string Account { get; set; }

        /// <summary>
        ///     Execution options.
        /// </summary>
        public ExecutionOptions? ExecutionOptions { get; set; }

        /// <summary>
        ///     Contract ABI for dedcoding output messages.
        /// </summary>
        [JsonConverter(typeof(PolymorphicTypeJsonConverter))]
        public Abi.Models.Abi? Abi { get; set; }

        /// <summary>
        ///     The BOC itself returned if no cache type provided.
        /// </summary>
        [JsonConverter(typeof(PolymorphicTypeJsonConverter))]
        public BocCacheType BocCache { get; set; }

        /// <summary>
        ///     Empty string is returned if the flag is <c>false</c>.
        /// </summary>
        public bool? ReturnUpdatedAccount { get; set; }
    }
}
