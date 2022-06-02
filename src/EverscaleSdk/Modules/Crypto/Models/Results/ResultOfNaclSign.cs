namespace EverscaleSdk.Modules.Crypto.Models
{
    public struct ResultOfNaclSign
    {
        /// <summary>
        ///     Signed data.
        /// </summary>
        /// <remarks>
        ///     Encoded with <c>base64</c>.
        /// </remarks>
        public string Signed { get; set; }
    }
}
