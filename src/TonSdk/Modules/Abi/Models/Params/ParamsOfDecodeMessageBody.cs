namespace TonSdk.Modules.Abi.Models
{
    public struct ParamsOfDecodeMessageBody
    {
        /// <summary>
        /// Contract ABI used to decode.
        /// </summary>
        public Abi Abi { get; set; }

        /// <summary>
        /// Message body BOC encoded in `base64`.
        /// </summary>
        public string Body { get; set; }

        /// <summary>
        /// True if the body belongs to the internal message.
        /// </summary>
        public bool IsInternal { get; set; }
    }
}
