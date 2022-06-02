namespace EverscaleSdk.Modules.Crypto.Models
{
    public struct ParamsOfEncryptionBoxDecrypt
    {
        /// <summary>
        ///     Encryption box handle.
        /// </summary>
        public uint EncryptionBox { get; set; }

        /// <summary>
        ///     Data to be decrypted.
        /// </summary>
        /// <remarks>
        ///     Encoded with <c>base64</c>.
        /// </remarks>
        public string Data { get; set; }
    }
}
