using TonSdk.Modules.Processing.Models;

namespace TonSdk.Modules.Tvm.Models
{
    public struct ResultOfRunTvm
    {
        /// <summary>
        /// List of output messages' BOCs. Encoded as `base64`.
        /// </summary>
        public string[] OutMessages { get; set; }

        /// <summary>
        /// Optional decoded message bodies according to the optional `abi` parameter.
        /// </summary>
        public DecodedOutput? Decoded { get; set; }

        /// <summary>
        /// Updated account state BOC. Encoded as `base64`.
        /// Attention! Only data in account state is updated.
        /// </summary>
        public string Account { get; set; }
    }
}
