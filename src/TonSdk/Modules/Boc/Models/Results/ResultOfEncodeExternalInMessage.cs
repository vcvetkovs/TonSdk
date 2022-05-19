namespace TonSdk.Modules.Boc.Models
{
	public struct ResultOfEncodeExternalInMessage
    {
        /// <summary>
        ///     Message BOC encoded with <c>base64</c>.
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        ///     Message id.
        /// </summary>
        public string MessageId { get; set; }
    }
}

