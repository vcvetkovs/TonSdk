using System;
using System.Threading.Tasks;
using EverscaleSdk.Interop.Enums;
using EverscaleSdk.Modules.Processing.Models;

namespace EverscaleSdk.Modules.Processing
{
    public class ProcessingModule : IProcessingModule
    {
        private readonly IEverscaleClient _client;

        public ProcessingModule(IEverscaleClient client)
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

        public Task<ResultOfProcessMessage> ProcessMessage(ParamsOfProcessMessage @params)
        {
            return _client
                .CallFunction<ResultOfProcessMessage>(Consts.Commands.ProcessMessage, @params);
        }
    }
}
