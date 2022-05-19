using System.Threading.Tasks;
using TonSdk.Common;
using TonSdk.Modules.Net.Models;

namespace TonSdk.Modules.Net
{
    /// <summary>
    ///     Network access.
    /// </summary>
    public interface INetModule
    {
        /// <summary>
        ///     Performs DAppServer GraphQL query.
        /// </summary>
        Task<ResultOfQuery> Query(ParamsOfQuery @params);

        /// <summary>
        ///     Performs multiple queries per single fetch.
        /// </summary>
        Task<ResultOfBatchQuery> BatchQuery(ParamsOfBatchQuery @params);

        /// <summary>
        ///     Queries collection data.
        /// </summary>
        /// <remarks>
        ///      Queries data that satisfies the <see cref="ParamsOfQueryCollection.Filter"/> conditions,
        ///      limits the number of returned records and orders them. <para/>
        ///     
        ///      The projection fields are limited to <see cref="ParamsOfQueryCollection.Result"/> fields
        /// </remarks>
        Task<ResultOfQueryCollection> QueryCollection(ParamsOfQueryCollection @params);

        /// <summary>
        ///     Aggregates collection data.
        /// </summary>
        /// <remarks>
        ///     Aggregates values from the specified <see cref="ParamsOfAggregateCollection.Fields"/> for records
        ///     that satisfies the <see cref="ParamsOfAggregateCollection.Filter"/> conditions
        /// </remarks>
        Task<ResultOfAggregateCollection> AggregateCollection(ParamsOfAggregateCollection @params);

        /// <summary>
        ///     Returns an object that fulfills the conditions or waits for its appearance
        /// </summary>
        /// <remarks>
        ///     Triggers only once. <para/>
        ///     
        ///     If object that satisfies the <see cref="ParamsOfWaitForCollection.Filter"/> conditions
        ///     already exists - returns it immediately. <para/>
        ///     
        ///     If not - waits for insert/update of data within the specified
        ///     <see cref="ParamsOfWaitForCollection.Timeout"/>, and returns it. <para/>
        ///     
        ///     The projection fields are limited to <see cref="ParamsOfWaitForCollection.Result"/> fields
        /// </remarks>
        Task<ResultOfWaitForCollection> WaitForCollection(ParamsOfWaitForCollection @params);

        /// <summary>
        ///     Creates a collection subscription.
        /// </summary>
        /// <remarks>
        ///     Triggers for each insert/update of data that satisfies
        ///     the <see cref="ParamsOfSubscribeCollection.Filter"/> conditions.
        ///  <para/>
        ///     The projection fields are limited to <see cref="ParamsOfSubscribeCollection.Result"/> fields.
        ///  <para/>
        ///     The subscription is a persistent communication channel between
        ///     client and Free TON Network.
        ///  <para/>
        ///     All changes in the blockchain will be reflected in realtime.
        ///  <para/>
        ///     Changes means inserts and updates of the blockchain entities.
        ///  <para/>
        ///     Important Notes on Subscriptions:
        ///     
        ///         Unfortunately sometimes the connection with the network brakes down.
        ///         In this situation the library attempts to reconnect to the network.
        ///         This reconnection sequence can take significant time.
        ///         All of this time the client is disconnected from the network.
        ///     <para/>
        ///         Bad news is that all blockchain changes that happened while
        ///         the client was disconnected are lost.
        ///     <para/>
        ///         Good news is that the client report errors to the callback when
        ///         it loses and resumes connection.
        ///     <para/>
        ///         So, if the lost changes are important to the application then
        ///         the application must handle these error reports.
        ///     <para/>
        ///         Library reports errors with <c>responseType</c> == 101
        ///         and the error object passed via <c>params</c>.
        ///     <para/>
        ///         When the library has successfully reconnected
        ///         the application receives callback with
        ///         <c>responseType</c> == 101 and <c>params.code</c> == 614 (NetworkModuleResumed).
        ///     <para/>
        ///         Application can use several ways to handle this situation:
        ///         <list type="bullet">
        ///           <item>
        ///             <term>
        ///                 If application monitors changes for the single blockchain
        ///                 object (for example specific account)
        ///             </term>
        ///             <description>
        ///                 application can perform a query for this object and handle actual
        ///                 data as a regular data from the subscription.
        ///             </description>
        ///           </item>
        ///           <item>
        ///             <term>
        ///                 If application monitors sequence of some blockchain objects
        ///                 (for example transactions of the specific account)
        ///             </term>
        ///             <description>
        ///                 application must refresh all cached (or visible to user)
        ///                 lists where this sequences presents.
        ///             </description>
        ///           </item>
        ///         </list>
        ///     <para/>
        ///  <para/>
        /// </remarks>
        AsyncDataStream<string> SubscribeCollection(ParamsOfSubscribeCollection @params);

