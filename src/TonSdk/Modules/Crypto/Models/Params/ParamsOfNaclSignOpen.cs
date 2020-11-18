namespace TonSdk.Modules.Crypto.Models
{
    public struct ParamsOfNaclSignOpen
    {
        /// <summary>
        /// Signed data that must be unsigned. Encoded with `base64`.
        /// </summary>
        public string Signed { get; set; }

        /// <summary>
        /// Signer's public key - unprefixed 0-padded to 64 symbols hex string.
        /// </summary>
        public string Public { get; set; }
    }
}
