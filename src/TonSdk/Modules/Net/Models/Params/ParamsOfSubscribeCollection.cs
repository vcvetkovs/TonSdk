namespace TonSdk.Modules.Net.Models
{
    public struct ParamsOfSubscribeCollection
    {
        /// <summary>
        ///     Collection name (accounts, blocks, transactions, messages, block_signatures).
        /// </summary>
        public string Collection { get; set; }

        /// <summary>
        ///     Collection filter.
        /// </summary>
        public dynamic? Filter { get; set; }

        /// <summary>
        ///     Projection (result) string.
        /// </summary>
        public string Result { get; set; }
    }
}
