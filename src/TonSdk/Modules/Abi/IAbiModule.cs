using System.Threading.Tasks;
using TonSdk.Modules.Abi.Models;

namespace TonSdk.Modules.Abi
{
    /// <summary>
    /// Provides message encoding and decoding according to the ABI.
    /// </summary>
    public interface IAbiModule
    {
        /// <summary>
        /// Combines `hex`-encoded `signature` with `base64`-encoded `unsigned_message`.
        /// Returns signed message encoded in `base64`.
        /// </summary>
        Task<ResultOfAttachSignature> AttachSignature(ParamsOfAttachSignature @params);

        Task<ResultOfAttachSignatureToMessageBody> AttachSignatureToMessageBody(
            ParamsOfAttachSignatureToMessageBody @params);

        /// <summary>
        /// Decodes message body using provided message BOC and ABI.
        /// </summary>
        Task<DecodedMessageBody> DecodeMessage(ParamsOfDecodeMessage @params);

        /// <summary>
        /// Decodes message body using provided body BOC and ABI.
        /// </summary>
        Task<DecodedMessageBody> DecodeMessageBody(ParamsOfDecodeMessageBody @params);

        /// <summary>
        /// Creates account state BOC
        /// 
        /// Creates account state provided with one of these sets of data :
        /// 1. BOC of code, BOC of data, BOC of library
        /// 2. TVC (string in `base64`), keys, init params.
        /// </summary>
        Task<ResultOfEncodeAccount> EncodeAccount(ParamsOfEncodeAccount @params);

        /// <summary>
        /// Encodes message body according to ABI function call.
        /// </summary>
        Task<ResultOfEncodeMessageBody> EncodeMessageBody<TSigner>(
            ParamsOfEncodeMessageBody<TSigner> @params);

        /// <summary>
        /// Encodes an ABI-compatible message
        /// 
        /// Allows to encode deploy and function call messages,
        /// both signed and unsigned.
        /// 
        /// Use cases include messages of any possible type:
        /// - deploy with initial function call (i.e. `constructor` or any other function that is used for some kind
        /// of initialization);
        /// - deploy without initial function call;
        /// - signed/unsigned + data for signing.
        /// 
        /// `Signer` defines how the message should or shouldn't be signed:
        /// 
        /// `Signer::None` creates an unsigned message. This may be needed in case of some public methods,
        /// that do not require authorization by pubkey.
        /// 
        /// `Signer::External` takes public key and returns `data_to_sign` for later signing.
        /// Use `attach_signature` method with the result signature to get the signed message.
        /// 
        /// `Signer::Keys` creates a signed message with provided key pair.
        /// 
        /// [SOON] `Signer::SigningBox` Allows using a special interface to imlepement signing
        /// without private key disclosure to SDK. For instance, in case of using a cold wallet or HSM,
        /// when application calls some API to sign data.
        /// </summary>
        Task<ResultOfEncodeMessage> EncodeMessage<TSigner>(ParamsOfEncodeMessage<TSigner> @params);
    }
}
