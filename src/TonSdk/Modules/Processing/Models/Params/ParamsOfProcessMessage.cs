using TonSdk.Modules.Abi.Models;

namespace TonSdk.Modules.Processing.Models
{
    public struct ParamsOfProcessMessage<TSigner>
    {
        /// <summary>
        /// Message encode parameters.
        /// </summary>
        public ParamsOfEncodeMessage<TSigner> MessageEncodeParams { get; set; }

        /// <summary>
        /// Flag for requesting events sending.
        /// </summary>
        public bool SendEvents { get; set; }
    }
}
