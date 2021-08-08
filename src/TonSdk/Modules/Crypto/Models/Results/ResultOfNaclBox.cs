namespace TonSdk.Modules.Crypto.Models
{
    public struct ResultOfNaclBox
    {
        /// <summary>
        ///     Encrypted data.
        /// </summary>
        /// <remarks>
        ///     Encoded with <c>base64</c>.
        /// </remarks>
        public string Encrypted { get; set; }
    }
}
