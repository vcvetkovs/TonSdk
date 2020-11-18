using System.Text.Json;

namespace TonSdk.Modules.Abi.Models
{
    public struct DeploySet
    {
        /// <summary>
        /// Content of TVC file encoded in `base64`.
        /// </summary>
        public string Tvc { get; set; }

        /// <summary>
        /// Target workchain for destination address. Default is `0`.
        /// </summary>
        public int? WorkchainId { get; set; }

        /// <summary>
        /// List of initial values for contract's public variables.
        /// </summary>
        public JsonElement? InitialData { get; set; }
    }
}
