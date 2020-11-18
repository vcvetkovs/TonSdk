namespace TonSdk.Modules.Crypto.Models
{
    public struct ParamsOfSign
    {
        /// <summary>
        /// Data that must be signed encoded in `base64`.
        /// </summary>
        public string Unsigned { get; set; }

        /// <summary>
        /// Sign keys.
        /// </summary>
        public KeyPair Keys { get; set; }
    }
}
