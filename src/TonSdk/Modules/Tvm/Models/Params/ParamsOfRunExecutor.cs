using System.Text.Json.Serialization;
using TonSdk.Modules.Boc.Models;
using TonSdk.Common.Converters;

namespace TonSdk.Modules.Tvm.Models
{
	public struct ParamsOfRunExecutor
    {
        /// <summary>
        ///     Input message BOC.
        /// </summary>
        /// <remarks>
        ///     Must be encoded as base64.
        /// </remarks>
        public string Message { get; set; }

        /// <summary>
        ///     Account to run on executor.
        /// </summary>
        [JsonConverter(typeof(PolymorphicTypeJsonConverter))]
        public AccountForExecutor Account { get; set; }

        /// <summary>
        ///     Execution options.
        /// </summary>
        public ExecutionOptions? ExecutionOptions { get; set; }

        /// <summary>
        ///     Contract ABI for decoding output messages.
        /// </summary>
        public Abi.Models.Abi? Abi { get; set; }

        /// <summary>
        ///     Skip transaction check flag.
        /// </summary>
        public bool? SkipTransactionCheck { get; set; }

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
