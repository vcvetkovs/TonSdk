namespace TonSdk.Modules.Crypto.Models
{
    public struct ParamsOfNaclSecretBoxOpen
    {
        /// <summary>
        ///     Data that must be decrypted.
        /// </summary>
        /// <remarks>
        ///     Encoded with <c>base64</c>.
        /// </remarks>
        public string Encrypted { get; set; }

        /// <summary>
        ///     Nonce in <c>hex</c>.
        /// </summary>
        public string Nonce { get; set; }

        /// <summary>
        ///     Public key - unprefixed 0-padded to 64 symbols hex string.
        /// </summary>
        public string Key { get; set; }
    }
}
