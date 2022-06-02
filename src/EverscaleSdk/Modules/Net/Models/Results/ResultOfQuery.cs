using System.Text.Json;

namespace EverscaleSdk.Modules.Net.Models
{
    public struct ResultOfQuery
    {
        /// <summary>
        ///     Result provided by DAppServer.
        /// </summary>
        public JsonElement? Result { get; set; }
    }
}
