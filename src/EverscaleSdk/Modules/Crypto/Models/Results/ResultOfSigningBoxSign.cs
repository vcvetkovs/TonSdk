namespace EverscaleSdk.Modules.Crypto.Models
{
    public struct ResultOfSigningBoxSign
    {
        /// <summary>
        ///     Data signature.
        /// </summary>
        /// <remarks>
        ///     Encoded with <c>hex</c>.
        /// </remarks>
        public string Signature { get; set; }
    }
}
