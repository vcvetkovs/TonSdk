namespace EverscaleSdk.Modules.Crypto.Models
{
    public struct ParamsOfHDKeyDeriveFromXPrvPath
    {
        /// <summary>
        ///     Serialized extended private key.
        /// </summary>
        public string Xprv { get; set; }

        /// <summary>
        ///     Derivation path, for instance "m/44'/396'/0'/0/0".
        /// </summary>
        public string Path { get; set; }
    }
}
