using System.Text.Json;

namespace TonSdk.Modules.Net.Models
{
    public struct ParamsOfQuery
    {
        /// <summary>
        ///     GraphQL query text.
        /// </summary>
        public string Query { get; set; }

        /// <summary>
        ///      Variables used in query. <para/>
        ///     
        ///      Must be a map with named values that can be used in query.
        /// </summary>
        public JsonElement? Variables { get; set; }
    }
}
