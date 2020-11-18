namespace TonSdk.Modules.Processing.Enums
{
    public enum ProcessingEvent
    {
        Unknown,

        /// <summary>
        /// Notifies the app that the current shard block will be fetched
        /// from the network.
        /// 
        /// Fetched block will be used later in waiting phase.
        /// </summary>
        WillFetchFirstBlock,

        /// <summary>
        /// Notifies the app that the client has failed to fetch current
        /// shard block.
        /// 
        /// Message processing has finished.
        /// </summary>
        FetchFirstBlockFailed,

        /// <summary>
        /// Notifies the app that the message will be sent to the network.
        /// </summary>
        WillSend,

        /// <summary>
        /// Notifies the app that the message was sent to the network.
        /// </summary>
        DidSend,

        /// <summary>
        /// Notifies the app that the sending operation was failed with
        /// network error.
        /// 
        /// Nevertheless the processing will be continued at the waiting
        /// phase because the message possibly has been delivered to the
        /// node.
        /// </summary>
        SendFailed,

        /// <summary>
        /// Notifies the app that the next shard block will be fetched
        /// from the network.
        /// 
        /// Event can occurs more than one time due to block walking
        /// procedure.
        /// </summary>
        WillFetchNextBlock,

        /// <summary>
        /// Notifies the app that the next block can't be fetched due to
        /// error.
        /// 
        /// Processing will be continued after `network_resume_timeout`.
        /// </summary>
        FetchNextBlockFailed,

        /// <summary>
        /// Notifies the app that the message was expired.
        /// 
        /// Event occurs for contracts which ABI includes header "expire"
        /// 
        /// Processing will be continued from encoding phase after
        /// `expiration_retries_timeout`.
        /// </summary>
        MessageExpired
    }
}
