namespace TonSdk.Modules.Crypto.Models
{
    public struct ParamsOfMnemonicFromEntropy
    {
        /// <summary>
        /// Entropy bytes. Hex encoded.
        /// </summary>
        public string Entropy { get; set; }

        /// <summary>
        /// Dictionary identifier.
        /// </summary>
        public byte? Dictionary { get; set; }

        /// <summary>
        /// Mnemonic word count
        /// </summary>
        public byte? WordCount { get; set; }
    }
}
