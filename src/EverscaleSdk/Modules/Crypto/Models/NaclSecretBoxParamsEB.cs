namespace EverscaleSdk.Modules.Crypto.Models
{
    public struct NaclSecretBoxParamsEB
    {
        /// <summary>
        ///     Secret key - unprefixed 0-padded to 64 symbols hex string.
        /// </summary>
        public string Key { get; set; }

        /// <summary>
        ///     Nonce in <c>hex</c>.
        /// </summary>
        public string Nonce { get; set; }
    }
}

