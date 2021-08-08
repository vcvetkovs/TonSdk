namespace TonSdk.Modules.Crypto.Models
{
    public struct ResultOfNaclSignOpen
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
