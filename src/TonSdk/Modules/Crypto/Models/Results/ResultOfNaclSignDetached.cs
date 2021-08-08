namespace TonSdk.Modules.Crypto.Models
{
    public struct ResultOfNaclSignDetached
    {
        /// <summary>
        ///     Signature.
        /// </summary>
        /// <remarks>
        ///     Encoded with <c>hex</c>.
        /// </remarks>
        public string Signature { get; set; }
    }
}
