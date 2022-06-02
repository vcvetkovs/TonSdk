namespace EverscaleSdk.Modules.Crypto.Models
{
    public struct ParamsOfMnemonicDeriveSignKeys
    {
        /// <summary>
        ///     Phrase.
        /// </summary>
        public string Phrase { get; set; }

        /// <summary>
        ///     Derivation path, for instance "m/44'/396'/0'/0/0".
        /// </summary>
        public string? Path { get; set; }

        /// <summary>
        ///     Dictionary identifier.
        /// </summary>
        public byte? Dictionary { get; set; }

        /// <summary>
        ///     Word count.
        /// </summary>
        public byte? WordCount { get; set; }
    }
}
