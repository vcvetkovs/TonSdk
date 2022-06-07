using System.Text.Json.Serialization;
using EverscaleSdk.Common.Converters;

namespace EverscaleSdk.Modules.Abi.Models
{
    public struct ParamsOfDecodeMessageBody
    {
        /// <summary>
        ///     Contract ABI used to decode.
        /// </summary>
        [JsonConverter(typeof(PolymorphicTypeJsonConverter))]
        public Abi Abi { get; set; }

        /// <summary>
        ///     Message body BOC encoded in <c>base64</c>.
        /// </summary>
        public string Body { get; set; }

        /// <summary>
        ///     True if the body belongs to the internal message.
        /// </summary>
        public bool IsInternal { get; set; }

        /// <summary>
        ///     Flag allowing partial BOC decoding when ABI doesn't describe
        ///     the full body BOC. Controls decoder behaviour when after
        ///     decoding all described in ABI params there are some data left
        ///     in BOC:
        ///     
        ///     <list type="bullet">
        ///         <item>
        ///             <term>true</term>
        ///             <description>
        ///                 return decoded values
        ///             </description>
        ///         </item>
        ///         <item>
        ///             <term>false</term>
        ///             <description>
        ///                 return error of incomplete BOC deserialization
        ///                 (default)
        ///             </description>
        ///         </item>
        ///     </list>
        /// </summary>
        public bool? AllowPartial { get; set; }
    }
}
