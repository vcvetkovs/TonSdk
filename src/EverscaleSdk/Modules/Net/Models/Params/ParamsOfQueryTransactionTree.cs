using System.Text.Json.Serialization;
using EverscaleSdk.Common.Converters;

namespace EverscaleSdk.Modules.Net.Models
{
    public struct ParamsOfQueryTransactionTree
    {
        /// <summary>
        ///     Input message id.
        /// </summary>
        public string InMsg { get; set; }

        /// <summary>
        ///     List of contract ABIs that will be used to decode message bodies. Library will try to decode each
        ///     returned message body using any ABI from the registry.
        /// </summary>
        [JsonConverter(typeof(PolymorphicTypeJsonConverter))]
        public Abi.Models.Abi[] AbiRegistry { get; set; }

        /// <summary>
        ///     If some of the following messages and transactions are missing yet
        ///     The maximum waiting time is regulated by this option.
        /// </summary>
        /// <remarks>
        ///     Default value is 60000 (1 min).
        /// </remarks>
        public uint? Timeout { get; set; }
    }
}
