namespace EverscaleSdk.Modules.Processing.Models
{
    public struct ParamsOfWaitForTransaction
    {
        /// <summary>
        ///     Optional ABI for decoding the transaction result.
        /// </summary>
        /// <remarks>
        ///     If it is specified then the output messages' bodies will be
        ///     decoded according to this ABI.
        ///     
        ///     The <c>abi_decoded</c> result field will be filled out.
        /// </remarks>
        public Abi.Models.Abi? Abi { get; set; }

        /// <summary>
        ///     Message BOC.
        /// </summary>
        /// <remarks>
        ///     Encoded with <c>base64</c>.
        /// </remarks>
        public string Message { get; set; }

        /// <summary>
        ///     The last generated block id of the destination account shard before the message was sent.
        /// </summary>
        /// <remarks>
        ///     You must provide the same value as the
        ///     <see cref="IProcessingModule.SendMessage{T}(ParamsOfSendMessage, System.Action{T, Interop.Enums.FunctionExecutionStatus})"/>
        ///     has returned.
        /// </remarks>
        public string ShardBlockId { get; set; }

        /// <summary>
        ///     Flag that enables/disables intermediate events.
        /// </summary>
        public bool SendEvents { get; set; }

        /// <summary>
        ///     Use this field to get more informative errors.
        /// </summary>
        /// <remarks>
        ///     Provide the same value as the
        ///     <see cref="IProcessingModule.SendMessage{T}(ParamsOfSendMessage, System.Action{T, Interop.Enums.FunctionExecutionStatus})"/>
        ///     has returned.
        ///     If the message was not delivered (expired), SDK will log the endpoint URLs, used for its sending.
        /// </remarks>
        public string[] SendingEndpoints { get; set; }
    }
}
