namespace TonSdk.Modules.Crypto.Models
{
    public struct ParamsOfSigningBoxSign
    {
        /// <summary>
        /// Signing Box handle.
        /// </summary>
        public uint SigningBox { get; set; }

        /// <summary>
        /// Must be encoded with `base64`.
        /// </summary>
        public string Unsigned { get; set; }
    }
}
