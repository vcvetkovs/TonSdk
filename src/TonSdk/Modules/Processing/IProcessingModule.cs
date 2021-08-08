using System;
using System.Threading.Tasks;
using TonSdk.Interop.Enums;
using TonSdk.Modules.Processing.Models;

namespace TonSdk.Modules.Processing
{
    /// <summary>
    ///     Message processing module.
    /// </summary>
    /// <remarks>
    ///     This module incorporates functions related to complex message
    ///     processing scenarios.
    /// </remarks>
    public interface IProcessingModule
    {
        /// <summary>
        ///     Sends message to the network.
        /// </summary>
        /// <remarks>
        ///     Sends message to the network and returns the last generated shard block of the
        ///     destination account before the message was sent. It will be required later for
        ///     message processing.
        /// </remarks>
        Task<ResultOfSendMessage> SendMessage<T>(ParamsOfSendMessage @params, Action<T, FunctionExecutionStatus> callback = null);

        /// <summary>
        ///     Performs monitoring of the network for the result transaction
        ///     of the external inbound message processing.
        /// </summary>
        /// <remarks>
        ///     <see cref="ParamsOfWaitForTransaction.SendEvents"/> enables intermediate events,
        ///     such as <see cref="Enums.ProcessingEvent.WillFetchNextBlock"/>,
        ///     <see cref="Enums.ProcessingEvent.FetchNextBlockFailed"/> that may be useful for
        ///     logging of new shard blocks creation during message processing.
        ///  <para/>
        ///     Note that presence of the <see cref="ParamsOfWaitForTransaction.Abi"/> parameter
        ///     is critical for ABI compliant contracts.
        ///     Message processing uses drastically different strategy for processing message 
        ///     for contracts which ABI includes \"expire\" header.
        ///  <para/>
        ///   When the ABI header <c>expire</c> is present, the processing uses
        ///   `message expiration` strategy:
        ///   
        ///   <list type="bullet">
        ///    <item>
        ///       The maximum block gen time is set to
        ///       <c>message_expiration_time + transaction_wait_timeout</c>.
        ///    </item>
        ///    <item>
        ///       When maximum block gen time is reached the processing will
        ///       be finished with <see cref="Enums.ProcessingErrorCode.MessageExpired"/> error.
        ///    </item>
        ///   </list>
        ///  <para/>
        ///     When the ABI header <c>expire</c> isn't present or 
        ///     <see cref="ParamsOfWaitForTransaction.Abi"/> parameter isn't specified, the processing
        ///     uses `transaction waiting` strategy:
        ///     
        ///   <list type="bullet">
        ///    <item>
        ///     The maximum block gen time is set to
        ///     <c>now() + transaction_wait_timeout</c>.
        ///    </item>
        ///    <item>
        ///     If maximum block gen time is reached and no result transaction is found
        ///     the processing will exit with an error.
        ///    </item>
        ///   </list>
        ///  <para/>
        /// </remarks>
        Task<ResultOfProcessMessage> WaitForTransaction<T>(ParamsOfWaitForTransaction @params, Action<T, FunctionExecutionStatus> callback = null);

        /// <summary>
        ///     Creates message, sends it to the network and monitors its processing.
        /// </summary>
        /// <remarks>
        ///     Creates ABI-compatible message,
        ///     sends it to the network and monitors for the result transaction.
        ///     Decodes the output messages's bodies.
        ///  <para/>
        ///     If contract's ABI includes "expire" header then
        ///     SDK implements retries in case of unsuccessful message delivery within the expiration
        ///     timeout: SDK recreates the message, sends it and processes it again. 
        ///  <para/>
        ///     The intermediate events, such as
        ///     <see cref="Enums.ProcessingEvent.WillFetchFirstBlock"/>,
        ///     <see cref="Enums.ProcessingEvent.WillSend"/>,
        ///     <see cref="Enums.ProcessingEvent.DidSend"/>,
        ///     <see cref="Enums.ProcessingEvent.WillFetchNextBlock"/>,
        ///     etc - are switched on/off by <see cref="ParamsOfProcessMessage.SendEvents"/> flag
        ///     and logged into the supplied callback function.
        ///  <para/>
        ///     The retry configuration parameters are defined in the client's
        ///     <see cref="Configs.NetworkConfig"/> and <see cref="Configs.AbiConfig"/>.
        ///  <para/>
        ///     If contract's ABI does not include "expire" header
        ///     then, if no transaction is found within the network timeout (see config parameter ), exits with
        ///     error.
        ///  <para/>
        /// </remarks>
        Task<ResultOfProcessMessage> ProcessMessage(ParamsOfProcessMessage @params);
    }
}
