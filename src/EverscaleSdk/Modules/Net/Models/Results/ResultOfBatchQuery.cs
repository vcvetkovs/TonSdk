using System.Text.Json;

namespace EverscaleSdk.Modules.Net.Models
{
    public struct ResultOfBatchQuery
    {
        /// <summary>
        ///     Result values for batched queries.
        /// </summary>
        /// <remarks>
        ///     Returns an array of values.
        ///     Each value corresponds to <c>queries</c> item.
        /// </remarks>
        public JsonElement[] Results { get; set; }
    }
}
