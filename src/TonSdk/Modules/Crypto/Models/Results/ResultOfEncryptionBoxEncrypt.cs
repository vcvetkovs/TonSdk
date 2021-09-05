namespace TonSdk.Modules.Crypto.Models
{
    public struct ResultOfEncryptionBoxEncrypt
    {
        /// <summary>
        ///     Encrypted data, encoded in Base64.
        /// </summary>
        /// <remarks>
        ///     Padded to cipher block size.
        /// </remarks>
        public string Data { get; set; }
    }
}
