using System.Text.Json;

namespace TonSdk.Modules.Abi.Models
{
	public struct ResultOfDecodeAccountData
    {
        /// <summary>
        ///     Decoded data as a JSON structure.
        /// </summary>
        public JsonElement? Data { get; set; }
    }
}

