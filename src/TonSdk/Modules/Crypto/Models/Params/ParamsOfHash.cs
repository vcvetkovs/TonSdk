namespace TonSdk.Modules.Crypto.Models
{
    public struct ParamsOfHash
    {
        /// <summary>
        ///     Input data for hash calculation.
        /// </summary>
        /// <remarks>
        ///     Encoded with <c>base64</c>.
        /// </remarks>
        public string Data { get; set; }
    }
}
