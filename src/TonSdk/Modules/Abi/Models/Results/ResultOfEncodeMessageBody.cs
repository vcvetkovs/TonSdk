namespace TonSdk.Modules.Abi.Models
{
    public struct ResultOfEncodeMessageBody
    {
        /// <summary>
        /// Message body BOC encoded with `base64`.
        /// </summary>
        public string Body { get; set; }

        /// <summary>
        /// Optional data to sign. Encoded with `base64`.
        /// Presents when `message` is unsigned.Can be used for external
        /// message signing.Is this case you need to sing this data and
        /// produce signed message using `abi.attach_signature`.
        /// </summary>
        public string? DataToSign { get; set; }
    }
}
