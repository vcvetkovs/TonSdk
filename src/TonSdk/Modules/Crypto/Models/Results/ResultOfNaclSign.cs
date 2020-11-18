namespace TonSdk.Modules.Crypto.Models
{
    public struct ResultOfNaclSign
    {
        /// <summary>
        /// Signed data, encoded in `base64`.
        /// </summary>
        public string Signed { get; set; }
    }
}
