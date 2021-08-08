namespace TonSdk.Modules.Crypto.Models
{
    public struct ParamsOfEncryptionBoxEncrypt
    {
        /// <summary>
        ///     Encryption box handle.
        /// </summary>
        public uint EncryptionBox { get; set; }

        /// <summary>
        ///     Data to be encrypted, encoded in Base64.
        /// </summary>
        public string Data { get; set; }
    }
}
