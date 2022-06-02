namespace EverscaleSdk.Modules.Utils.Models
{
    public struct ParamsOfCompressZstd
    {
        /// <summary>
        ///     Must be encoded as base64.
        /// </summary>
        public string Uncompressed { get; set; }

        /// <summary>
        ///     Compression level, from 1 to 21.
        /// </summary>
        /// <remarks>
        ///     Where: 1 - lowest compression level (fastest compression); 21 -
        ///     highest compression level (slowest compression). If level is omitted, the default compression level
        ///     is used (currently <c>3</c>).
        /// </remarks>
        public int? Level { get; set; }
    }
}
