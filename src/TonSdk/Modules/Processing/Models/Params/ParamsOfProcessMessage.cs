using TonSdk.Modules.Abi.Models;

namespace TonSdk.Modules.Processing.Models
{
    public struct ParamsOfProcessMessage
    {
        /// <summary>
        ///     Message encode parameters.
        /// </summary>
        public ParamsOfEncodeMessage MessageEncodeParams { get; set; }

        /// <summary>
        ///     Flag for requesting events sending.
        /// </summary>
        public bool SendEvents { get; set; }
    }
}
