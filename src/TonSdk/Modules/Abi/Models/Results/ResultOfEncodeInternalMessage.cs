namespace TonSdk.Modules.Abi.Models
{
	public class ResultOfEncodeInternalMessage
    {
        /// <summary>
        ///     Message BOC encoded with <c>base64</c>.
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        ///     Destination address.
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        ///     Message id.
        /// </summary>
        public string MessageId { get; set; }
    }
}
