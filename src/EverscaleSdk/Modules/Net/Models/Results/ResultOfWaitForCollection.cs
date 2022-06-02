using System.Text.Json;

namespace EverscaleSdk.Modules.Net.Models
{
    public struct ResultOfWaitForCollection
    {
        /// <summary>
        ///     First found object that matches the provided criteria.
        /// </summary>
        public JsonElement Result { get; set; }
    }
}
