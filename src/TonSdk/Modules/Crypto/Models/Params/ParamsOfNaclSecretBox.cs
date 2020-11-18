namespace TonSdk.Modules.Crypto.Models
{
    public struct ParamsOfNaclSecretBox
    {
        /// <summary>
        /// Data that must be encrypted. Encoded with `base64`.
        /// </summary>
        public string Decrypted { get; set; }

        /// <summary>
        /// Nonce in `hex`.
        /// </summary>
        public string Nonce { get; set; }

        /// <summary>
        /// Secret key - unprefixed 0-padded to 64 symbols hex string.
        /// </summary>
        public string Key { get; set; }
    }
}
