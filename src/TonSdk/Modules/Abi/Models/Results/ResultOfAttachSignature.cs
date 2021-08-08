namespace TonSdk.Modules.Abi.Models
{
    public struct ResultOfAttachSignature
    {
        /// <summary>
        ///     Signed message BOC.
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        ///     Message ID.
        /// </summary>
        public string MessageId { get; set; }
    }
}
