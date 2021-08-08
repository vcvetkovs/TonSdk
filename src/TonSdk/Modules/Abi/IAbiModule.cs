using System.Threading.Tasks;
using TonSdk.Modules.Abi.Models;

namespace TonSdk.Modules.Abi
{
    /// <summary>
    ///     Provides message encoding and decoding according to the ABI specification.
    /// </summary>
    public interface IAbiModule
    {
        /// <summary>
        ///     Combines <c>hex</c>-encoded <see cref="ParamsOfAttachSignature.Signature"/>
        ///     with <c>base64</c>-encoded <see cref="ParamsOfAttachSignature.Message"/>.
        /// </summary>
        /// <returns>Signed message encoded in <c>base64</c>.</returns>
        Task<ResultOfAttachSignature> AttachSignature(ParamsOfAttachSignature @params);

        Task<ResultOfAttachSignatureToMessageBody> AttachSignatureToMessageBody(
            ParamsOfAttachSignatureToMessageBody @params);

        /// <summary>
        ///     Note: this feature requires ABI 2.1 or higher.
        /// </summary>
        Task<ResultOfDecodeData> DecodeAccountData(ParamsOfDecodeAccountData @params);

        /// <summary>
        ///     Decodes message body using provided message BOC and ABI.
        /// </summary>
        Task<DecodedMessageBody> DecodeMessage(ParamsOfDecodeMessage @params);

        /// <summary>
        ///     Decodes message body using provided body BOC and ABI.
        /// </summary>
        Task<DecodedMessageBody> DecodeMessageBody(ParamsOfDecodeMessageBody @params);

        /// <summary>
        ///     Creates account state BOC
        ///  <para/>
        ///     Creates account state provided with one of these sets of data:
        ///     <list type="number">
        ///         <item>BOC of code, BOC of data, BOC of library</item>
        ///         <item>TVC (string in <c>base64</c>), keys, init params.</item>
        ///     </list>
        /// </summary>
        Task<ResultOfEncodeAccount> EncodeAccount(ParamsOfEncodeAccount @params);

        /// <summary>
        ///     Encodes message body according to ABI function call.
        /// </summary>
        Task<ResultOfEncodeMessageBody> EncodeMessageBody(ParamsOfEncodeMessageBody @params);

        /// <summary>
        ///     Encodes an ABI-compatible message.<para/>
        ///     
        ///     Allows to encode deploy and function call messages,
        ///     both signed and unsigned.<para/>
        ///     
        ///     Use cases include messages of any possible type:
        ///     
        ///     <list type="bullet">
        ///      <item>deploy with initial function call (i.e. <c>constructor</c> or any other function that is used for some kind
        ///     of initialization);</item>
        ///      <item>deploy without initial function call;</item>
        ///      <item>signed/unsigned + data for signing.</item>
        ///     </list>
        /// 
        ///     <see cref="ParamsOfEncodeMessage.Signer"/> defines how the message should or shouldn't be signed:
        ///     
        ///     <list type="bullet">
        ///      <item>
        ///       <term>
        ///         <see cref="Signer.None"/>
        ///       </term>
        ///       <description>
        ///         creates an unsigned message. This may be needed in case of some public methods,
        ///         that do not require authorization by pubkey.
        ///       </description>
        ///      </item>
        ///      <item>
        ///       <term>
        ///         <see cref="Signer.External"/>
        ///       </term>
        ///       <description>
        ///         takes public key and returns <see cref="ResultOfEncodeMessage.DataToSign"/> for later signing.
        ///         Use <see cref="IAbiModule.AttachSignature(ParamsOfAttachSignature)"/> method
        ///         with the result signature to get the signed message.
        ///       </description>
        ///      </item>
        ///      <item>
        ///       <term>
        ///         <see cref="Signer.Keys"/>
        ///       </term>
        ///       <description>
        ///         creates a signed message with provided key pair.
        ///       </description>
        ///      </item>
        ///      <item>
        ///       <term>
        ///         [SOON] <see cref="Signer.SigningBox"/>
        ///       </term>
        ///       <description>
        ///         Allows using a special interface to imlepement signing
        ///         without private key disclosure to SDK. For instance, in case of using a cold wallet or HSM,
        ///         when application calls some API to sign data.
        ///       </description>
        ///      </item>
        ///     </list>
        ///     
        ///     There is an optional public key can be provided in deploy set in order to substitute one
        ///     in TVM file.<para/>
        /// 
        ///     Public key resolving priority:
        ///     
        ///     <list type="number">
        ///      <item>Public key from deploy set.</item>
        ///      <item>Public key, specified in TVM file.</item>
        ///      <item>Public key, provided by signer.</item>
        ///     </list>
        /// </summary>
        Task<ResultOfEncodeMessage> EncodeMessage(ParamsOfEncodeMessage @params);

        /// <summary>
        ///     Allows to encode deploy and function call messages.<para/>
        ///     
        ///     Use cases include messages of any possible type:
        ///     
        ///     <list type="bullet">
        ///      <item>deploy with initial function call (i.e. <c>constructor</c> or any other function that is used for some kind
        ///     of initialization);</item>
        ///      <item>deploy without initial function call;</item>
        ///      <item>simple function call</item>
        ///     </list>
        /// 
        ///     There is an optional public key can be provided in deploy set in order to substitute one
        ///     in TVM file.<para/>
        ///     
        ///     Public key resolving priority:
        ///     
        ///     <list type="number">
        ///      <item>Public key from deploy set.</item>
        ///      <item>Public key, specified in TVM file.</item>
        ///     </list>
        /// </summary>
        Task<ResultOfEncodeInternalMessage> EncodeInternalMessage(ParamsOfEncodeInternalMessage @params);
    }
}
