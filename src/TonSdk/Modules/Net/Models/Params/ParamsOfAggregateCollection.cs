using System.Text.Json;

namespace TonSdk.Modules.Net.Models
{
    public struct ParamsOfAggregateCollection
    {
        /// <summary>
        ///     Collection name (accounts, blocks, transactions, messages, block_signatures).
        /// </summary>
        public string Collection { get; set; }

        /// <summary>
        ///     Collection filter.
        /// </summary>
        public JsonElement? Filter { get; set; }

        /// <summary>
        ///     Projection (result) string.
        /// </summary>
        public FieldAggregation[] Fields { get; set; }
    }
}
