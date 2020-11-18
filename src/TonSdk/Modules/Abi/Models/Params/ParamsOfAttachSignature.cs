namespace TonSdk.Modules.Abi.Models
{
    public struct ParamsOfAttachSignature
    {
        /// <summary>
        /// Contract ABI.
        /// </summary>
        public Abi Abi { get; set; }

        /// <summary>
        /// Public key encoded in `hex`.
        /// </summary>
        public string PublicKey { get; set; }

        /// <summary>
        /// Unsigned message BOC encoded in `base64`.
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Signature encoded in `hex`.
        /// </summary>
        public string Signature { get; set; }
    }
}
