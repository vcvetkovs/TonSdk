namespace TonSdk.Modules.Net.Models
{
    public class ParamsOfCreateTransactionIterator
    {
        /// <summary>
        ///     If the application specifies this parameter then the iteration
        ///     includes blocks with `gen_utime` >= `start_time`.
        ///     Otherwise the iteration starts from zero state.
        /// </summary>
        /// <remarks>
        ///     Must be specified in seconds.
        /// </remarks>
        public uint? StartTime { get; set; }

        /// <summary>
        ///     If the application specifies this parameter then the iteration
        ///     includes blocks with `gen_utime` < `end_time`.
        ///     Otherwise the iteration never stops.
        /// </summary>
        /// <remarks>
        ///     Must be specified in seconds.
        /// </remarks>
        public uint? EndTime { get; set; }

        /// <summary>
        ///     If the application specifies this parameter and it is not the empty array
        ///     then the iteration will include items related to accounts that belongs to
        ///     the specified shard prefixes.
        ///  <para/>
        ///     Shard prefix must be represented as a string "workchain:prefix".
        ///     Where `workchain` is a signed integer and the `prefix` if a hexadecimal
        ///     representation if the 64-bit unsigned integer with tagged shard prefix.
        ///     For example: "0:3800000000000000". <para/>
        ///     
        ///     Account address conforms to the shard filter if
        ///     it belongs to the filter workchain and the first bits of address match to
        ///     the shard prefix.
        ///     Only transactions with suitable account addresses are iterated.
        /// </summary>
        public string[] ShardFilter { get; set; }

        /// <summary>
        ///     Application can specify the list of accounts for which
        ///     it wants to iterate transactions.
        /// </summary>
        /// <remarks>
        ///     If this parameter is missing or an empty list then the library iterates
        ///     transactions for all accounts that pass the shard filter. <para/>
        ///     
        ///     Note that the library doesn't detect conflicts between the account 
        ///     filter and the shard filter if both are specified.
        ///     So it is an application responsibility to specify the correct filter combination.
        /// </remarks>
        public string[] AccountsFilter { get; set; }

        /// <summary>
        ///     List of the fields that must be returned for iterated items.
        /// </summary>
        /// <remarks>
        ///     This field is the same as the <see cref="ParamsOfQueryCollection.Result"/> parameter of
        ///     the <see cref="INetModule.QueryCollection(ParamsOfQueryCollection)"/> function. <para/>
        ///     
        ///     Note that iterated items can contain additional fields that are
        ///     not requested in the <see cref="Result"/>.
        /// </remarks>
        public string Result { get; set; }

        /// <summary>
        ///     If this parameter is <c>true</c> then each transaction contains field
        ///     <c>transfers</c> with list of transfer.
        /// </summary>
        public bool? IncludeTransfers { get; set; }
    }
}
