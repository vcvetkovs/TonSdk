namespace EverscaleSdk.Modules.Processing.Models
{
    public struct ResultOfSendMessage
    {
        /// <summary>
        ///     The last generated shard block of the message destination account before the
        ///     message was sent.
        /// </summary>
        /// <remarks>
        ///     This block id must be used as a parameter of the
        ///     <see cref="IProcessingModule.WaitForTransaction{T}(ParamsOfWaitForTransaction, System.Action{T, Interop.Enums.FunctionExecutionStatus})"/>.
        /// </remarks>
        public string ShardBlockId { get; set; }

        /// <summary>
        ///     This list id must be used as a parameter of the
        ///     <see cref="IProcessingModule.WaitForTransaction{T}(ParamsOfWaitForTransaction, System.Action{T, Interop.Enums.FunctionExecutionStatus})"/>.
        /// </summary>
        public string[] SendingEndpoints { get; set; }
    }
}
