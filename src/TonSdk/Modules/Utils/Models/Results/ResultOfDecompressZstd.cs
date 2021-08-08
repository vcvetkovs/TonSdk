namespace TonSdk.Modules.Utils.Models
{
    public struct ResultOfDecompressZstd
    {
        /// <summary>
        ///     Must be encoded as base64.
        /// </summary>
        public string Decompressed { get; set; }
    }
}
