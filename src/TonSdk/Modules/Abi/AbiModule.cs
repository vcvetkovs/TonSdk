using System.Threading.Tasks;
using TonSdk.Modules.Abi.Models;

namespace TonSdk.Modules.Abi
{
    public class AbiModule : IAbiModule
    {
        private readonly ITonClient _client;

        public AbiModule(ITonClient client)
        {
            _client = client;
        }

        public Task<ResultOfAttachSignature> AttachSignature(ParamsOfAttachSignature @params)
        {
            return _client
                .CallFunction<ResultOfAttachSignature>(Consts.Commands.AttachSignature, @params);
        }

        public Task<ResultOfAttachSignatureToMessageBody> AttachSignatureToMessageBody(
            ParamsOfAttachSignatureToMessageBody @params)
        {
            return _client
                .CallFunction<ResultOfAttachSignatureToMessageBody>(Consts.Commands.AttachSignatureToMessageBody, @params);
        }

        public Task<ResultOfDecodeData> DecodeAccountData(ParamsOfDecodeAccountData @params)
        {
            return _client
                .CallFunction<ResultOfDecodeData>(Consts.Commands.DecodeAccountData, @params);
        }

        public Task<DecodedMessageBody> DecodeMessage(ParamsOfDecodeMessage @params)
        {
            return _client
                .CallFunction<DecodedMessageBody>(Consts.Commands.DecodeMessage, @params);
        }

        public Task<DecodedMessageBody> DecodeMessageBody(ParamsOfDecodeMessageBody @params)
        {
            return _client
                .CallFunction<DecodedMessageBody>(Consts.Commands.DecodeMessageBody, @params);
        }

        public Task<ResultOfEncodeAccount> EncodeAccount(ParamsOfEncodeAccount @params)
        {
            return _client
                .CallFunction<ResultOfEncodeAccount>(Consts.Commands.EncodeAccount, @params);
        }

        public Task<ResultOfEncodeMessageBody> EncodeMessageBody(ParamsOfEncodeMessageBody @params)
        {
            return _client
                .CallFunction<ResultOfEncodeMessageBody>(Consts.Commands.EncodeMessageBody, @params);
        }

        public Task<ResultOfEncodeMessage> EncodeMessage(ParamsOfEncodeMessage @params)
        {
            return _client
                .CallFunction<ResultOfEncodeMessage>(Consts.Commands.EncodeMessage, @params);
        }

        public Task<ResultOfEncodeInternalMessage> EncodeInternalMessage(ParamsOfEncodeInternalMessage @params)
        {
            return _client
                .CallFunction<ResultOfEncodeInternalMessage>(Consts.Commands.EncodeInternalMessage, @params);
        }
    }
}
