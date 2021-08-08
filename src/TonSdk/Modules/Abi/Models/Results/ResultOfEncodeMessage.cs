namespace TonSdk.Modules.Abi.Models
{
    public struct ResultOfEncodeMessage
    {
        /// <summary>
        ///     Message BOC encoded with <c>base64</c>.
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        ///     Optional data to be signed encoded in <c>base64</c>.
        /// </summary>
        /// <remarks>
        ///     Returned in case of <see cref="Signer.External" />.
        ///  <para/>
        ///     Can be used for external message signing.
        ///     In this case you need to use this data to create signature and
        ///     then produce signed message using <see cref="AbiModule.AttachSignature"/>.
        ///  <para/>
        /// </remarks>
        public string? DataToSign { get; set; }

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
