namespace TonSdk.Modules.Net.Models
{
    public struct ParamsOfBatchQuery
    {
        /// <summary>
        ///     List of query operations that must be performed per single fetch.
        /// </summary>
        public ParamsOfQueryOperation[] Operations { get; set; }
    }
}
