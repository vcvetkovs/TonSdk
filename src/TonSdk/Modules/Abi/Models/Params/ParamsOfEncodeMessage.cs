namespace TonSdk.Modules.Abi.Models
{
    public struct ParamsOfEncodeMessage<TSigner>
    {
        /// <summary>
        /// Contract ABI.
        /// </summary>
        public Abi Abi { get; set; }

        /// <summary>
        /// Target address the message will be sent to.
        /// Must be specified in case of non-deploy message.
        /// </summary>
        public string? Address { get; set; }

        /// <summary>
        /// Deploy parameters.
        /// Must be specified in case of deploy message.
        /// </summary>
        public DeploySet? DeploySet { get; set; }

        /// <summary>
        /// Function call parameters.
        /// Must be specified in case of non-deploy message.
        /// In case of deploy message it is optional and contains parameters
        /// of the functions that will to be called upon deploy transaction.
        /// </summary>
        public CallSet? CallSet { get; set; }

        /// <summary>
        /// Signing parameters.
        /// </summary>
        public TSigner Signer { get; set; }

        /// <summary>
        /// Processing try index.
        /// Used in message processing with retries(if contract's ABI includes "expire" header).
        /// Encoder uses the provided try index to calculate message
        /// expiration time. The 1st message expiration time is specified in
        /// Client config.
        /// 
        /// Expiration timeouts will grow with every retry.
        /// Retry grow factor is set in Client config:
        /// &lt;.....add config parameter with default value here>
        /// 
        /// Default value is 0.
        /// </summary>
        public byte? ProcessingTryIndex { get; set; }
    }
}
