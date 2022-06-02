using System.Text.Json;
using System.Threading.Tasks;
using EverscaleSdk.Modules.Abi.Models;

namespace EverscaleSdk.Modules.Abi
{
    public class AbiModule : IAbiModule
    {
        private readonly IEverscaleClient _client;

        public AbiModule(IEverscaleClient client)
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

        public Task<ResultOfDecodeAccountData> DecodeAccountData(ParamsOfDecodeAccountData @params)
        {
            return _client
                .CallFunction<ResultOfDecodeAccountData>(Consts.Commands.DecodeAccountData, @params);
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

        public Task<ResultOfUpdateInitialData> UpdateInitialData(ParamsOfUpdateInitialData @params)
        {
            return _client
                .CallFunction<ResultOfUpdateInitialData>(Consts.Commands.UpdateInitialData, @params);
        }

        public Task<ResultOfDecodeInitialData> DecodeInitialData(ParamsOfDecodeInitialData @params)
        {
            return _client
                .CallFunction<ResultOfDecodeInitialData>(Consts.Commands.DecodeInitialData, @params);
        }

        public Task<ResultOfEncodeInitialData> EncodeInitialData(ParamsOfEncodeInitialData @params)
        {
            return _client
                .CallFunction<ResultOfEncodeInitialData>(Consts.Commands.EncodeInitialData, @params);
        }

        public Task<ResultOfDecodeBoc> DecodeBoc(ParamsOfDecodeBoc @params)
        {
            return _client
                .CallFunction<ResultOfDecodeBoc>(Consts.Commands.DecodeBoc, @params);
        }

        public Task<ResultOfAbiEncodeBoc> EncodeBoc(ParamsOfAbiEncodeBoc @params)
        {
            return _client
                .CallFunction<ResultOfAbiEncodeBoc>(Consts.Commands.EncodeBoc, @params);
        }
    }
}
