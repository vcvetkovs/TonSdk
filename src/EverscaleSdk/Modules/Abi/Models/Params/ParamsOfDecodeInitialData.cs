using System.Text.Json.Serialization;
using EverscaleSdk.Common.Converters;

namespace EverscaleSdk.Modules.Abi.Models
{
    public struct ParamsOfDecodeInitialData
    {
        /// <summary>
        ///     Initial data is decoded if this parameter is provided.
        /// </summary>
        [JsonConverter(typeof(PolymorphicTypeJsonConverter))]
        public Abi Abi { get; set; }

        /// <summary>
        ///     Data BOC or BOC handle.
        /// </summary>
        public string Data { get; set; }
    }
}
