using System.Text.Json.Serialization;
using EverscaleSdk.Common.Converters;

namespace EverscaleSdk.Modules.Abi.Models
{
    public struct ParamsOfEncodeMessage
    {
        /// <summary>
        ///     Contract ABI.
        /// </summary>
        [JsonConverter(typeof(PolymorphicTypeJsonConverter))]
        public Abi Abi { get; set; }

        /// <summary>
        ///     Target address the message will be sent to.
        /// </summary>
        /// <remarks>
        ///     Must be specified in case of non-deploy message.
        /// </remarks>
        public string? Address { get; set; }

        /// <summary>
        ///     Deploy parameters.
        /// </summary>
        /// <remarks>
        ///     Must be specified in case of non-deploy message.
        /// </remarks>
        public DeploySet? DeploySet { get; set; }

        /// <summary>
        ///     Function call parameters.
        /// </summary>
        /// <remarks>
        ///     Must be specified in case of non-deploy message.
        ///  <para/>
        ///     In case of deploy message it is optional and contains parameters
        ///     of the functions that will to be called upon deploy transaction.
        ///  <para/>
        /// </remarks>
        public CallSet? CallSet { get; set; }

        /// <summary>
        ///     Signing parameters.
        /// </summary>
        [JsonConverter(typeof(PolymorphicTypeJsonConverter))]
        public Signer Signer { get; set; }

        /// <summary>
        ///     Used in message processing with retries (if contract's ABI includes "expire" header).
        /// </summary>
        /// <remarks>
        ///     Encoder uses the provided try index to calculate message
        ///     expiration time. The 1st message expiration time is specified in
        ///     Client config.
        ///  <para/>
        ///     Expiration timeouts will grow with every retry.
        ///     Retry grow factor is set in Client config:
        ///     &lt;.....add config parameter with default value here>
        ///  <para/>
        ///     Default value is 0.
        ///  <para/>
        /// </remarks>
        public byte? ProcessingTryIndex { get; set; }
    }
}
