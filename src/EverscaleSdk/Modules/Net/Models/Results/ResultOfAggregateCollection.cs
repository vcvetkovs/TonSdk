using System.Text.Json;

namespace EverscaleSdk.Modules.Net.Models
{
    public struct ResultOfAggregateCollection
    {
        /// <summary>
        ///     Values for requested fields.
        /// </summary>
        /// <returns>
        ///     An array of strings. Each string refers to the corresponding <c>fields</c> item.
        /// </returns>
        /// <remarks>
        ///     Numeric value is returned as a decimal string representations.
        /// </remarks>
        public JsonElement? Values { get; set; }
    }
}
