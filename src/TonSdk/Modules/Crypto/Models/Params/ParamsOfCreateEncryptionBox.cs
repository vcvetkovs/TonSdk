namespace TonSdk.Modules.Crypto.Models
{
    public struct ParamsOfCreateEncryptionBox
    {
        /// <summary>
        ///     Encryption algorithm specifier including cipher parameters (key, IV, etc).
        /// </summary>
        public EncryptionAlgorithm Algorithm { get; set; }
    }
}
