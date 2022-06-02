namespace EverscaleSdk.Modules.Utils.Models
{
    public struct ResultOfCompressZstd
    {
        /// <summary>
        ///     Must be encoded as base64.
        /// </summary>
        public string Compressed { get; set; }
    }
}
