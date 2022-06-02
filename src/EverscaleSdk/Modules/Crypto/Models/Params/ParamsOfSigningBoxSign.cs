namespace EverscaleSdk.Modules.Crypto.Models
{
    public struct ParamsOfSigningBoxSign
    {
        /// <summary>
        ///     Signing Box handle.
        /// </summary>
        public uint SigningBox { get; set; }

        /// <remarks>
        ///     Encoded with <c>base64</c>.
        /// </remarks>
        public string Unsigned { get; set; }
    }
}