        /// <summary>
        ///     Creates a subscription.
        /// </summary>
        /// <remarks>
        ///     The subscription is a persistent communication channel between
        ///     client and Everscale Network. <para />
        /// 
        ///     <c>Important Notes on Subscriptions</c> <para />
        ///     
        ///     Unfortunately sometimes the connection with the network brakes down.
        ///     In this situation the library attempts to reconnect to the network.
        ///     This reconnection sequence can take significant time.
        ///     All of this time the client is disconnected from the network. <para />
        ///     
        ///     Bad news is that all changes that happened while
        ///     the client was disconnected are lost. <para />
        ///     
        ///     Good news is that the client report errors to the callback when
        ///     it loses and resumes connection. <para />
        ///
        ///     So, if the lost changes are important to the application then
        ///     the application must handle these error reports. <para />
        ///
        ///     Library reports errors with <c>responseType</c> == 101
        ///     and the error object passed via <c>params</c>. <para />
        ///     
        ///     When the library has successfully reconnected
        ///     the application receives callback with
        ///     <c>responseType</c> == 101
        ///     and <c>params.code</c> == 614 (NetworkModuleResumed). <para />
        ///
        ///     Application can use several ways to handle this situation:
        ///     <list type="bullet">
        ///         <item>
        ///             <term>
        ///                 If application monitors changes for the single
        ///                 object (for example specific account)
        ///             </term>
        ///             <description>
        ///                 application can perform a query for this object and
        ///                 handle actual data as a regular data from the
        ///                 subscription.
        ///             </description>
        ///         </item>
        ///         <item>
        ///             <term>
        ///                 If application monitors sequence of some objects
        ///                 (for example transactions of the specific account)
        ///             </term>
        ///             <description>
        ///                 application must refresh all cached
        ///                 (or visible to user) lists where this sequences
        ///                 presents.
        ///             </description>
        ///         </item>
        ///     </list>
        /// </remarks>
        AsyncDataStream<string> Subscribe(ParamsOfSubscribe @params);

        /// <summary>
        ///     Suspends network module to stop any network activity.
        /// </summary>
        Task Suspend();

        /// <summary>
        ///     Resumes network module to enable network activity.
        /// </summary>
        Task Resume();

        /// <summary>
        ///     Returns ID of the last block in a specified account shard.
        /// </summary>
        public Task<ResultOfFindLastShardBlock> FindLastShardBlock(ParamsOfFindLastShardBlock @params);

        /// <summary>
        ///     Requests the list of alternative endpoints from server.
        /// </summary>
        public Task<EndpointsSet> FetchEndpoints();

        /// <summary>
        ///     Sets the list of endpoints to use on reinit.
        /// </summary>
        public Task SetEndpoints(EndpointsSet @params);

        /// <summary>
        ///     Requests the list of alternative endpoints from server.
        /// </summary>
        Task<ResultOfGetEndpoints> GetEndpoints();

