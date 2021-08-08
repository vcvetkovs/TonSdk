namespace TonSdk.Modules.Processing.Models
{
    public struct ParamsOfSendMessage
    {
        /// <summary>
        ///     Message BOC.
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        ///     Optional message ABI.
        /// </summary>
        /// <remarks>
        ///     If this parameter is specified and the message has the
        ///     <c>expire</c> header then expiration time will be checked against
        ///     the current time to prevent unnecessary sending of already expired message.
        ///     
        ///     The <see cref="Enums.ProcessingErrorCode.MessageAlreadyExpired"/> error will be returned in this
        ///     case.
        ///  <para/>
        ///     Note, that specifying <c>abi</c> for ABI compliant contracts is
        ///     strongly recommended, so that proper processing strategy can be
        ///     chosen.
        ///  <para/>
        /// </remarks>
        public Abi.Models.Abi? Abi { get; set; }

        /// <summary>
        ///     Flag for requesting events sending.
        /// </summary>
        public bool SendEvents { get; set; }
    }
}
