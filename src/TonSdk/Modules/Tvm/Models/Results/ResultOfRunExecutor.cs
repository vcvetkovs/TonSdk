using System.Text.Json;
using TonSdk.Models;
using TonSdk.Modules.Processing.Models;

namespace TonSdk.Modules.Tvm.Models
{
    public struct ResultOfRunExecutor
    {
        /// <summary>
        /// Parsed transaction.
        /// In addition to the regular transaction fields there is a
        /// `boc` field encoded with `base64` which contains source
        /// transaction BOC.
        /// </summary>
        public JsonElement Transaction { get; set; }

        /// <summary>
        /// List of output messages' BOCs. Encoded as `base64`.
        /// </summary>
        public string[] OutMessages { get; set; }

        /// <summary>
        /// Optional decoded message bodies according to the optional `abi` parameter.
        /// </summary>
        public DecodedOutput? Decoded { get; set; }

        /// <summary>
        /// Updated account state BOC. Encoded as `base64`
        /// </summary>
        public string Account { get; set; }

        /// <summary>
        /// Transaction fees.
        /// </summary>
        public TransactionFees Fees { get; set; }
    }
}
