using System.Text.Json.Serialization;
using EverscaleSdk.Common.Converters;

namespace EverscaleSdk.Modules.Abi.Models
{
    public struct ParamsOfDecodeMessage
    {
        /// <summary>
        ///     Contract ABI.
        /// </summary>
        [JsonConverter(typeof(PolymorphicTypeJsonConverter))]
        public Abi Abi { get; set; }

        /// <summary>
        ///     Message BOC.
        /// </summary>
        public string Message { get; set; }

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
