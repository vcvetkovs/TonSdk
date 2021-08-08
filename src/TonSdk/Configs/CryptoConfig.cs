namespace TonSdk.Configs
{
    public struct CryptoConfig
    {
        /// <summary>
        ///     Mnemonic dictionary that will be used by default in crypto functions.
        /// </summary>
        /// <remarks>
        ///     If not specified, 1 dictionary will be used.
        /// </remarks>
        public byte? MnemonicDictionary { get; set; }

        /// <summary>
        ///     Mnemonic word count that will be used by default in crypto functions.
        /// </summary>
        /// <remarks>
        ///     If not specified the default value will be 12.
        /// </remarks>
        public byte? MnemonicWordCount { get; set; }

        /// <summary>
        ///     Derivation path that will be used by default in crypto functions.
        /// </summary>
        /// <remarks>
        ///     If not specified <c>m/44'/396'/0'/0/0</c> will be used.
        /// </remarks>
        public string? HdkeyDerivationPath { get; set; }
    }
}
