namespace EverscaleSdk.Modules.Crypto.Models
{
    public struct ParamsOfSign
    {
        /// <summary>
        ///     Data that must be signed encoded in <c>base64</c>.
        /// </summary>
        public string Unsigned { get; set; }

        /// <summary>
        ///     Sign keys.
        /// </summary>
        public KeyPair Keys { get; set; }
    }
}