        /// <summary>
        ///     *Attention* this query retrieves data from 'Counterparties' service which is not supported in
        ///     the opensource version of DApp Server (and will not be supported) as well as in TON OS SE (will be
        ///     supported in SE in future),
        ///     but is always accessible via [TON OS Devnet/Mainnet
        ///     Clouds](https://docs.ton.dev/86757ecb2/p/85c869-networks)
        /// </summary>
        Task<ResultOfQueryCollection> QueryCounterparties(ParamsOfQueryCounterparties @params);

        /// <summary>
        ///     Performs recursive retrieval of a transactions tree produced by a specific message:
        ///     in_msg -> dst_transaction -> out_messages -> dst_transaction -> ... <para/>
        ///     
        ///     If the chain of transactions execution is in progress while the function is running,
        ///     it will wait for the next transactions to appear until the full tree or more than 50 transactions
        ///     are received. <para/>
        /// 
        ///     All the retrieved messages and transactions are
        ///     into <see cref="ResultOfQueryTransactionTree.Messages"/>
        ///     and <see cref="ResultOfQueryTransactionTree.Transactions"/> respectively. <para/>
        ///     
        ///     Function reads transactions layer by layer, by pages of 20 transactions.
        /// </summary>
        /// <remarks>
        ///     The retrieval prosess goes like this:
        ///     Let's assume we have an infinite chain of transactions and each transaction generates 5 messages.
        ///     <list type="number">
        ///         <item>
        ///             Retrieve 1st message (input parameter) and corresponding transaction - put it into result.
        ///             It is the first level of the tree of transactions - its root.
        ///             Retrieve 5 out message ids from the transaction for next steps.
        ///         </item>
        ///         <item>
        ///             Retrieve 5 messages and corresponding transactions on the 2nd layer. Put them into result.
        ///             Retrieve 5*5 out message ids from these transactions for next steps
        ///         </item>
        ///         <item>
        ///             Retrieve 20 (size of the page) messages and transactions (3rd layer) and 20*5=100 message ids
        ///             (4th layer).
        ///             + 25 message ids of the 4th layer + 75 message ids of the 5th layer.
        ///         </item>
        ///         <item>
        ///             Retrieve 20 more messages and 20 more transactions of the 4th layer + 100 more message ids of the
        ///             5th layer.
        ///         </item>
        ///         <item>
        ///             Now we have 1+5+20+20+20 = 66 transactions, which is more than 50. Function exits with the tree
        ///             of 1m->1t->5m->5t->25m->25t->35m->35t. If we see any message ids in the last transactions out_msgs,
        ///             which don't have corresponding messages in the function result, it means that the full tree was not
        ///             received and wemneed to continue iteration. 
        ///         </item>
        ///     </list>
        /// 
        ///     To summarize, it is guaranteed that each message in 
        ///     <see cref="ResultOfQueryTransactionTree.Messages"/>
        ///     has the corresponding transaction in the
        ///     <see cref="ResultOfQueryTransactionTree.Transactions"/>. <para />
        ///     
        ///     But there is no guarantee that all messages from transactions
        ///     <see cref="TransactionNode.OutMsgs"/> are
        ///     presented in <see cref="ResultOfQueryTransactionTree.Messages"/>. <para />
        ///     
        ///     So the application has to continue retrieval for missing messages if it requires.
        ///  <para/>
        /// </remarks>
        Task<ResultOfQueryTransactionTree> QueryTransactionTree(ParamsOfQueryTransactionTree @params);

