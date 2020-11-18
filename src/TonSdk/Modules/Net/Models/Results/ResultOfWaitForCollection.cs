using System.Text.Json;

namespace TonSdk.Modules.Net.Models
{
    public struct ResultOfWaitForCollection
    {
        /// <summary>
        /// First found object that matches the provided criteria.
        /// </summary>
        public JsonElement Result { get; set; }
    }
}
