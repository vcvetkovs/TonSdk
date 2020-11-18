namespace TonSdk.Modules.Crypto.Models
{
    public struct ResultOfScrypt
    {
        /// <summary>
        /// Derived key. Encoded with `hex`.
        /// </summary>
        public string Key { get; set; }
    }
}
