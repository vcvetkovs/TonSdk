namespace TonSdk.Modules.Crypto.Models
{
    public struct ResultOfVerifySignature
    {
        /// <summary>
        /// Unsigned data encoded in `base64`.
        /// </summary>
        public string Unsigned { get; set; }
    }
}
