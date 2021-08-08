namespace TonSdk.Modules.Crypto.Models
{
    public struct ResultOfHash
    {
        /// <summary>
        ///     Hash of input <c>data</c>.
        /// </summary>
        /// <remarks>
        ///     Encoded with <c>hex</c>.
        /// </remarks>
        public string Hash { get; set; }
    }
}
