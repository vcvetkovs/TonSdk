namespace TonSdk.Modules.Crypto.Models
{
    public struct ChaCha20ParamsEB
    {
        /// <summary>
        ///     256-bit key.
        ///     Must be encoded with <c>hex</c>.
        /// </summary>
        public string Key { get; set; }

        /// <summary>
        ///     96-bit nonce.
        ///     Must be encoded with <c>hex</c>.
        /// </summary>
        public string Nonce { get; set; }
    }
}

