namespace TonSdk.Modules.Crypto.Models
{
    public struct ParamsOfNaclSignOpen
    {
        /// <summary>
        ///     Signed data that must be unsigned.
        /// </summary>
        /// <remarks>
        ///     Encoded with <c>base64</c>.
        /// </remarks>
        public string Signed { get; set; }

        /// <summary>
        ///     Signer's public key - unprefixed 0-padded to 64 symbols hex string.
        /// </summary>
        public string Public { get; set; }
    }
}
