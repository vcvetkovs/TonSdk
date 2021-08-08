using TonSdk.Interop.Models;

namespace TonSdk.Modules.Processing.Models
{
    public abstract class ProcessingEvent
    {
        /// <summary>
        ///     Notifies the app that the current shard block will be fetched
        ///     from the network.
        /// </summary>
        /// <remarks>
        ///     Fetched block will be used later in waiting phase.
        /// </remarks>
        public class WillFetchFirstBlock : ProcessingEvent
        {
        }

        /// <summary>
        ///     Notifies the app that the client has failed to fetch current
        ///     shard block.
        /// </summary>
        /// <remarks>
        ///     Message processing has finished.
        /// </remarks>
        public class FetchFirstBlockFailed : ProcessingEvent
        {
            public ClientError Error { get; set; }
        }

        /// <summary>
        ///     Notifies the app that the message will be sent to the network.
        /// </summary>
        public class WillSend : ProcessingEvent
        {
            public string ShardBlockId { get; set; }

            public string MessageId { get; set; }

            public string Message { get; set; }
        }

        /// <summary>
        ///     Notifies the app that the message was sent to the network.
        /// </summary>
        public class DidSend : ProcessingEvent
        {
            public string ShardBlockId { get; set; }

            public string MessageId { get; set; }

            public string Message { get; set; }
        }

        /// <summary>
        ///     Notifies the app that the sending operation was failed with
        ///     network error. <para/>
        ///     
        ///     Nevertheless the processing will be continued at the waiting
        ///     phase because the message possibly has been delivered to the
        ///     node.
        /// </summary>
        public class SendFailed : ProcessingEvent
        {
            public string ShardBlockId { get; set; }

            public string MessageId { get; set; }

            public string Message { get; set; }

            public ClientError Error { get; set; }
        }

        /// <summary>
        ///     Notifies the app that the next shard block will be fetched
        ///     from the network.
        /// </summary>
        /// <remarks>
        ///     Event can occurs more than one time due to block walking
        ///     procedure.
        /// </remarks>
        public class WillFetchNextBlock : ProcessingEvent
        {
            public string ShardBlockId { get; set; }

            public string MessageId { get; set; }

            public string Message { get; set; }
        }

        /// <summary>
        ///     Notifies the app that the next block can't be fetched due to
        ///     error. <para/>
        ///     
        ///     Processing will be continued from encoding phase after
        ///     <c>expiration_retries_timeout</c>.
        /// </summary>
        public class FetchNextBlockFailed : ProcessingEvent
        {
            public string ShardBlockId { get; set; }

            public string MessageId { get; set; }

            public string Message { get; set; }

            public ClientError Error { get; set; }
        }

        /// <summary>
        ///     Notifies the app that the message was expired. <para/>
        ///     
        ///     Event occurs for contracts which ABI includes header "expire". <para/>
        ///     
        ///     Processing will be continued from encoding phase after
        ///     <c>expiration_retries_timeout</c>. 
        /// </summary>
        public class MessageExpired : ProcessingEvent
        {
            public string MessageId { get; set; }

            public string Message { get; set; }

            public ClientError Error { get; set; }
        }
    }
}
