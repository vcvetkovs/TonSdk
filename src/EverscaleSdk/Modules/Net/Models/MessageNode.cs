using EverscaleSdk.Modules.Abi.Models;

namespace EverscaleSdk.Modules.Net.Models
{
	public struct MessageNode
    {
        /// <summary>
        ///     Message id.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        ///     This field is missing for an external inbound messages.
        /// </summary>
        public string SrcTransactionId { get; set; }

        /// <summary>
        ///     This field is missing for an external outbound messages.
        /// </summary>
        public string DstTransactionId { get; set; }

        /// <summary>
        ///     Source address.
        /// </summary>
        public string Src { get; set; }

        /// <summary>
        ///     Destination address.
        /// </summary>
        public string Dst { get; set; }

        /// <summary>
        ///     Transferred tokens value.
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        ///     Bounce flag.
        /// </summary>
        public bool Bounce { get; set; }

        /// <summary>
        ///     Library tries to decode message body using provided `params.abi_registry`.
        ///     This field will be missing if none of the provided abi can be used to decode.
        /// </summary>
        public DecodedMessageBody DecodedBody { get; set; }
    }
}
