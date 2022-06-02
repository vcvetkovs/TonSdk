namespace EverscaleSdk.Modules.Abi.Models
{
    public struct ParamsOfAttachSignatureToMessageBody
    {
        /// <summary>
        ///     Contract ABI.
        /// </summary>
        public Abi Abi { get; set; }

        /// <remarks>
        ///     Must be encoded with <c>hex</c>.
        /// </remarks>
        public string PublicKey { get; set; }

        /// <summary>
        ///     Unsigned message body BOC.
        /// </summary>
        /// <remarks>
        ///     Must be encoded with <c>hex</c>.
        /// </remarks>
        public string Message { get; set; }

        /// <remarks>
        ///     Must be encoded with <c>hex</c>.
        /// </remarks>
        public string Signature { get; set; }
    }
}
