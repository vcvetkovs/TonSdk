namespace EverscaleSdk.Modules.Crypto.Models
{
    public struct ResultOfSigningBoxGetPublicKey
    {
        /// <summary>
        ///     Public key of signing box.
        /// </summary>
        /// <remarks>
        ///     Encoded with <c>hex</c>.
        /// </remarks>
        public string Pubkey { get; set; }
    }
}
