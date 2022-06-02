namespace EverscaleSdk.Modules.Crypto.Models
{
    public struct ParamsOfMnemonicFromRandom
    {
        /// <summary>
        ///     Dictionary identifier.
        /// </summary>
        public byte? Dictionary { get; set; }

        /// <summary>
        ///     Mnemonic word count.
        /// </summary>
        public byte? WordCount { get; set; }
    }
}
