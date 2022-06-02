namespace EverscaleSdk.Modules.Abi.Models
{
    public struct ParamsOfEncodeMessageBody
    {
        /// <summary>
        ///     Contract ABI.
        /// </summary>
        public Abi Abi { get; set; }

        /// <summary>
        ///     Function call parameters.
        /// </summary>
        /// <remarks>
        ///     Must be specified in non deploy message.
        ///  <para/>
        ///     In case of deploy message contains parameters of constructor.
        ///  <para/>
        /// </remarks>
        public CallSet CallSet { get; set; }

        /// <summary>
        ///     True if internal message body must be encoded.
        /// </summary>
        public bool IsInternal { get; set; }

        /// <summary>
        ///     Signing parameters.
        /// </summary>
        public Signer Signer { get; set; }

        /// <summary>
        ///     Used in message processing with retries.
        /// </summary>
        /// <remarks>
        ///     Encoder uses the provided try index to calculate message
        ///     expiration time.
        ///  <para/>
        ///     Expiration timeouts will grow with every retry.
        ///  <para/>
        ///     Default value is 0.
        ///  <para/>
        /// </remarks>
        public byte? ProcessingTryIndex { get; set; }
    }
}
