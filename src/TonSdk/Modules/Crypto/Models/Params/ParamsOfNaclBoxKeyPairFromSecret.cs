namespace TonSdk.Modules.Crypto.Models
{
    public struct ParamsOfNaclBoxKeyPairFromSecret
    {
        /// <summary>
        ///     Secret key - unprefixed 0-padded to 64 symbols hex string.
        /// </summary>
        public string Secret { get; set; }
    }
}
