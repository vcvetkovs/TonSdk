namespace TonSdk.Modules.Crypto.Models
{
    public struct ParamsOfVerifySignature
    {
        /// <summary>
        /// Signed data that must be verified encoded in `base64`.
        /// </summary>
        public string Signed { get; set; }

        /// <summary>
        /// Signer's public key - 64 symbols hex string.
        /// </summary>
        public string Public { get; set; }
    }
}