        /// <summary>
        ///     Block iterator uses robust iteration methods that guaranties that every
        ///     block in the specified range isn't missed or iterated twice.
        /// </summary>
        /// <remarks>
        ///     Iterated range can be reduced with some filters:
        ///     
        ///     <list type="bullet">
        ///      <item>
        ///       <term>
        ///         start_time
        ///       </term>
        ///       <description>
        ///         the bottom time range. Only blocks with `gen_utime`
        ///         more or equal to this value is iterated.
        ///         If this parameter is omitted then there is
        ///         no bottom time edge, so all blocks since zero state is iterated.
        ///       </description>
        ///      </item>
        ///      <item>
        ///       <term>
        ///         end_time
        ///       </term>
        ///       <description>
        ///         the upper time range. Only blocks with `gen_utime`
        ///         less then this value is iterated.
        ///         If this parameter is omitted then there is
        ///         no upper time edge, so iterator never finishes.
        ///       </description>
        ///      </item>
        ///      <item>
        ///       <term>
        ///         shard_filter
        ///       </term>
        ///       <description>
        ///         workchains and shard prefixes that reduce the set of interesting
        ///         blocks. Block conforms to the shard filter if it belongs to the filter workchain
        ///         and the first bits of block's `shard` fields matches to the shard prefix.
        ///         Only blocks with suitable shard are iterated.
        ///       </description>
        ///      </item>
        ///     </list>
        ///     Items iterated is a JSON objects with block data. The minimal set of returned
        ///     fields is:
        ///         ```text
        ///            id
        ///            gen_utime
        ///            workchain_id
        ///            shard
        ///            after_split
        ///            after_merge
        ///            prev_ref {
        ///                root_hash
        ///            }
        ///            prev_alt_ref {
        ///                root_hash
        ///            }
        ///         ```
        ///     Application can request additional fields in the `result` parameter.
        ///     Application should call the `remove_iterator` when iterator is no longer required.=
        /// </remarks>
        Task<RegisteredIterator> CreateBlockIterator(ParamsOfCreateBlockIterator @params);

        /// <summary>
        ///     The iterator stays exactly at the same position where the `resume_state` was catched.
        /// </summary>
        /// <remarks>
        ///     Application should call the `remove_iterator` when iterator is no longer required.
        /// </remarks>
        Task<RegisteredIterator> ResumeBlockIterator(ParamsOfResumeBlockIterator @params);

        /// <summary>
        ///     Transaction iterator uses robust iteration methods that guaranty that every
        ///     transaction in the specified range isn't missed or iterated twice.
        /// </summary>
        /// <remarks>
        ///     Iterated range can be reduced with some filters:
        ///     
        ///     <list type="bullet">
        ///      <item>
        ///       <term>
        ///         start_time
        ///       </term>
        ///       <description>
        ///         the bottom time range. Only blocks with `gen_utime`
        ///         more or equal to this value is iterated.
        ///         If this parameter is omitted then there is
        ///         no bottom time edge, so all blocks since zero state is iterated.
        ///       </description>
        ///      </item>
        ///      <item>
        ///       <term>
        ///         end_time
        ///       </term>
        ///       <description>
        ///         the upper time range. Only blocks with `gen_utime`
        ///         less then this value is iterated.
        ///         If this parameter is omitted then there is
        ///         no upper time edge, so iterator never finishes.
        ///       </description>
        ///      </item>
        ///      <item>
        ///       <term>
        ///         shard_filter
        ///       </term>
        ///       <description>
        ///         workchains and shard prefixes that reduce the set of interesting
        ///         blocks. Block conforms to the shard filter if it belongs to the filter workchain
        ///         and the first bits of block's `shard` fields matches to the shard prefix.
        ///         Only blocks with suitable shard are iterated.
        ///       </description>
        ///      </item>
        ///      <item>
        ///       <term>
        ///         accounts_filter
        ///       </term>
        ///       <description>
        ///         set of account addresses whose transactions must be iterated.
        ///       </description>
        ///      </item>
        ///     </list> <para/>
        ///     
        ///     Note that accounts filter can conflict with shard filter so application must combine
        ///     these filters carefully. <para/>
        ///     
        ///     Iterated item is a JSON objects with transaction data. The minimal set of returned
        ///     fields is:
        ///         ```text
        ///         id
        ///         account_addr
        ///         now
        ///         balance_delta(format:DEC)
        ///         bounce { bounce_type }
        ///         in_message {
        ///             id
        ///             value(format:DEC)
        ///             msg_type
        ///             src
        ///         }
        ///         out_messages {
        ///             id
        ///             value(format:DEC)
        ///             msg_type
        ///             dst
        ///         }
        ///         ``` <para/>
        ///     
        ///     Application can request an additional fields in the <c>result</c> parameter. <para/>
        ///     
        ///     Another parameter that affects on the returned fields is the <c>include_transfers</c>.
        ///     When this parameter is <c>true</c> the iterator computes and adds <c>transfer</c> field containing
        ///     list of the useful <c>TransactionTransfer</c> objects.
        ///     Each transfer is calculated from the particular message related to the transaction
        ///     and has the following structure:
        ///     
        ///     <list type="bullet">
        ///      <item>
        ///       <term>
        ///         message
        ///       </term>
        ///       <description>
        ///         source message identifier.
        ///       </description>
        ///      </item>
        ///      <item>
        ///       <term>
        ///         isBounced
        ///       </term>
        ///       <description>
        ///         indicates that the transaction is bounced, which means the value will be returned back
        ///         to the sender.
        ///       </description>
        ///      </item>
        ///      <item>
        ///       <term>
        ///         isDeposit
        ///       </term>
        ///       <description>
        ///         indicates that this transfer is the deposit (true) or withdraw (false).
        ///       </description>
        ///      </item>
        ///      <item>
        ///       <term>
        ///         counterparty
        ///       </term>
        ///       <description>
        ///         account address of the transfer source or destination depending on <c>isDeposit</c>.
        ///       </description>
        ///      </item>
        ///      <item>
        ///       <term>
        ///         value
        ///       </term>
        ///       <description>
        ///         amount of nano tokens transferred. The value is represented as a decimal string
        ///         because the actual value can be more precise than the JSON number can represent. Application
        ///         must use this string carefully – conversion to number can follow to loose of precision.
        ///       </description>
        ///      </item>
        ///     </list> <para/>
        ///     
        ///     Application should call the `remove_iterator` when iterator is no longer required.=
        /// </remarks>
        Task<RegisteredIterator> CreateTransactionIterator(ParamsOfCreateTransactionIterator @params);

