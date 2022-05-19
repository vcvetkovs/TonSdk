namespace TonSdk.Modules.Crypto.Models
{
	public struct NaclBoxParamsEB
    {
        /// <summary>
        ///     256-bit key.
        ///     Must be encoded with <c>hex</c>.
        /// </summary>
        public string TheirPublic { get; set; }

        /// <summary>
        ///     256-bit key.
        ///     Must be encoded with <c>hex</c>.
        /// </summary>
        public string Secret { get; set; }

        /// <summary>
        ///     96-bit nonce.
        ///     Must be encoded with <c>hex</c>.
        /// </summary>
        public string Nonce { get; set; }
    }
}

