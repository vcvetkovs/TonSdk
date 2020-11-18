namespace TonSdk.Modules.Crypto.Models
{
    public struct ParamsOfNaclBox
    {
        /// <summary>
        /// Data that must be encrypted encoded in `base64`.
        /// </summary>
        public string Decrypted { get; set; }

        /// <summary>
        /// Nonce, encoded in `hex`.
        /// </summary>
        public string Nonce { get; set; }

        /// <summary>
        /// Receiver's public key - unprefixed 0-padded to 64 symbols hex string.
        /// </summary>
        public string TheirPublic { get; set; }

        /// <summary>
        /// Sender's private key - unprefixed 0-padded to 64 symbols hex string.
        /// </summary>
        public string Secret { get; set; }
    }
}
