using System.Text.Json.Serialization;

namespace TonSdk.Modules.Client.Models
{
	public struct ParamsOfResolveAppRequest
    {
        /// <summary>
        ///     Request ID received from SDK.
        /// </summary>
        public uint AppRequestId { get; set; }

        /// <summary>
        ///     Result of request processing.
        /// </summary>
        public AppRequestResult Result { get; set; }
    }
}
