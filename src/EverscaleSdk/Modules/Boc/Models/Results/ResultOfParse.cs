using System.Text.Json;

namespace EverscaleSdk.Modules.Boc.Models
{
    public struct ResultOfParse
    {
        /// <summary>
        ///     JSON containing parsed BOC.
        /// </summary>
        public JsonElement Parsed { get; set; }
    }
}
