namespace EverscaleSdk.Modules.Crypto.Models
{
    public struct ParamsOfNaclSignDetachedVerify
    {
        /// <summary>
        ///     Unsigned data that must be verified.
        /// </summary>
        /// <remarks>
        ///     Encoded with <c>base64</c>.
        /// </remarks>
        public string Unsigned { get; set; }

        /// <summary>
        ///     Signature that must be verified.
        /// </summary>
        /// <remarks>
        ///     Encoded with <c>hex</c>.
        /// </remarks>
        public string Signature { get; set; }

        /// <summary>
        ///     Signer's public key - unprefixed 0-padded to 64 symbols hex string.
        /// </summary>
        public string Public { get; set; }
    }

}
