using TonSdk.Modules.Abi.Models;
using TonSdk.Modules.Tvm.Enums;

namespace TonSdk.Modules.Tvm.Models
{
    public struct ParamsOfRunExecutor<AbiType>
    {
        /// <summary>
        /// Input message BOC. Must be encoded as base64.
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Account to run on executor.
        /// </summary>
        public AccountForExecutor Account { get; set; }

        /// <summary>
        /// Execution options.
        /// </summary>
        public ExecutionOptions? ExecutionOptions { get; set; }

        /// <summary>
        /// Contract ABI for decoding output messages.
        /// </summary>
        public Abi.Models.Abi? Abi { get; set; }

        /// <summary>
        /// Skip transaction check flag.
        /// </summary>
        public bool? SkipTransactionCheck { get; set; }
    }
}
