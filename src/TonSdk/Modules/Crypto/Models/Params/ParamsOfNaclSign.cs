namespace TonSdk.Modules.Crypto.Models
{
    public struct ParamsOfNaclSign
    {
        /// <summary>
        /// Data that must be signed encoded in `base64`.
        /// </summary>
        public string Unsigned { get; set; }

        /// <summary>
        /// Signer's secret key - unprefixed 0-padded to 64 symbols hex string 
        /// </summary>
        public string Secret { get; set; }
    }
}
