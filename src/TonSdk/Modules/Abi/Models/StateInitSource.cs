using System.Text.Json.Serialization;
using TonSdk.Common.Converters;

namespace TonSdk.Modules.Abi.Models
{
    public abstract class StateInitSource
    {
        /// <summary>
        ///     Deploy message.
        /// </summary>
        public class Message : StateInitSource
        {
            [JsonConverter(typeof(PolymorphicTypeJsonConverter))]
            public MessageSource Source { get; set; }
        }

        /// <summary>
        ///     State init data.
        /// </summary>
        public class StateInit : StateInitSource
        {
            /// <remarks>
            ///     Encoded in <c>base64</c>.
            /// </remarks>
            public string Code { get; set; }

            /// <remarks>
            ///     Encoded in <c>base64</c>.
            /// </remarks>
            public string Data { get; set; }

            /// <remarks>
            ///     Encoded in <c>base64</c>.
            /// </remarks>
            public string Library { get; set; }
        }

        /// <summary>
        ///     Content of the TVC file.
        /// </summary>
        /// <remarks>
        ///     Encoded in <c>base64</c>.
        /// </remarks>
        public class Tvc : StateInitSource
        {
            public string TvcProperty { get; set; }

            public string PublicKey { get; set; }

            public StateInitParams InitParams { get; set; }
        }
    }
}
