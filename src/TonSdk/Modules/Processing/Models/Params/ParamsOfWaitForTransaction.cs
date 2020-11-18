namespace TonSdk.Modules.Processing.Models
{
    public struct ParamsOfWaitForTransaction
    {
        /// <summary>
        /// Optional ABI for decoding the transaction result.
        /// 
        /// If it is specified then the output messages' bodies will be
        /// decoded according to this ABI.
        /// 
        /// The `abi_decoded` result field will be filled out.
        /// </summary>
        public Abi.Models.Abi? Abi { get; set; }

        /// <summary>
        /// Message BOC. Encoded with `base64`.
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// The last generated block id of the destination account shard before the message was sent.
        /// 
        /// You must provide the same value as the `send_message` has returned.
        /// </summary>
        public string ShardBlockId { get; set; }

        /// <summary>
        /// Flag that enables/disables intermediate events.
        /// </summary>
        public bool SendEvents { get; set; }
    }
}
