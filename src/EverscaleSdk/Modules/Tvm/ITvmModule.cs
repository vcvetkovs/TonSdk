using System.Threading.Tasks;
using EverscaleSdk.Modules.Tvm.Models;

namespace EverscaleSdk.Modules.Tvm
{
    public interface ITvmModule
    {
        /// <summary>
        ///     Performs all the phases of contract execution on Transaction Executor -
        ///     the same component that is used on Validator Nodes.
        /// </summary>
        /// <remarks>
        ///     Can be used for contract debugging, to find out the reason why a message was not delivered
        ///     successfully. <para/>
        ///     
        ///     Validators throw away the failed external inbound messages (if they failed bedore <c>ACCEPT</c>) in the
        ///     real network.
        ///     
        ///     This is why these messages are impossible to debug in the real network.
        ///     With the help of run_executor you can do that. In fact,
        ///     <see cref="Processing.IProcessingModule.ProcessMessage(Processing.Models.ParamsOfProcessMessage)"/> function
        ///     performs local check with <see cref="RunExecutor(ParamsOfRunExecutor)"/>
        ///     if there was no transaction as a result of processing
        ///     and returns the error, if there is one. <para/>
        ///     
        ///     Another use case to use <see cref="RunExecutor(ParamsOfRunExecutor)"/> is to estimate fees for message execution.
        ///     Set <see cref="AccountForExecutor.Account.UnlimitedBalance"/> 
        ///     to <c>true</c> so that emulation will not depend on the actual balance.
        ///     This may be needed to calculate deploy fees for an account that does not exist yet.
        ///     JSON with fees is in <c>fees</c> field of the result. <para/>
        ///     
        ///     One more use case - you can produce the sequence of operations,
        ///     thus emulating the sequential contract calls locally.
        ///     And so on. <para/>
        ///     
        ///     Transaction executor requires account BOC (bag of cells) as a parameter.
        ///     To get the account BOC - use <see cref="Net.INetModule.Query(Net.Models.ParamsOfQuery)"/>
        ///     method to download it from GraphQL API (field <c>boc</c> of <c>account</c>)
        ///     or generate it with <see cref="Abi.IAbiModule.EncodeAccount(Abi.Models.ParamsOfEncodeAccount)"/> method.
        ///     Also it requires message BOC.
        ///     To get the message BOC - use <see cref="Abi.IAbiModule.EncodeMessage(Abi.Models.ParamsOfEncodeMessage)"/>
        ///     or <see cref="Abi.IAbiModule.EncodeInternalMessage(Abi.Models.ParamsOfEncodeInternalMessage)"/>. <para/>
        ///     
        ///     If you need this emulation to be as precise as possible (for instance - emulate transaction
        ///     with particular lt in particular block or use particular blockchain config,
        ///     downloaded from a particular key block - then specify <see cref="ParamsOfRunExecutor.ExecutionOptions"/>
        ///     parameter. <para/>
        ///     
        ///     If you need to see the aborted transaction as a result, not as an error, set
        ///     <see cref="ParamsOfRunExecutor.SkipTransactionCheck"/> to <c>true</c>.
        /// </remarks>
        Task<ResultOfRunExecutor> RunExecutor(ParamsOfRunExecutor @params);

        /// <summary>
        ///     Performs only a part of compute phase of transaction execution
        ///     that is used to run get-methods of ABI-compatible contracts.
        /// </summary>
        /// <remarks>
        ///     If you try to run get methods with <see cref="RunExecutor(ParamsOfRunExecutor)"/> you will get an error,
        ///     because it checks ACCEPT and exits
        ///     if there is none, which is actually true for get methods. <para/>
        ///     
        ///     To get the account boc (bag of cells) - use <see cref="Net.INetModule.Query(Net.Models.ParamsOfQuery)"/>
        ///     method to download it from graphql api (field <c>boc</c> of <c>account</c>)
        ///     or generate it with <see cref="Abi.IAbiModule.EncodeAccount(Abi.Models.ParamsOfEncodeAccount)"/> method. <para/>
        ///     
        ///     To get the message boc - use <see cref="Abi.IAbiModule.EncodeMessage(Abi.Models.ParamsOfEncodeMessage)"/> or prepare it any other way, for instance, with
        ///     Fift script. <para/>
        ///     
        ///     Attention!
        ///     Updated account state is produces as well, but only
        ///     <c>account_state.storage.state.data</c>  part of the boc is updated.
        /// </remarks>
        Task<ResultOfRunTvm> RunTvm(ParamsOfRunTvm @params);

        /// <summary>
        ///     Executes a getmethod of FIFT contract that fulfills the smc-guidelines
        ///     https://test.ton.org/smc-guidelines.txt
        ///     and returns the result data from TVM's stack
        /// </summary>
        Task<ResultOfRunGet> RunGet(ParamsOfRunGet @params);
    }
}
