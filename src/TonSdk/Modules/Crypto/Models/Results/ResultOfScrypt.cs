namespace TonSdk.Modules.Crypto.Models
{
    public struct ResultOfScrypt
    {
        /// <summary>
        ///     Derived key.
        /// </summary>
        /// <remarks>
        ///     Encoded with <c>hex</c>.
        /// </remarks>
        public string Key { get; set; }
    }
}
