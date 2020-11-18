namespace TonSdk.Modules.Abi.Models
{
    public struct ParamsOfAttachSignatureToMessageBody
    {
        /// <summary>
        /// Contract ABI.
        /// </summary>
        public Abi Abi { get; set; }

        /// <summary>
        /// Public key. Must be encoded with `hex`.
        /// </summary>
        public string PublicKey { get; set; }

        /// <summary>
        /// Unsigned message BOC. Must be encoded with `base64`.
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Signature. Must be encoded with `hex`.
        /// </summary>
        public string Signature { get; set; }
    }
}
