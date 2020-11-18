using System.Threading.Tasks;
using TonSdk.Common;
using TonSdk.Modules.Net.Models;

namespace TonSdk.Modules.Net
{
    public class NetModule : INetModule
    {
        private readonly ITonClient _client;

        public NetModule(ITonClient client)
        {
            _client = client;
        }

        public Task<ResultOfQueryCollection> QueryCollection(ParamsOfQueryCollection @params)
        {
            return _client
                .CallFunction<ResultOfQueryCollection>(Consts.Commands.QueryCollection, @params);
        }

        public Task<ResultOfWaitForCollection> WaitForCollection(ParamsOfWaitForCollection @params)
        {
            return _client
                .CallFunction<ResultOfWaitForCollection>(Consts.Commands.WaitForCollection, @params);
        }

        public AsyncDataStream<string> SubscribeCollection(ParamsOfSubscribeCollection @params)
        {
            return _client
                .SubscribeToFunction<ResultOfSubscribeCollection>(
                    Consts.Commands.SubscribeCollection,
                    @params,
                    Unsubscribe);
        }

        private Task Unsubscribe(ResultOfSubscribeCollection @params)
        {
            return _client
                .CallFunction<ResultOfQueryCollection>(Consts.Commands.Unsubscribe, @params);
        }
    }
}
