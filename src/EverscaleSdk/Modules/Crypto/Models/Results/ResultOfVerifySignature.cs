namespace EverscaleSdk.Modules.Crypto.Models
{
    public struct ResultOfVerifySignature
    {
        /// <summary>
        ///     Unsigned data.
        /// </summary>
        /// <remarks>
        ///     Encoded with <c>base64</c>.
        /// </remarks>
        public string Unsigned { get; set; }
    }
}
