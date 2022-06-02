namespace EverscaleSdk.Modules.Crypto.Models
{
    public struct ParamsOfChacha20
    {
        /// <summary>
        ///     Source data to be encrypted or decrypted.
        /// </summary>
        /// <remarks>
        ///     Must be encoded with <c>base64</c>.
        /// </remarks>
        public string Data { get; set; }

        /// <summary>
        ///     256-bit key.
        /// </summary>
        /// <remarks>
        ///     Must be encoded with <c>hex</c>.
        /// </remarks>
        public string Key { get; set; }

        /// <summary>
        ///     96-bit nonce.
        /// </summary>
        /// <remarks>
        ///     Must be encoded with <c>hex</c>.
        /// </remarks>
        public string Nonce { get; set; }
    }
}
