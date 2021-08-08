namespace TonSdk.Modules.Net.Models
{
    public struct ParamsOfCreateBlockIterator
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
        ///     the specified shard prefixes. <para/>
        ///     
        ///     Shard prefix must be represented as a string "workchain:prefix".
        ///     Where `workchain` is a signed integer and the `prefix` if a hexadecimal
        ///     representation if the 64-bit unsigned integer with tagged shard prefix.
        ///     For example: "0:3800000000000000".
        /// </summary>
        public string[] ShardFilter { get; set; }

        /// <summary>
        ///     List of the fields that must be returned for iterated items.
        /// </summary>
        /// <remarks>
        ///     This field is the same as the <see cref="ParamsOfQueryCollection.Result"/> parameter of
        ///     the <see cref="INetModule.QueryCollection(ParamsOfQueryCollection)"/> function. <para/>
        ///     
        ///     Note that iterated items can contains additional fields that are
        ///     not requested in the `result`.
        /// </remarks>
        public string Result { get; set; }
    }

}
