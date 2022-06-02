using System.Text.Json;

namespace EverscaleSdk.Modules.Crypto.Models
{
    /// <summary>
    ///     Encryption box information.
    /// </summary>
    public struct EncryptionBoxInfo
    {
        /// <summary>
        ///     Derivation path, for instance "m/44'/396'/0'/0/0".
        /// </summary>
        public string Hdpath { get; set; }

        /// <summary>
        ///     Cryptographic algorithm, used by this encryption box.
        /// </summary>
        public string Algorithm { get; set; }

        /// <summary>
        ///     Options, depends on algorithm and specific encryption box implementation.
        /// </summary>
        public JsonElement Options { get; set; }

        /// <summary>
        ///     Public information, depends on algorithm.
        /// </summary>
        public JsonElement Public { get; set; }
    }
}