        /// <summary>
        ///     The iterator stays exactly at the same position where the
        ///     <see cref="ParamsOfResumeTransactionIterator.ResumeState"/> was caught. <para/>
        ///     
        ///     Note that <see cref="ParamsOfResumeTransactionIterator.ResumeState"/>
        ///     doesn't store the account filter. <para/>
        ///     
        ///     If the application requires to use the same account filter as it was when
        ///     the iterator was created then the application
        ///     must pass the account filter again in <see cref="ParamsOfResumeTransactionIterator.AccountsFilter"/> parameter.
        /// </summary>
        /// <remarks>
        ///     Application should call the <see cref="RemoveIterator(RegisteredIterator)"/> when iterator is no longer required.
        /// </remarks>
        Task<RegisteredIterator> ResumeTransactionIterator(ParamsOfResumeTransactionIterator @params);

        /// <summary>
        ///     In addition to available items this function returns
        ///     the <see cref="ResultOfIteratorNext.HasMore"/> flag
        ///     indicating that the iterator isn't reach the end of the iterated range yet.
        /// </summary>
        /// <remarks>
        ///     This function can return the empty list of available items but
        ///     indicates that there are more items is available.
        ///     This situation appears when the iterator doesn't reach iterated range
        ///     but database doesn't contains available items yet. <para/>
        ///     
        ///     If application requests resume state in `return_resume_state` parameter
        ///     then this function returns `resume_state` that can be used later to
        ///     resume the iteration from the position after returned items. <para/>
        ///     
        ///     The structure of the items returned depends on the iterator used.
        ///     See the description to the appropriated iterator creation function.
        /// </remarks>
        Task<ResultOfIteratorNext> IteratorNext(ParamsOfIteratorNext @params);

        /// <summary>
        ///     Frees all resources allocated in library to serve iterator.
        /// </summary>
        /// <remarks>
        ///     Application should call the <see cref="RemoveIterator(RegisteredIterator)"/> when iterator is no longer required.
        /// </remarks>
        Task RemoveIterator(RegisteredIterator @params);
    }
}
