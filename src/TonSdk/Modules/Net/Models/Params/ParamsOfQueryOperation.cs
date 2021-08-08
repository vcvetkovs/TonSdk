using System.Text.Json;

namespace TonSdk.Modules.Net.Models
{
    public abstract class ParamsOfQueryOperation
    {
        public class QueryCollection : ParamsOfQueryOperation
        {
            /// <summary>
            ///     Collection name (accounts, blocks, transactions, messages, block_signatures).
            /// </summary>
            public string Collection { get; set; }

            /// <summary>
            ///     Collection filter.
            /// </summary>
            public JsonElement Filter { get; set; }

            /// <summary>
            ///     Projection (result) string.
            /// </summary>
            public string Result { get; set; }

            /// <summary>
            ///     Sorting order.
            /// </summary>
            public OrderBy[] Order { get; set; }

            /// <summary>
            ///     Number of documents to return.
            /// </summary>
            public uint? Limit { get; set; }
        }

        public class WaitForCollection : ParamsOfQueryOperation
        {
            /// <summary>
            ///     Collection name (accounts, blocks, transactions, messages, block_signatures).
            /// </summary>
            public string Collection { get; set; }

            /// <summary>
            ///     Collection filter.
            /// </summary>
            public dynamic Filter { get; set; }

            /// <summary>
            ///     Projection (result) string.
            /// </summary>
            public string Result { get; set; }

            /// <summary>
            ///     Query timeout.
            /// </summary>
            public uint? Timeout { get; set; }
        }

        public class AggregateCollection : ParamsOfQueryOperation
        {
            /// <summary>
            ///     Collection name (accounts, blocks, transactions, messages, block_signatures).
            /// </summary>
            public string Collection { get; set; }

            /// <summary>
            ///     Collection filter.
            /// </summary>
            public JsonElement Filter { get; set; }

            /// <summary>
            ///     Projection (result) string.
            /// </summary>
            public FieldAggregation[] Fields { get; set; }
        }

        public class QueryCounterparties : ParamsOfQueryOperation
        {
            /// <summary>
            ///     Account address.
            /// </summary>
            public string Account { get; set; }

            /// <summary>
            ///     Projection (result) string.
            /// </summary>
            public string Result { get; set; }

            /// <summary>
            ///     Number of counterparties to return.
            /// </summary>
            public uint? First { get; set; }

            /// <summary>
            ///     `cursor` field of the last received result.
            /// </summary>
            public string After { get; set; }
        }
    }
}
