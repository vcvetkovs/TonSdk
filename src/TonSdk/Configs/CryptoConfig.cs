namespace TonSdk.Configs
{
    public struct CryptoConfig
    {
        public byte? MnemonicDictionary { get; set; }
        public byte? MnemonicWordCount { get; set; }
        public string? HdkeyDerivationPath { get; set; }
        public bool? HdkeyCompliant { get; set; }
    }
}
