namespace TonSdk.Modules.Crypto.Models
{
    public struct ResultOfSign
    {
        /// <summary>
        ///     Signed data combined with signature.
        /// </summary>
        /// <remarks>
        ///     Encoded with <c>base64</c>.
        /// </remarks>
        public string Signed { get; set; }

        /// <summary>
        ///     Signature.
        /// </summary>
        /// <remarks>
        ///     Encoded with <c>hex</c>.
        /// </remarks>
        public string Signature { get; set; }
    }
}
