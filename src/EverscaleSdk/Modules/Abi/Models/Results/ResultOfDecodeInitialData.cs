using System.Text.Json;

namespace EverscaleSdk.Modules.Abi.Models
{
    public struct ResultOfDecodeInitialData
    {
        /// <summary>
        ///     Initial data is decoded if `abi` input parameter is provided.
        /// </summary>
        public JsonElement InitialData { get; set; }

        /// <summary>
        ///     Initial account owner's public key.
        /// </summary>
        public string InitialPubkey { get; set; }
    }
}
