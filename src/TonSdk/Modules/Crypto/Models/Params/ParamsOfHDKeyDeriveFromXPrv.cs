namespace TonSdk.Modules.Crypto.Models
{
    public struct ParamsOfHDKeyDeriveFromXPrv
    {
        /// <summary>
        /// Serialized extended private key
        /// </summary>
        public string Xprv { get; set; }

        /// <summary>
        /// Child index (see BIP-0032)
        /// </summary>
        public uint ChildIndex { get; set; }

        /// <summary>
        /// Indicates the derivation of hardened/not-hardened key (see BIP-0032).
        /// </summary>
        public bool Hardened { get; set; }
    }
}
