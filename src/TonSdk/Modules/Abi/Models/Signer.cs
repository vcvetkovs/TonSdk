using System.Text.Json.Serialization;
using TonSdk.Modules.Crypto.Models;

namespace TonSdk.Modules.Abi.Models
{
    public abstract class Signer
    {
        /// <summary>
        ///     Creates an unsigned message.
        /// </summary>
        public class None : Signer
        {
        }

        /// <summary>
        ///     Only public key is provided in unprefixed hex string format to generate unsigned message
        ///     and <c>data_to_sign</c> which can be signed later.  
        /// </summary>
        public class External : Signer
        {
            public string PublicKey { get; set; }
        }

        /// <summary>
        ///     Key pair is provided for signing.
        /// </summary>
        public class Keys : Signer
        {
            [JsonPropertyName("keys")]
            public new KeyPair KeyPair { get; set; }
        }

        /// <summary>
        ///     Signing Box interface is provided for signing, allows Dapps to sign messages using external APIs,
        ///     such as HSM, cold wallet, etc.
        /// </summary>
        public class SigningBox : Signer
        {
            public uint Handle { get; set; }
        }
    }
}