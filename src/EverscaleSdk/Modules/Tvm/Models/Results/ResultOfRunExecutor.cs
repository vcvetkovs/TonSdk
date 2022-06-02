using System.Text.Json;
using EverscaleSdk.Models;
using EverscaleSdk.Modules.Processing.Models;

namespace EverscaleSdk.Modules.Tvm.Models
{
    public struct ResultOfRunExecutor
    {
        /// <summary>
        ///     Parsed transaction.
        /// </summary>
        /// <remarks>
        ///     In addition to the regular transaction fields there is a
        ///     <c>boc</c> field encoded with <c>base64</c> which contains source
        ///     transaction BOC.
        /// </remarks>
        public JsonElement Transaction { get; set; }

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
        ///     Updated account state BOC.
        /// </summary>
        /// <remarks>
        ///     Encoded as <c>base64</c>
        /// </remarks>
        public string Account { get; set; }

        /// <summary>
        ///     Transaction fees.
        /// </summary>
        public TransactionFees Fees { get; set; }
    }
}
