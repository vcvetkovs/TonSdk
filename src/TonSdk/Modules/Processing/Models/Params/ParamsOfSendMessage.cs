namespace TonSdk.Modules.Processing.Models
{
    public struct ParamsOfSendMessage
    {
        /// <summary>
        /// Message BOC.
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Optional message ABI.
        /// 
        /// If this parameter is specified and the message has the
        /// `expire` header then expiration time will be checked against
        /// the current time to prevent an unnecessary sending of already expired message.
        /// 
        /// The `message already expired` error will be returned in this
        /// case.
        /// 
        /// Note that specifying `abi` for ABI compliant contracts is
        /// strongly recommended due to choosing proper processing
        /// strategy.
        /// </summary>
        public Abi.Models.Abi? Abi { get; set; }

        // Flag for requesting events sending
        public bool SendEvents { get; set; }
    }
}
