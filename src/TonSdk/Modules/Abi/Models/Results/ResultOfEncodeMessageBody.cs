namespace TonSdk.Modules.Abi.Models
{
    public struct ResultOfEncodeMessageBody
    {
        /// <summary>
        ///     Message body BOC encoded with <c>base64</c>.
        /// </summary>
        public string Body { get; set; }

        /// <summary>
        ///     Optional data to sign. <para/>
        ///     
        ///     Encoded with <c>base64</c>.
        /// </summary>
        /// <remarks>
        ///     Presents when <c>message</c> is unsigned. <para/>
        ///     
        ///     Can be used for external message signing.
        ///     Is this case you need to sing this data and
        ///     produce signed message using <see cref="AbiModule.AttachSignature(ParamsOfAttachSignature)"/>.
        /// </remarks>
        public string? DataToSign { get; set; }
    }
}
