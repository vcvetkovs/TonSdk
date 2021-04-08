using System.Threading.Tasks;
using TonSdk.Modules.Boc.Models;

namespace TonSdk.Modules.Boc
{
    public class BocModule : IBocModule
    {
        private readonly ITonClient _client;

        public BocModule(ITonClient client)
        {
            _client = client;
        }

        public Task<ResultOfParse> ParseMessage(ParamsOfParse @params)
        {
            return _client.CallFunction<ResultOfParse>(Consts.Commands.ParseMessage, @params);
        }

        public Task<ResultOfParse> ParseTransaction(ParamsOfParse @params)
        {
            return _client.CallFunction<ResultOfParse>(Consts.Commands.ParseTransaction, @params);
        }

        public Task<ResultOfParse> ParseAccount(ParamsOfParse @params)
        {
            return _client.CallFunction<ResultOfParse>(Consts.Commands.ParseAccount, @params);
        }

        public Task<ResultOfParse> ParseBlock(ParamsOfParse @params)
        {
            return _client.CallFunction<ResultOfParse>(Consts.Commands.ParseBlock, @params);
        }

        public Task<ResultOfParse> ParseShardState(ParamsOfParseShardState @params)
        {
            return _client.CallFunction<ResultOfParse>(Consts.Commands.ParseShardState, @params);
        }

        public Task<ResultOfGetBlockchainConfig> GetBlockchainConfig(ParamsOfGetBlockchainConfig @params)
        {
            return _client.CallFunction<ResultOfGetBlockchainConfig>(Consts.Commands.GetBlockchainConfig, @params);
        }

        public Task<ResultOfGetBocHash> GetBocHash(ParamsOfGetBocHash @params)
        {
            return _client.CallFunction<ResultOfGetBocHash>(Consts.Commands.GetBocHash, @params);
        }

        public Task<ResultOfGetCodeFromTvc> GetCodeFromTvc(ParamsOfGetCodeFromTvc @params)
        {
            return _client.CallFunction<ResultOfGetCodeFromTvc>(Consts.Commands.GetCodeFromTvc, @params);
        }

        public Task<ResultOfBocCacheGet> CacheGet(ParamsOfBocCacheGet @params)
        {
            return _client.CallFunction<ResultOfBocCacheGet>(Consts.Commands.CacheGet, @params);
        }

        public Task<ResultOfBocCacheSet> CacheSet(ParamsOfBocCacheSet @params)
        {
            return _client.CallFunction<ResultOfBocCacheSet>(Consts.Commands.CacheSet, @params);
        }

        public Task CacheUnpin(ParamsOfBocCacheUnpin @params)
        {
            return _client.CallFunction(Consts.Commands.CacheUnpin, @params);
        }

        public Task<ResultOfEncodeBoc> EncodeBoc(ParamsOfEncodeBoc @params)
        {
            return _client.CallFunction<ResultOfEncodeBoc>(Consts.Commands.EncodeBoc, @params);
        }
    }
}
