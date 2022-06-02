namespace EverscaleSdk.Modules.Crypto.Models
{
	public struct ChaCha20ParamsCB
    {
        /// <summary>
        ///     96-bit nonce.
        ///     Must be encoded with <c>hex</c>.
        /// </summary>
        public string Nonce { get; set; }
    }
}

