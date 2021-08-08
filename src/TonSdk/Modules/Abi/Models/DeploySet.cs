using System.Text.Json;

namespace TonSdk.Modules.Abi.Models
{
    public struct DeploySet
    {
        /// <summary>
        ///     Content of TVC file encoded in <c>base64</c>.
        /// </summary>
        public string Tvc { get; set; }

        /// <summary>
        ///     Target workchain for destination address.
        /// </summary>
        /// <remarks>
        ///     Default is <c>0</c>.
        /// </remarks>
        public int? WorkchainId { get; set; }

        /// <summary>
        ///     List of initial values for contract's public variables.
        /// </summary>
        public JsonElement? InitialData { get; set; }

        /// <summary>
        ///     Optional public key that can be provided in deploy set in order
        ///     to substitute one in TVM file or provided by Signer.
        /// </summary>
        /// <remarks>
        ///     Public key resolving priority:
        ///     
        ///     <list type="number">
        ///      <item>
        ///         Public key from deploy set.
        ///      </item>
        ///      <item>
        ///         Public key, specified in TVM file.
        ///      </item>
        ///      <item>
        ///         Public key, provided by Signer.
        ///      </item>
        ///     </list>
        /// </remarks>
        public string InitialPubkey { get; set; }
    }
}
