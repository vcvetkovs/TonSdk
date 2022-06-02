namespace EverscaleSdk.Modules.Crypto.Models
{
    public struct ResultOfNaclBoxOpen
    {
        /// <summary>
        ///     Decrypted data.
        /// </summary>
        /// <remarks>
        ///     Encoded with <c>base64</c>.
        /// </remarks>
        public string Decrypted { get; set; }
    }
}
