using System.Text.Json;

namespace TonSdk.Modules.Abi.Models
{
    public struct ResultOfDecodeBoc
    {
        /// <summary>
        ///     Decoded data as a JSON structure.
        /// </summary>
        public JsonElement Data { get; set; }
    }
}
