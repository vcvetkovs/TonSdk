using System.Text.Json.Serialization;
using TonSdk.Common.Converters;

namespace TonSdk.Modules.Abi.Models
{
	public struct ParamsOfEncodeInternalMessage
    {
        /// <summary>
        ///     Contract ABI.
        /// </summary>
        /// <remarks>
        ///     Can be None if both deploy_set and call_set are None.
        /// </remarks>
        [JsonConverter(typeof(PolymorphicTypeJsonConverter))]
        public Abi Abi { get; set; }

        /// <summary>
        ///     Target address the message will be sent to.
        /// </summary>
        /// <remarks>
        ///     Must be specified in case of non-deploy message.
        /// </remarks>
        public string Address { get; set; }

        /// <summary>
        ///     Source address of the message.
        /// </summary>
        public string SrcAddress { get; set; }

        /// <summary>
        ///     Deploy parameters.
        /// </summary>
        /// <remarks>
        ///     Must be specified in case of non-deploy message.
        /// </remarks>
        public DeploySet DeploySet { get; set; }

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
        public CallSet CallSet { get; set; }

        /// <summary>
        ///     Value in nanotokens to be sent with message.
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        ///     Flag of bounceable message.
        /// </summary>
        /// <remarks>
        ///     Default is true.
        /// </remarks>
        public bool? Bounce { get; set; }

        /// <summary>
        ///     Enable Instant Hypercube Routing for the message.
        /// </summary>
        /// <remarks>
        ///     Default is false.
        /// </remarks>
        public bool? EnableIhr { get; set; }
    }
}
