namespace TonSdk.Modules.Crypto.Models
{
    public struct ParamsOfNaclSecretBoxOpen
    {
        /// <summary>
        /// Data that must be decrypted. Encoded with `base64`.
        /// </summary>
        public string Encrypted { get; set; }

        /// <summary>
        /// Nonce in `hex`.
        /// </summary>
        public string Nonce { get; set; }

        /// <summary>
        /// Public key - unprefixed 0-padded to 64 symbols hex string.
        /// </summary>
        public string Key { get; set; }
    }
}
