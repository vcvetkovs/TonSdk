namespace TonSdk.Modules.Abi.Models
{
    public struct ResultOfEncodeMessage
    {
        /// <summary>
        /// Message BOC encoded with `base64`.
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Optional data to be signed encoded in `base64`.
        /// 
        /// Returned in case of `Signer::External`. Can be used for external
        /// message signing.Is this case you need to use this data to create signature and
        /// then produce signed message using `abi.attach_signature`.
        /// </summary>
        public string? DataToSign { get; set; }

        /// <summary>
        /// Destination address.
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Message id.
        /// </summary>
        public string MessageId { get; set; }
    }
}
