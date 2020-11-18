namespace TonSdk.Modules.Crypto.Models
{
    public struct ResultOfNaclBoxOpen
    {
        /// <summary>
        /// Decrypted data encoded in `base64`.
        /// </summary>
        public string Decrypted { get; set; }
    }
}
