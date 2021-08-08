using System.Text.Json;

namespace TonSdk.Modules.Net.Models
{
    public struct ParamsOfResumeTransactionIterator
    {
        /// <summary>
        ///     Same as value returned from <see cref="INetModule.IteratorNext(ParamsOfIteratorNext)"/>.
        /// </summary>
        public dynamic ResumeState { get; set; }

        /// <summary>
        ///     Application can specify the list of accounts for which
        ///     it wants to iterate transactions.
        /// </summary>
        /// <remarks>
        ///     If this parameter is missing or an empty list then the library iterates
        ///     transactions for all accounts that passes the shard filter. <para/>
        ///     
        ///     Note that the library doesn't detect conflicts between the account filter and the shard filter
        ///     if both are specified.
        ///     So it is the application's responsibility to specify the correct filter combination.
        /// </remarks>
        public string[] AccountsFilter { get; set; }
    }
}
