using TonSdk.Interop.Models;

namespace TonSdk.Modules.Processing.Models
{
    public abstract class ProcessingEvent
    {
        /// <summary>
        ///     Notifies the application that the account's current
        ///     shard block will be fetched from the network. <para />
        ///     
        ///     This step is performed before the message sending
        ///     so that sdk knows starting from which block it will
        ///     search for the transaction.
        /// </summary>
        /// <remarks>
        ///     Fetched block will be used later in waiting phase.
        /// </remarks>
        public class WillFetchFirstBlock : ProcessingEvent
        {
        }

        /// <summary>
        ///     Notifies the app that the client has failed to fetch
        ///     the account's current shard block.
        /// </summary>
        /// <remarks>
        ///     This may happen due to the network issues.
        ///     Receiving this event means that message processing will
        ///     not proceed - message was not sent, and Developer can try to run
        ///     <see cref="IProcessingModule.ProcessMessage(ParamsOfProcessMessage)"/> again,
        ///     in the hope that the connection is restored.
        /// </remarks>
        public class FetchFirstBlockFailed : ProcessingEvent
        {
            public ClientError Error { get; set; }
        }

        /// <summary>
        ///     Notifies the app that the message will be sent to the network.
        /// </summary>
        /// <remarks>
        ///     This event means that the account's current shard block was
        ///     successfully fetched and the message was successfully created
        ///     (<see cref="Abi.IAbiModule.EncodeMessage(Abi.Models.ParamsOfEncodeMessage)"/> function was executed successfully).
        /// </remarks>
        public class WillSend : ProcessingEvent
        {
            public string ShardBlockId { get; set; }

            public string MessageId { get; set; }

            public string Message { get; set; }
        }

        /// <summary>
        ///     Notifies the app that the message was sent to the network,
        ///     i.e `processing.send_message` was successfuly executed.
        ///     Now, the message is in the blockchain. <para />
        /// </summary>
        /// <remarks>
        ///     If Application exits at this phase, Developer needs to proceed
        ///     with processing after the application is restored with
        ///     <see cref="IProcessingModule.WaitForTransaction"/> function,
        ///     passing shard_block_id and message from this event. <para />
        ///     
        ///     Do not forget to specify abi of your contract as well,
        ///     it is crucial for proccessing.
        ///     See <see cref="IProcessingModule.WaitForTransaction"/> documentation.
        /// </remarks>
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
        ///     node. <para />
        /// </summary>
        /// <remarks>
        ///     If Application exits at this phase, Developer needs to proceed
        ///     with processing after the application is restored with
        ///     <see cref="IProcessingModule.WaitForTransaction"/> function,
        ///     passing shard_block_id and message from this event. <para />
        ///     
        ///     Do not forget to specify abi of your contract as well,
        ///     it is crucial for proccessing.
        ///     See <see cref="IProcessingModule.WaitForTransaction"/> documentation.
        /// </remarks>
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
        ///     procedure. <para />
        ///     
        ///     If Application exits at this phase, Developer needs to proceed
        ///     with processing after the application is restored with
        ///     <see cref="IProcessingModule.WaitForTransaction"/> function,
        ///     passing shard_block_id and message from this event. <para />
        ///     
        ///     Do not forget to specify abi of your contract as well,
        ///     it is crucial for proccessing.
        ///     See <see cref="IProcessingModule.WaitForTransaction"/> documentation.
        /// </remarks>
        public class WillFetchNextBlock : ProcessingEvent
        {
            public string ShardBlockId { get; set; }

            public string MessageId { get; set; }

            public string Message { get; set; }
        }

        /// <summary>
        ///     Notifies the app that the next block can't be fetched.
        /// </summary>
        /// <remarks>
        ///     If no block was fetched within <see cref="Configs.NetworkConfig.WaitForTimeout"/> then processing stops.
        ///     This may happen when the shard stops, or there are other network issues. <para />
        ///     
        ///     In this case Developer should resume message processing with
        ///     <see cref="IProcessingModule.WaitForTransaction"/>, passing
        ///     shard_block_id, message and contract abi to it.
        ///     Note that passing ABI is crucial, because it will influence the processing strategy.
        ///     Another way to tune this is to specify long timeout in <see cref="Configs.NetworkConfig.WaitForTimeout"/>.
        /// </remarks>
        public class FetchNextBlockFailed : ProcessingEvent
        {
            public string ShardBlockId { get; set; }

            public string MessageId { get; set; }

            public string Message { get; set; }

            public ClientError Error { get; set; }
        }

        /// <summary>
        ///     Notifies the app that the message was not executed within expire
        ///     timeout on-chain and will never be because it is already expired. <para/>
        ///     
        ///     The expiration timeout can be configured with <see cref="Configs.AbiConfig"/> parameters. <para/>
        ///     
        ///     This event occurs only for the contracts which ABI includes "expire" header.
        /// </summary>
        /// <remarks>
        ///     If Application specifies <see cref="Configs.NetworkConfig.MessageRetriesCount"/> > 0,
        ///     then <see cref="IProcessingModule.ProcessMessage(ParamsOfProcessMessage)"/>
        ///     will perform retries: will create a new message and send it again and repeat 
        ///     it untill it reaches the maximum retries count or receives a successful result. 
        ///     All the processing events will be repeated.
        /// </remarks>
        public class MessageExpired : ProcessingEvent
        {
            public string MessageId { get; set; }

            public string Message { get; set; }

            public ClientError Error { get; set; }
        }
    }
}
