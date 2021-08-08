namespace TonSdk.Configs
{
    public struct ClientConfig
    {
        public AbiConfig? Abi { get; set; }
        public BocConfig? Boc { get; set; }
        public CryptoConfig? Crypto { get; set; }
        public NetworkConfig? Network { get; set; }
    }
}
