namespace EverscaleSdk.Modules.Boc.Models
{
	public struct ParamsOfEncodeExternalInMessage
    {
        /// <summary>
        ///     Source address.
        /// </summary>
        public string Src { get; set; }

        /// <summary>
        ///     Destination address.
        /// </summary>
        public string Dst { get; set; }

        /// <summary>
        ///     Bag of cells with state init (used in deploy messages).
        /// </summary>
        public string Init { get; set; }

        /// <summary>
        ///     Bag of cells with the message body encoded as base64.
        /// </summary>
        public string Body { get; set; }

        /// <summary>
        ///     Cache type to put the result.
        ///     The BOC itself returned if no cache type provided
        /// </summary>
        public BocCacheType BocCache { get; set; }
    }
}

