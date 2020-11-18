namespace TonSdk.Modules.Net.Models
{
    public struct ParamsOfQueryCollection
    {
        /// <summary>
        /// Collection name (accounts, blocks, transactions, messages, block_signatures).
        /// </summary>
        public string Collection { get; set; }

        /// <summary>
        /// Collection filter.
        /// </summary>
        public dynamic? Filter { get; set; }

        /// <summary>
        /// Projection (result) string.
        /// </summary>
        public string Result { get; set; }

        /// <summary>
        /// Sorting order.
        /// </summary>
        public OrderBy[]? Order { get; set; }

        /// <summary>
        /// Number of documents to return.
        /// </summary>
        public uint? Limit { get; set; }
    }
}
