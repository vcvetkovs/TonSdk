using TonSdk.Modules.Abi.Models;

namespace TonSdk.Modules.Tvm.Models
{
    public struct ParamsOfRunTvm<AbiType>
    {
        /// <summary>
        /// Input message BOC. Must be encoded as base64.
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Account BOC. Must be encoded as base64.
        /// </summary>
        public string Account { get; set; }

        /// <summary>
        /// Execution options.
        /// </summary>
        public ExecutionOptions? ExecutionOptions { get; set; }

        /// <summary>
        /// Contract ABI for dedcoding output messages
        /// </summary>
        public Abi.Models.Abi? Abi { get; set; }
    }
}
