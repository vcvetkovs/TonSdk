namespace TonSdk.Modules.Crypto.Models
{
    public struct ResultOfSign
    {
        /// <summary>
        /// Signed data combined with signature encoded in `base64`.
        /// </summary>
        public string Signed { get; set; }

        /// <summary>
        /// Signature encoded in `hex`.
        /// </summary>
        public string Signature { get; set; }
    }
}
