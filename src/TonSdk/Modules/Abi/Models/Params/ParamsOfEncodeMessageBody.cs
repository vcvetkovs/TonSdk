namespace TonSdk.Modules.Abi.Models
{
    public struct ParamsOfEncodeMessageBody<TSigner>
    {
        /// <summary>
        /// Contract ABI.
        /// </summary>
        public Abi Abi { get; set; }

        /// <summary>
        /// Function call parameters.
        /// Must be specified in non deploy message.
        /// In case of deploy message contains parameters of constructor.
        /// </summary>
        public CallSet CallSet { get; set; }

        /// <summary>
        /// True if internal message body must be encoded.
        /// </summary>
        public bool IsInternal { get; set; }

        /// <summary>
        /// Signing parameters.
        /// </summary>
        public TSigner Signer { get; set; }

        /// <summary>
        ///  Processing try index.
        ///  Used in message processing with retries.
        ///  Encoder uses the provided try index to calculate message
        ///  expiration time.
        /// 
        ///  Expiration timeouts will grow with every retry.
        /// 
        ///  Default value is 0.
        /// </summary>
        public byte? ProcessingTryIndex { get; set; }
    }
}
