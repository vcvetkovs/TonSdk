namespace TonSdk.Configs
{
    public struct ClientConfig
    {
        public AbiConfig? Abi { get; set; }
        public BocConfig? Boc { get; set; }
        public CryptoConfig? Crypto { get; set; }
        public ProofsConfig? Proofs { get; set; }
        public NetworkConfig? Network { get; set; }

        /// <summary>
        ///     For file based storage is a folder name where SDK will store its data.
        /// </summary>
        /// <remarks>
        ///     For browser based is a browser async storage key prefix. <para/>
        ///     
        ///     Default (recommended) value is "~/.tonclient" for native environments and ".tonclient" for web-browser.
        /// </remarks>
        public string LocalStoragePath { get; set; }
    }
}
