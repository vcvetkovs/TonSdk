namespace EverscaleSdk.Modules.Crypto.Models
{
    public struct KeyPair
    {
        /// <summary>
        ///     Public key - 64 symbols hex string.
        /// </summary>
        public string Public { get; set; }

        /// <summary>
        ///     Private key - u64 symbols hex string.
        /// </summary>
        public string Secret { get; set; }
    }
}
