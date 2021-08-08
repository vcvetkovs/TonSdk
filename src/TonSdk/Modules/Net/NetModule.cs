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
            return _client.CallFunction<ResultOfQueryCollection>(Consts.Commands.QueryCollection, @params);
        }

        public Task<ResultOfWaitForCollection> WaitForCollection(ParamsOfWaitForCollection @params)
        {
            return _client.CallFunction<ResultOfWaitForCollection>(Consts.Commands.WaitForCollection, @params);
        }

        public AsyncDataStream<string> SubscribeCollection(ParamsOfSubscribeCollection @params)
        {
            return _client
                .SubscribeToFunction<ResultOfSubscribeCollection>(
                    Consts.Commands.SubscribeCollection,
                    @params,
                    Unsubscribe);
        }

        public Task<ResultOfQuery> Query(ParamsOfQuery @params)
        {
            return _client.CallFunction<ResultOfQuery>(Consts.Commands.Query, @params);
        }

        public Task<ResultOfBatchQuery> BatchQuery(ParamsOfBatchQuery @params)
        {
            return _client.CallFunction<ResultOfBatchQuery>(Consts.Commands.BatchQuery, @params);
        }

        public Task<ResultOfAggregateCollection> AggregateCollection(ParamsOfAggregateCollection @params)
        {
            return _client.CallFunction<ResultOfAggregateCollection>(Consts.Commands.AggregateCollection, @params);
        }

        public Task Suspend()
        {
            return _client.CallFunction(Consts.Commands.Suspend);
        }

        public Task Resume()
        {
            return _client.CallFunction(Consts.Commands.Resume);
        }

        public Task<ResultOfFindLastShardBlock> FindLastShardBlock(ParamsOfFindLastShardBlock @params)
        {
            return _client.CallFunction<ResultOfFindLastShardBlock>(Consts.Commands.FindLastShardBlock, @params);
        }

        public Task<EndpointsSet> FetchEndpoints()
        {
            return _client.CallFunction<EndpointsSet>(Consts.Commands.FetchEndpoints);
        }

        public Task SetEndpoints(EndpointsSet @params)
        {
            return _client.CallFunction<ResultOfBatchQuery>(Consts.Commands.SetEndpoints, @params);
        }

        private Task Unsubscribe(ResultOfSubscribeCollection @params)
        {
            return _client.CallFunction<ResultOfQueryCollection>(Consts.Commands.Unsubscribe, @params);
        }

        public async Task<ResultOfGetEndpoints> GetEndpoints()
        {
            return await _client.CallFunction<ResultOfGetEndpoints>(Consts.Commands.GetEndpoints);
        }

        public async Task<ResultOfQueryCollection> QueryCounterparties(ParamsOfQueryCounterparties @params)
        {
            return await _client.CallFunction<ResultOfQueryCollection>(Consts.Commands.QueryCounterparties, @params);
        }

        public async Task<ResultOfQueryTransactionTree> QueryTransactionTree(ParamsOfQueryTransactionTree @params)
        {
            return await _client.CallFunction<ResultOfQueryTransactionTree>(Consts.Commands.QueryTransactionTree, @params);
        }

        public async Task<RegisteredIterator> CreateBlockIterator(ParamsOfCreateBlockIterator @params)
        {
            return await _client.CallFunction<RegisteredIterator>(Consts.Commands.CreateBlockIterator, @params);
        }

        public async Task<RegisteredIterator> ResumeBlockIterator(ParamsOfResumeBlockIterator @params)
        {
            return await _client.CallFunction<RegisteredIterator>(Consts.Commands.ResumeBlockIterator, @params);
        }

        public async Task<RegisteredIterator> CreateTransactionIterator(ParamsOfCreateTransactionIterator @params)
        {
            return await _client.CallFunction<RegisteredIterator>(Consts.Commands.CreateTransactionIterator, @params);
        }

        public async Task<RegisteredIterator> ResumeTransactionIterator(ParamsOfResumeTransactionIterator @params)
        {
            return await _client.CallFunction<RegisteredIterator>(Consts.Commands.ResumeTransactionIterator, @params);
        }

        public async Task<ResultOfIteratorNext> IteratorNext(ParamsOfIteratorNext @params)
        {
            return await _client.CallFunction<ResultOfIteratorNext>(Consts.Commands.IteratorNext, @params);
        }

        public async Task RemoveIterator(RegisteredIterator @params)
        {
            await _client.CallFunction(Consts.Commands.RemoveIterator, @params);
        }
    }
}
