using TonSdk.Modules.Processing.Models;

namespace TonSdk.Modules.Tvm.Models
{
    public struct ResultOfRunTvm
    {
        /// <summary>
        ///     List of output messages' BOCs.
        /// </summary>
        /// <remarks>
        ///     Encoded as <c>base64</c>.
        /// </remarks>
        public string[] OutMessages { get; set; }

        /// <summary>
        ///     Optional decoded message bodies according to the optional <c>abi</c> parameter.
        /// </summary>
        public DecodedOutput? Decoded { get; set; }

        /// <summary>
        ///     Attention! Only <c>account_state.storage.state.data</c> part of the boc is updated.
        /// </summary>
        /// <remarks>
        ///     Encoded as <c>base64</c>.
        /// </remarks>
        public string Account { get; set; }
    }
}
