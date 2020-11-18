namespace TonSdk.Configs
{
    public struct ClientConfig
    {
        public NetworkConfig? Network { get; set; }
        public CryptoConfig? Crypto { get; set; }
        public AbiConfig? Abi { get; set; }
    }
}
