namespace TonSdk.Modules.Utils.Models
{
    public struct ParamsOfDecompressZstd
    {
        /// <summary>
        ///     Must be encoded as base64.
        /// </summary>
        public string Compressed { get; set; }
    }
}
