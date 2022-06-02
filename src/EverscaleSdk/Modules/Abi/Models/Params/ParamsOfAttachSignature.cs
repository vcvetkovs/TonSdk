using System.Text.Json.Serialization;
using EverscaleSdk.Common.Converters;

namespace EverscaleSdk.Modules.Abi.Models
{
    public struct ParamsOfAttachSignature
    {
        /// <summary>
        ///     Contract ABI.
        /// </summary>
        [JsonConverter(typeof(PolymorphicTypeJsonConverter))]
        public Abi Abi { get; set; }

        /// <remarks>
        ///     Must be encoded with <c>hex</c>.
        /// </remarks>
        public string PublicKey { get; set; }

        /// <summary>
        ///     Unsigned message BOC.
        /// </summary>
        /// <remarks>
        ///     Must be encoded with <c>base64</c>.
        /// </remarks>
        public string Message { get; set; }

        /// <remarks>
        ///     Must be encoded with <c>hex</c>.
        /// </remarks>
        public string Signature { get; set; }
    }
}
