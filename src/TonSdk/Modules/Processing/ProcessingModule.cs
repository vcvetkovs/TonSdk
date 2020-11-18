using System;
using System.Threading.Tasks;
using TonSdk.Interop.Enums;
using TonSdk.Modules.Processing.Models;

namespace TonSdk.Modules.Processing
{
    public class ProcessingModule : IProcessingModule
    {
        private readonly ITonClient _client;

        public ProcessingModule(ITonClient client)
        {
            _client = client;
        }

        public Task<ResultOfSendMessage> SendMessage<T>(ParamsOfSendMessage @params, Action<T, FunctionExecutionStatus> callback = null)
        {
            return _client
                .CallFunction<ResultOfSendMessage, T>(Consts.Commands.SendMessage, @params, callback);
        }

        public Task<ResultOfProcessMessage> WaitForTransaction<T>(ParamsOfWaitForTransaction @params, Action<T, FunctionExecutionStatus> callback = null)
        {
            return _client
                .CallFunction<ResultOfProcessMessage, T>(Consts.Commands.WaitForTransation, @params, callback);
        }

        public Task<ResultOfProcessMessage> ProcessMessage<T, TSigner>(ParamsOfProcessMessage<TSigner> @params, Action<T, FunctionExecutionStatus> callback = null)
        {
            return _client
                .CallFunction<ResultOfProcessMessage, T>(Consts.Commands.WaitForTransation, @params, callback);
        }
    }
}
