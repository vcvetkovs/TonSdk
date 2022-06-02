using System.Text.Json;

namespace EverscaleSdk.Modules.Net.Models
{
    public struct ResultOfQueryCollection
    {
        /// <summary>
        ///     Objects that match the provided criteria.
        /// </summary>
        public JsonElement[] Result { get; set; }
    }
}
